using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean9.Web.ApiModels
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
    }
}
