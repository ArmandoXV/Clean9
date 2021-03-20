using Ardalis.GuardClauses;
using Clean9.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean9.Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {

        public ItemOrdered itemOrdered { get; set; }
        public decimal UnitPrice { get; set; }
        public int Units { get; set; }

        private OrderItem()
        {
            // required by EF
        }

        public OrderItem(ItemOrdered itemOrderedtmp, decimal unitPrice, int units)
        {
            itemOrdered = itemOrderedtmp;
            UnitPrice = unitPrice;
            Units = units;
        }
    }
}
