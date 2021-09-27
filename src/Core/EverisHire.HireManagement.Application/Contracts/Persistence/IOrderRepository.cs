using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<List<Order>> GetPagedOrdersForMonth(DateTime date, 
        int page,int size);
        Task<int> GetTotalCountOfOrdersForMonth(DateTime date);
    }
}