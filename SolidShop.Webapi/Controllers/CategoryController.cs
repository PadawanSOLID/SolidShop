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

        [HttpGet]
        public IEnumerable<GoodsCategory> FindCategory(int id)
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

    }
}
