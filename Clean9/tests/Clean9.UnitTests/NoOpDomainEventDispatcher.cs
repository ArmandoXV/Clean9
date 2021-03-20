using Clean9.SharedKernel;
using Clean9.SharedKernel.Interfaces;
using System.Threading.Tasks;

namespace Clean9.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
