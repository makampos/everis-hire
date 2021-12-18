using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Interviews.Commands.UpdateInterview
{
    public class UpdateInterviewCommandHandler : IRequestHandler<UpdateInterview.UpdateInterviewCommand>
    {
        private readonly IInterviewRepository _interviewRepository;
        private readonly IMapper _mapper;

        public UpdateInterviewCommandHandler(IInterviewRepository interviewRepository, IMapper mapper)
        {
            _interviewRepository = interviewRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateInterviewCommand request, CancellationToken cancellationToken)
        {
            var interviewToUpdate = await _interviewRepository.GetByIdAsync(request.InterviewId);

            if (interviewToUpdate == null)
            {
                throw new NotFoundException(nameof(interviewToUpdate), request.InterviewId);
            }
            
            // validate does here
            // ..
            // ..
            // ..

            _mapper.Map(request, interviewToUpdate,
                typeof(UpdateInterview.UpdateInterviewCommand),
                typeof(Job));

            await _interviewRepository.UpdateAsync(interviewToUpdate);

            return Unit.Value;
        }
    }
}