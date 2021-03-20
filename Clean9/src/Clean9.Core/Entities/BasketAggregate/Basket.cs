using Clean9.SharedKernel;
using System.Collections.Generic;
using System.Linq;


namespace Clean9.Core.Entities.BasketAggregate
{
    public class Basket : BaseEntity
    {
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }

        public Basket(int buyerId)
        {
            BuyerId = buyerId;
        }

        public void AddItem(int catalogItemId, decimal unitPrice, int quantity = 1)
        {
            if (!BasketItems.Any(i => i.ItemId == catalogItemId))
            {
                BasketItems.Add(new BasketItem(catalogItemId, quantity, unitPrice));
                return;
            }
            var existingItem = BasketItems.FirstOrDefault(i => i.ItemId == catalogItemId);
            existingItem.AddQuantity(quantity);
        }
    }
}
