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
    }
}
