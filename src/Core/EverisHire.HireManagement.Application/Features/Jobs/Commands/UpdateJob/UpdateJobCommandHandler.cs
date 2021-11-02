using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Commands.UpdateJob
{
    public class UpdateJobCommandHandler :
            IRequestHandler<UpdateJob.UpdateJobCommand>
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public UpdateJobCommandHandler(
            IJobRepository jobRepository,
            IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(
            UpdateJob.UpdateJobCommand request,
            CancellationToken cancellationToken)
        {
            var jobToUpdate = await _jobRepository.GetByIdAsync(request.JobId);

            if (jobToUpdate == null)
            {
                throw new NotFoundException(nameof(Job), request.JobId);
            }
            
            // validate does here
            // ..
            // ..
            // ..

            _mapper.Map(request, jobToUpdate,
                typeof(UpdateJob.UpdateJobCommand),
                typeof(Job));

            await _jobRepository.UpdateAsync(jobToUpdate);

            return Unit.Value;
        }
    }
    
    
}