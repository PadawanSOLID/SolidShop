using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidShop.Model.Entities;
using SolidShop.Model.Models;

namespace SolidShop.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
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

        [HttpGet("category/head")]
        public ActionResult<GoodsCategory> GetHeadCategory()
        {
            return Ok(category);
        }
        [HttpGet("banner")]
        public ActionResult<List<string>> GetBanner()
        {
            List<string> banners = ["banner1.jpg", "banner1.jpg", "banner1.jpg", "banner1.jpg", "banner1.jpg", "banner1.jpg",];
            return Ok(banners);
        }

        [HttpGet("new")]
        public ActionResult<List<Good>> GetNew()
        {
            var news = Enumerable.Range(0, 4).Select(n => new Good
            {
                Id = n,
                CreateTime = DateTime.Now,
                Price = goods[n].Item2,
                Name = goods[n].Item1,
                Image = $"new{n + 1}.jpg"
            });
            return Ok(news);
        }

        [HttpGet("goods")]
        public ActionResult<List<CategoryWithGoods>> GetGoods()
        {
            var categories = Enumerable.Range(0, 9).Select(n =>
            {
                return new CategoryWithGoods
                {
                    Id = n,
                    Image = "",
                    Name = category[n].Name,
                    Goods = Enumerable.Range(0, 4).Select(m =>
                    {
                        return new Good
                        {
                            Id = m,
                            CreateTime = DateTime.Now,
                            Image = "",
                            Name = goods[m].Item1,
                            Price = goods[m].Item2
                        };
                    }).ToList()
                };
            });
            return Ok(categories);
        }

        [HttpGet("/api/category")]
        public ActionResult<CategoryWithGoods> Category(int id)
        {
            var cate= new CategoryWithGoods
            {
                Id = id,
                Image = "",
                Name = this.category[id].Name,
                Children = category[id]. Children.Select(n=>new CategoryWithGoods
                {
                    Id = n.Id,
                    Image = "",
                    Name = n.Name,
                    Goods = Enumerable.Range(0, 4).Select(m =>
                    {
                        return new Good
                        {
                            Id = m,
                            CreateTime = DateTime.Now,
                            Image = "",
                            Name = goods[m].Item1,
                            Price = goods[m].Item2
                        };
                    }).ToList()
                }).ToList()
            };
            return Ok(cate);
        }
    }


}
