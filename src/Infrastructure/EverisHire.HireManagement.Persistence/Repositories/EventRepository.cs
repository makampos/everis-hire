using System;
using System.Linq;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {

        public EventRepository(EverisHireDbContext dbContext)
            :base(dbContext)
        {            
        }

        public async Task<bool> IsEventNameAndDateUnique(
            string name,
            DateTime eventDate) 
        {
            return await _dbContext.Events.AnyAsync(
                e => e.Name.Equals(name)
                && e.Date.Date.Equals(eventDate.Date));                        
        }    
    }
}