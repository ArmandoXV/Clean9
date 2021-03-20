using Ardalis.GuardClauses;
using Clean9.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean9.Core.Entities
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUri { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public Item()
        {

        }
        public Item(int catalogTypeId,
            int catalogBrandId,
            string description,
            string name,
            decimal price,
            string pictureUri,
            int quantity)
        {
            TypeId = catalogTypeId;
            BrandId = catalogBrandId;
            Description = description;
            Name = name;
            Price = price;
            PictureUri = pictureUri;
            Quantity = quantity;
        }

        public void UpdateDetails(string name, string description, decimal price, int quantity)
        {
            Guard.Against.NullOrEmpty(name, nameof(name));
            Guard.Against.NullOrEmpty(description, nameof(description));
            Guard.Against.NegativeOrZero(price, nameof(price));
            Guard.Against.NegativeOrZero(price, nameof(quantity));

            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public void UpdateBrand(int catalogBrandId)
        {
            Guard.Against.Zero(catalogBrandId, nameof(catalogBrandId));
            BrandId = catalogBrandId;
        }

        public void UpdateType(int catalogTypeId)
        {
            Guard.Against.Zero(catalogTypeId, nameof(catalogTypeId));
            TypeId = catalogTypeId;
        }

        public void UpdatePictureUri(string pictureName)
        {
            if (string.IsNullOrEmpty(pictureName))
            {
                PictureUri = string.Empty;
                return;
            }
            PictureUri = $"images\\products\\{pictureName}?{new DateTime().Ticks}";
        }

        public void UpdateQuantity(int n)
        {
            if (n > Quantity)
            {
                return;
            }
            Quantity -= n;
        }
    }
}
