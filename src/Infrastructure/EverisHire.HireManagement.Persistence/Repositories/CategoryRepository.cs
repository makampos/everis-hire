using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>,
        ICategoryRepository
    {

        public CategoryRepository(EverisHireDbContext dbContext) 
            : base(dbContext)
        {            
        }

        public async Task<List<Category>> GetCategoriesWithEvents(
            bool includePassedEvents)
        {
            var allCategories = await _dbContext.Categories.Include(
                x => x.Events).ToListAsync();
            if(!includePassedEvents) 
            {
                allCategories.ForEach(p => p.Events.ToList().RemoveAll(
                c => c.Date < DateTime.Today));
            }
            return allCategories;
        }
    }
}