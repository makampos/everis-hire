using System;
using System.Threading.Tasks;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
         
    }
}