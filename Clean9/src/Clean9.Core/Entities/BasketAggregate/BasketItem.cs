using Ardalis.GuardClauses;
using Clean9.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean9.Core.Entities.BasketAggregate
{
    public class BasketItem : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public int BasketId { get; set; }


        public BasketItem()
        {

        }
        public BasketItem(int catalogItemId, int quantity, decimal unitPrice)
        {
            ItemId = catalogItemId;
            UnitPrice = unitPrice;
            SetQuantity(quantity);
        }

        public void AddQuantity(int quantity)
        {
            Guard.Against.OutOfRange(quantity, nameof(quantity), 0, int.MaxValue);

            Quantity += quantity;
        }

        public void SetQuantity(int quantity)
        {
            Guard.Against.OutOfRange(quantity, nameof(quantity), 0, int.MaxValue);

            Quantity = quantity;
        }

    }
}
