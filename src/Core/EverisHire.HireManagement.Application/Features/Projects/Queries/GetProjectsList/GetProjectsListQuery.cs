using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Queries
{
    public class GetProjectsListQuery : IRequest<List<ProjectListVm>>
    {
        
    }
}