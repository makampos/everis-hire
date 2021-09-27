using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery : 
        IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}