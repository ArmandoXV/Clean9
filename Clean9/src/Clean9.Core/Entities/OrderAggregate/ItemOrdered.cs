using Ardalis.GuardClauses;
using Clean9.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean9.Core.Entities.OrderAggregate
{
    public class ItemOrdered : BaseEntity
    {
        public int ItemId { get; set; }
        public string ProductName { get; set; }
        public string PictureUri { get; set; }

        public ItemOrdered()
        {

        }
        public ItemOrdered(int catalogItemId, string productName, string pictureUri)
        {
            Guard.Against.OutOfRange(catalogItemId, nameof(catalogItemId), 1, int.MaxValue);
            Guard.Against.NullOrEmpty(productName, nameof(productName));
            Guard.Against.NullOrEmpty(pictureUri, nameof(pictureUri));

            ItemId = catalogItemId;
            ProductName = productName;
            PictureUri = pictureUri;
        }
    }
}
