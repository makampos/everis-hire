using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob
{
    public class CreateJobCommandHandler
        : IRequestHandler<CreateJobCommand, CreateJobCommandResponse>
    {
        private readonly IMapper mapper;
        private readonly IJobRepository jobRepository;
        public CreateJobCommandHandler(IMapper mapper, IJobRepository jobRepository)
        {
            this.mapper = mapper;
            this.jobRepository = jobRepository;
        }
        public async Task<CreateJobCommandResponse> Handle(
            CreateJobCommand request,
            CancellationToken cancellationToken)
        {
            var createJobCommandResponse = new CreateJobCommandResponse();
            
            // validations goes here!

            // ======================

            var job = new Job() 
            {
                JobType = request.JobType,
                EverJob = request.EverJob,
                Manager = request.Manager,
                Ltf = request.Ltf,
                ManagerSp = request.ManagerSp,
                Community = request.Community,
                AllocationType = request.AllocationType,
                ClosedDate = request.ClosedDate,
                Technology =  request.Technology, 
                YearsOfExperience = request.YearsOfExperience,
                MaximumSalary = request.MaximumSalary,
                Priority = request.Priority,
                PriorityDate = request.PriorityDate,
                Status = request.Status,
                Justification = request.Justification,
                ProjectId = request.ProjectId
            };

            job = await jobRepository.AddAsync(job);
            createJobCommandResponse.Job = mapper.Map<CreateJobDto>(job);

            return createJobCommandResponse;
        }
    }
}