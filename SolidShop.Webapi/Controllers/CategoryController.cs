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
                        Image =$"/src/assets/images/fridges/fridge{m+1}.png",
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

       

    }
}
