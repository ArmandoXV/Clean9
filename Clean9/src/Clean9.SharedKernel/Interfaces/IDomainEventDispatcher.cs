using Clean9.SharedKernel;
using System.Threading.Tasks;

namespace Clean9.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}