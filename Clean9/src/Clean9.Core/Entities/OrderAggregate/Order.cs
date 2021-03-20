using Ardalis.GuardClauses;
using Clean9.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean9.Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public int Clean9UserID { get; set; }

        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public Address ShipToAddress { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        private Order()
        {
            // required by EF
        }
        public Order(int clean9UserId, Address shipToAddress, ICollection<OrderItem> items)
        {

            Guard.Against.Null(shipToAddress, nameof(shipToAddress));
            Guard.Against.Null(items, nameof(items));

            Clean9UserID = clean9UserId;
            ShipToAddress = shipToAddress;
            OrderItems = items;
        }

        public decimal Total()
        {
            var total = 0m;
            foreach (var item in OrderItems)
            {
                total += item.UnitPrice * item.Units;
            }
            return total;
        }

    }
}
