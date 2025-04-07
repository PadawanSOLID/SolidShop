using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidShop.Model.Entities;
using SolidShop.Model.Models;

namespace SolidShop.Webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GoodController : ControllerBase
    {
        public GoodController() { }

        string[] categoryNames = [
               "推荐",
                "电脑办公",
                "房产",
                "配饰",
                "厨具",
            ];
        (string, decimal)[] goods = [
               ("叫叫鞋",259),
                ("儿童运动鞋",109),
                ("男童加绒格子衬衫",125),
                ("休闲潮流运动男士胸包",136),
            ];

        [HttpGet]
        public GoodsCategory FindCategory(int id)
        {
            var category = new GoodsCategory
            {
                Id = id,
                CreateTime = DateTime.Now,
                Image = "",
                IsShown = true,
                ParentId = -1,
                Name = categoryNames[id]
            };
            return category;
        }

        [HttpGet]
        public IEnumerable<GoodsCategory> GetCategory()
        {

            var categories = Enumerable.Range(0, 5).Select(n =>
            {
                return new GoodsCategory
                {
                    Id = n,
                    CreateTime = DateTime.Now,
                    Image = "",
                    IsShown = true,
                    ParentId = -1,
                    Name = categoryNames[n]
                };
            });
            return categories;

        }

        [HttpGet]
        public IEnumerable<string> GetBanner()
        {
            return Enumerable.Range(1, 5).Select(n => $"banner{n}.png");
        }

        [HttpGet]
        public IEnumerable<Good> FindNew()
        {

            return Enumerable.Range(0, 4).Select(n => new Good
            {
                Id = n,
                CreateTime = DateTime.Now,
                Price = goods[n].Item2,
                Name = goods[n].Item1,
                Image = $"new{n + 1}.jpg"
            });
        }

        [HttpGet]
        public IEnumerable<CategoryWithGoods> GetGoods()
        {

            var goodsProduct = categoryNames.Select((n, i) => new CategoryWithGoods
            {
                Id = i + 1,
                Name = n,
                Goods = Enumerable.Range(0, 4).Select(m => new Good
                {
                    Id = m,
                    CreateTime = DateTime.Now,
                    Price = goods[m].Item2,
                    Name = goods[m].Item1,
                    Image = $"new{m + 1}.jpg"
                }).ToList()
            });
            return goodsProduct;
        }
    }
}
