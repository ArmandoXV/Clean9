using Ardalis.GuardClauses;
using Clean9.SharedKernel;

namespace Clean9.Core.Entities.BasketAggregate
{
    public class Buyer : BaseEntity
    {
        public string IdentityGuid { get; set; }

        public Basket Basket { get; set; }

        public string Payment { get; set; }

        public Buyer()
        {

        }
        public Buyer(string identity) : this()
        {
            Guard.Against.NullOrEmpty(identity, nameof(identity));
            IdentityGuid = identity;
        }
    }
}