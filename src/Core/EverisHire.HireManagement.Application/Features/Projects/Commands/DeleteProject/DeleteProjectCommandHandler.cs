using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.DeleteProject
{
    public class DeleteProjectCommandHandler :
        IRequestHandler<DeleteProjectCommand>
    {
        private readonly IAsyncRepository<Project> _projectRepository;
        private readonly IMapper _mapper;
        public DeleteProjectCommandHandler(IMapper mapper,
             IAsyncRepository<Project> projectRepository)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }
        public async Task<Unit> Handle(DeleteProjectCommand request,
             CancellationToken cancellationToken)
        {
            var projectToDelete = await _projectRepository.GetByIdAsync(request.ProjectId);
            await _projectRepository.DeleteAsync(projectToDelete);

            return Unit.Value;
        }
    }
}