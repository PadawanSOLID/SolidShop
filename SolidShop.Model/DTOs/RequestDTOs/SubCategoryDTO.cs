﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidShop.Model.DTOs.RequestDTOs
{
    public class SubCategoryDTO
    {
        public int CategoryId { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortField { get; set; }
    }
}
