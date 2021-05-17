using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Queries.GetProjectsList
{
    public class GetProjectsListQueryHandler:
        IRequestHandler<GetProjectsListQuery, List<ProjectListVm>>
    {
        private readonly IAsyncRepository<Project> _projectRepository;
        private readonly IMapper _mapper;

        public GetProjectsListQueryHandler(
            IAsyncRepository<Project> projectRepository,
            IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }

        public async Task<List<ProjectListVm>> Handle(
            GetProjectsListQuery request,
            CancellationToken cancellationToken)
        {
            var allProjects = (await _projectRepository.ListAllAsync());                
            return _mapper.Map<List<ProjectListVm>>(allProjects);
        }
    }
}