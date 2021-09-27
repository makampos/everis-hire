using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
        
    }
}