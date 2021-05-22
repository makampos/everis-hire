using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Queries.GetProjectDetail
{
    public class GetProjectDetailQueryHandler : 
        IRequestHandler<GetProjectDetailQuery, ProjectDetailVm>
    {
        private readonly IAsyncRepository<Project> _projectRepository;
        private readonly IMapper _mapper;

        public GetProjectDetailQueryHandler(
            IAsyncRepository<Project> projectRepository,
            IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }

        public async Task<ProjectDetailVm> Handle(
            GetProjectDetailQuery request,
            CancellationToken cancellationToken)
        {
            var @project = await _projectRepository.GetByIdAsync(request.Id);
            var projectDetailDto = _mapper.Map<ProjectDetailVm>(@project);

            return projectDetailDto;
        }
    }
}