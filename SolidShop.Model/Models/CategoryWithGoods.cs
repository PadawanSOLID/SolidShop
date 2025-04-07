using SolidShop.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidShop.Model.Models
{
    public class CategoryWithGoods
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public List<Good> Goods { get; set; }
    }
}
