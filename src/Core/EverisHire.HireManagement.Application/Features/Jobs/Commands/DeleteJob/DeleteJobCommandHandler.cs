using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Commands.DeleteJob
{
    public class DeleteJobCommandHandler : IRequestHandler<DeleteJobCommand>
    {
        private readonly IAsyncRepository<Job> _jobRepository;

        public DeleteJobCommandHandler(IAsyncRepository<Job> jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<Unit> Handle(
            DeleteJobCommand request,
            CancellationToken cancellationToken)
        {
            var jobToDelete = await _jobRepository.GetByIdAsync(request.JobId);
            await _jobRepository.DeleteAsync(jobToDelete);

            return Unit.Value;
        }
    }
}