using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidShop.Model.Entities;

namespace SolidShop.Webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GoodController : ControllerBase
    {
        public GoodController() { }

        [HttpGet]
        public IEnumerable<GoodsCategory> GetCategory()
        {
            string[] names = [
                "推荐",
                "电脑办公",
                "房产",
                "配饰",
                "厨具",
            ];
            var categories = Enumerable.Range(0, 5).Select(n =>
            {
                return new GoodsCategory
                {
                    Id = n,
                    CreateTime = DateTime.Now,
                    Image = "",
                    IsShown = true,
                    ParentId = -1,
                    Name = names[n]
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
            (string, decimal)[] names = [
                ("叫叫鞋",259),
                ("儿童运动鞋",109),
                ("男童加绒格子衬衫",125),
                ("休闲潮流运动男士胸包",136),
            ];
            return Enumerable.Range(0, 4).Select(n => new Good
            {
                Id = n,
                CreateTime = DateTime.Now,
                Price = names[n].Item2,
                Name = names[n].Item1,
                Image = $"new{n + 1}.jpg"
            });
        }
        [HttpGet]
        public IEnumerable<()> GetGoodsProduct()
        {
            var goodsProduct= Enumerable.Range(0, 5).Select(n => FindNew()).SelectMany(x => x).GroupBy(m=>m.Id);
            return goodsProduct;
        }
    }
}
