using Clean9.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean9.Core.Entities
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; }
        public Brand(string brandName)
        {
            BrandName = brandName;
        }

        public Brand()
        {
            BrandName = "Genral Item";
        }
    }
}
