using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository: IAsyncRepository<Category>
    {
         Task<List<Category>> GetCategoriesWithEvents(
             bool includePassedEvents);
    }
}