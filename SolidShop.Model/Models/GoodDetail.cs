using SolidShop.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidShop.Model.Models
{
    public class GoodWithDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double OldPrice { get; set; }
        public double Price { get; set; }
        public int SalesCount { get; set; }
        public int CommentCount { get; set; }
        public int CollectCount { get; set; }
        public List<GoodsCategory> Categories { get; set; }
        public Brand Brand { get; set; }
      
        public GoodDetail Details { get; set; }
    }

    public class GoodDetail
    {
        public List<GoodProperty> Properties { get; set; }
        public List<string> Pictures { get; set; }
    }
    public class Brand
    {
        public string Name { get; set; }
    }
    public class GoodProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
