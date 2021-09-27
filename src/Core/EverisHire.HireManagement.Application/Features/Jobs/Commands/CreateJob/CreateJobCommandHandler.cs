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
                EverJob = request.EverJob,
                LeaderCenters = request.LeaderCenters,
                LtfOrPl = request.LtfOrPl,
                ManagerSp = request.ManagerSp,
                Community = request.Community,
                Squad = request.Squad,
                ProjectId = request.ProjectId,
                AllocationType =  request.AllocationType, 
                OpeningDate = request.OpeningDate,
                Technology = request.Technology,
                YearsOfExperience = request.YearsOfExperience,
                DesiredDate = request.DesiredDate,
                MaximumSalary = request.MaximumSalary,
                Recruiter = request.Recruiter,
                Priority = request.Priority,
                PriorityDate = request.PriorityDate,
                Status = request.Status,
                Justification = request.Justification
            };

            job = await jobRepository.AddAsync(job);
            createJobCommandResponse.Job = mapper.Map<CreateJobDto>(job);

            return createJobCommandResponse;
        }
    }
}