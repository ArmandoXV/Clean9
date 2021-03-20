using Clean9.SharedKernel;
using System.Threading.Tasks;

namespace Clean9.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}