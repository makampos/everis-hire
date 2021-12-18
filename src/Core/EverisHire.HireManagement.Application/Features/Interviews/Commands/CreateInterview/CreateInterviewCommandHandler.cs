using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using MediatR;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Features.Interviews.Commands.CreateInterviewCommand
{
    public class CreateInterviewCommandHandler
        : IRequestHandler<CreateInterviewCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Interview> _interviewRepository;

        public CreateInterviewCommandHandler(IMapper mapper, IAsyncRepository<Interview> interviewRepository)
        {
            _mapper = mapper;
            _interviewRepository = interviewRepository;
        }

        public async Task<Guid> Handle(
            CreateInterviewCommand request,
            CancellationToken cancellationToken)
        {
            var createInterviewCommandResponse = new CreateInterviewCommandResponse();
            
            // validation goes here!

            var interview = _mapper.Map<Interview>(request);
            
            interview = await _interviewRepository.AddAsync(interview);
            createInterviewCommandResponse.Interview = _mapper.Map<CreateInterviewDto>(interview);
            
            return interview.InterviewId;
        }
    }
}