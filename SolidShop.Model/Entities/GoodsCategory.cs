using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidShop.Model.Entities
{
    public class GoodsCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ParentId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        public bool IsShown { get; set; }

        public DateTime? CreateTime { get; set; }


    }
}
