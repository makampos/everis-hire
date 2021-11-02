using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Feature.Events;
using EverisHire.HireManagement.Application.Features.Candidates.Commands;
using EverisHire.HireManagement.Application.Features.Candidates.Commands.DeleteCandidate;
using EverisHire.HireManagement.Application.Features.Candidates.Commands.UpdateCandidate;
using EverisHire.HireManagement.Application.Features.Candidates.Queries;
using EverisHire.HireManagement.Application.Features.Categories.Commands;
using EverisHire.HireManagement.Application.Features.Categories.Queries.GetCategoriesList;
using EverisHire.HireManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using EverisHire.HireManagement.Application.Features.Communities.Queries;
using EverisHire.HireManagement.Application.Features.Events.Commands.CreateEvent;
using EverisHire.HireManagement.Application.Features.Events.Commands.UpdateEvent;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.UpdateJob;
using EverisHire.HireManagement.Application.Features.Jobs.Queries;
using EverisHire.HireManagement.Application.Features.LeadersCenters.Queries;
using EverisHire.HireManagement.Application.Features.Ltfs.Queries;
using EverisHire.HireManagement.Application.Features.ManagersSp.Queries;
using EverisHire.HireManagement.Application.Features.Priorities.Queries;
using EverisHire.HireManagement.Application.Features.Projects.Commands.CreateProject;
using EverisHire.HireManagement.Application.Features.Projects.Commands.UpdateProject;
using EverisHire.HireManagement.Application.Features.Projects.Queries;
using EverisHire.HireManagement.Application.Features.Projects.Queries.GetProjectDetail;
using EverisHire.HireManagement.Application.Features.Recruiters.Queries;
using EverisHire.HireManagement.Application.Features.Squads.Queries;
using EverisHire.HireManagement.Application.Features.StatusJobs.Queries;
using EverisHire.HireManagement.Application.Features.Technologies.Queries;
using EverisHire.HireManagement.Application.Features.YearsOfExperiences.Queries;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            //CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            //CreateMap<Order, OrdersForMonthDto>();


            CreateMap<Project, CreateProjectCommand>().ReverseMap();
            CreateMap<Project, UpdateProjectCommand>().ReverseMap();
            CreateMap<Project, ProjectListVm>();
            CreateMap<Project, CreateProjectDto>();
            CreateMap<Project, ProjectDetailVm>().ReverseMap();


            CreateMap<Candidate, CreateCandidateCommand>().ReverseMap();
            CreateMap<Candidate, CreateCandidateDto>();
            CreateMap<Candidate, UpdateCandidateCommand>().ReverseMap();
            CreateMap<Candidate, CandidateDetailVm>();
            //CreateMap<Candidate, DeleteCandidateCommand>();

            CreateMap<Job, CreateJobCommand>().ReverseMap();
            CreateMap<Job, UpdateJobCommand>().ReverseMap();
            CreateMap<Job, CreateJobDto>();
            CreateMap<Job, JobListVm>();
            CreateMap<Job, JobDetailVm>().ReverseMap();

            CreateMap<Recruiter, RecruiterListVm>();

            CreateMap<Technology, TechnologyListVm>();

            CreateMap<YearsOfExperience, YearsOfExperienceListVm>();

            CreateMap<StatusJob, StatusJobListVm>();

            CreateMap<Community, CommunityListVm>();
            
            CreateMap<Priority, PriorityListVm>();

           CreateMap<ManagerSp, ManagerSpListVm>();

           CreateMap<Ltf, LtfListVm>();

           CreateMap<Squad, SquadListVm>();

           CreateMap<LeaderCenters, LeaderCentersListVm>();
        }
        
    }
}