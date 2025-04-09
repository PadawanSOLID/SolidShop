using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidShop.Model.DTOs.RequestDTOs;
using SolidShop.Model.Entities;
using SolidShop.Model.Models;

namespace SolidShop.Webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
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
        GoodsCategory[] category = [
new(){Id = 0, Name = "推荐", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now,Children=[
                      new(){Id = 1, Name = "美食", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 2, Name = "服饰", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 3, Name = "母婴", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 4, Name = "个护", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 5, Name = "严选", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 6, Name = "数码", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 7, Name = "运动", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                new(){Id = 8, Name = "杂项", ParentId = -1, IsShown = true, CreateTime = DateTime.Now},
                    ]},
                ];

        [HttpGet]
        public GoodsCategory FindCategory(int id)
        {
            return new GoodsCategory
            {
                Id = id,
                CreateTime = DateTime.Now,
                Image = "",
                IsShown = true,
                ParentId = -1,
                Name = categoryNames[id],
                Children = Enumerable.Range(0, 5).Select(m =>
                {
                    return new GoodsCategory
                    {
                        Id = m,
                        CreateTime = DateTime.Now,
                        Image = $"/src/assets/images/fridges/fridge{m + 1}.png",
                        IsShown = true,
                        ParentId = -1,
                        Name = categoryNames[m]
                    };
                }).ToList()
            };

        }

        [HttpGet]
        public IEnumerable<string> GetBanner(int id)
        {
            return Enumerable.Range(1, 5).Select(n => $"/src/assets/images/banner{n}.png");
        }

        [HttpGet("/api/category/sub/filter")]
        public ActionResult<CategoryWithGoods> GetSubFilter(int id)
        {
            var cwg = new CategoryWithGoods
            {
                Id = category[id].Id,
                Name = category[id].Name,
                ParentName="推荐",
                ParentId=0,
                Goods = goods.Select((n, i) => new Good
                {
                    Id = i,
                    Name = n.Item1,
                    Price = n.Item2,
                    Image = ""
                }).ToList()
            };
            return Ok(cwg);
        }



    }
}
