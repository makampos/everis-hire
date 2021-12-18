using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Feature.Events;
using EverisHire.HireManagement.Application.Features.AllocationTypes.Queries;
using EverisHire.HireManagement.Application.Features.Candidates.Commands;
using EverisHire.HireManagement.Application.Features.Candidates.Commands.DeleteCandidate;
using EverisHire.HireManagement.Application.Features.Candidates.Commands.UpdateCandidate;
using EverisHire.HireManagement.Application.Features.Candidates.Queries;
using EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateInterviewDetail;
using EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery;
using EverisHire.HireManagement.Application.Features.Categories.Commands;
using EverisHire.HireManagement.Application.Features.Categories.Queries.GetCategoriesList;
using EverisHire.HireManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using EverisHire.HireManagement.Application.Features.Communities.Queries;
using EverisHire.HireManagement.Application.Features.Events.Commands.CreateEvent;
using EverisHire.HireManagement.Application.Features.Events.Commands.UpdateEvent;
using EverisHire.HireManagement.Application.Features.Interviews.Commands.CreateInterviewCommand;
using EverisHire.HireManagement.Application.Features.Interviews.Commands.UpdateInterview;
using EverisHire.HireManagement.Application.Features.Interviews.Queries;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.UpdateJob;
using EverisHire.HireManagement.Application.Features.Jobs.Queries;
using EverisHire.HireManagement.Application.Features.Jobs.Queries.GetJobInterviewDetail;
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
using EverisHire.HireManagement.Application.Features.StatusCandidates.Queries;
using EverisHire.HireManagement.Application.Features.StatusInterviews.Queries;
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
            CreateMap<Candidate, CandidateListVm>()
                .ForMember(dest => dest.StatusDescription,
                    opt => opt.MapFrom(src => src.StatusCandidate.Description))
                .ForMember(dest => dest.AllocationTypeDescription,
                    opt => opt.MapFrom(src => src.AllocationType.Description));

            CreateMap<Candidate, CandidateInterviewDetailVm>()
                .ForMember(dest => dest.CandidateName,
                    opt => 
                        opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.RecruiterName, opt => opt.MapFrom(
                    src => src.Recruiter))
                .ForMember(dest => dest.StatusDescription,
                    src => src.MapFrom(
                        opt => opt.StatusCandidate.Description)).ReverseMap();

            //CreateMap<Candidate, DeleteCandidateCommand>();

            CreateMap<Job, CreateJobCommand>().ReverseMap();
            CreateMap<Job, UpdateJobCommand>().ReverseMap();
            CreateMap<Job, CreateJobDto>();
            CreateMap<Job, JobListVm>()
                .ForMember(dest => dest.ProjectDescription,
                    opt => 
                        opt.MapFrom(src => src.Project.Name))
                .ForMember(dest => dest.StatusDescription,
                    opt => 
                        opt.MapFrom(src => src.StatusJob.Description))
                .ForMember(dest => dest.AllocationTypeDescription,
                    opt => 
                        opt.MapFrom(src => src.AllocationType.Description));
            
            CreateMap<Job, JobDetailVm>().ReverseMap();
            
            CreateMap<Job, JobInterviewDetailVm>()
                .ForMember(dest => dest.JobYearsOfExperience,
                    opt =>
                        opt.MapFrom(src => src.YearsOfExperience))
                .ForMember(dest => dest.JobRecruiterName,
                    opt =>
                        opt.MapFrom(src => src.Recruiter)).ReverseMap();

            CreateMap<Job, JobOpenListVm>().ReverseMap();
            
            CreateMap<Interview,UpdateInterviewCommand>()
                 .ForMember(dest => dest.CandidateName,
                    opt => opt.MapFrom(src => src.CandidateName))
                .ForMember(dest => dest.EverJob,
                    opt => opt.MapFrom(src => src.EverJob))
                .ForMember(dest => dest.AllocationTypeDescription,
                    opt => opt.MapFrom(src => src.AllocationType))
                .ForMember(dest => dest.City,
                    opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.RecruiterName,
                    opt => opt.MapFrom(src => src.CandidateRecruiterName))
                .ForMember(dest => dest.Technology,
                    opt => opt.MapFrom(src => src.CandidateTechnology))
                .ForMember(dest => dest.YearsOfExperience,
                    opt => opt.MapFrom(src => src.CandidateYearsOfExperience))
                .ForMember(dest => dest.CandidateCreatedDate,
                    opt => opt.MapFrom(src => src.CandidateCreatedDate))
                .ForMember(dest => dest.StatusDescription,
                    opt => opt.MapFrom(src => src.CandidateStatus))
                .ForMember(dest => dest.SalaryClaim,
                    opt => opt.MapFrom(src => src.SalaryClaim))
                .ForMember(dest => dest.LeaderCenters,
                    opt => opt.MapFrom(src => src.LeaderCenters))
                .ForMember(dest => dest.LtfOrPl,
                    opt => opt.MapFrom(src => src.LeaderCenters))
                .ForMember(dest => dest.ManagerSp,
                    opt => opt.MapFrom(src => src.ManagerSp))
                .ForMember(dest => dest.Community,
                    opt => opt.MapFrom(src => src.Community))
                .ForMember(dest => dest.JobRecruiterName,
                    opt => opt.MapFrom(src => src.JobRecruiterName))
                .ForMember(dest => dest.JobTechnology,
                    opt => opt.MapFrom(src => src.JobTechnology))
                .ForMember(dest => dest.JobYearsOfExperience,
                    opt => opt.MapFrom(src => src.JobYearsOfExperience))
                .ForMember(dest => dest.MaximumSalary,
                    opt => opt.MapFrom(src => src.MaximumSalary))
                .ForMember(dest => dest.StatusInterviewId,
                    opt => opt.MapFrom(src => src.StatusInterviewId))
                .ForMember(dest => dest.JobId,
                    opt => opt.MapFrom(src => src.JobId))
                .ForMember(dest => dest.CandidateId,
                    opt => opt.MapFrom(src => src.CandidateId))
                .ForMember(dest => dest.ProjectId,
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(dest => dest.InterviewerLeaderCenters,
                    opt => opt.MapFrom(src => src.InterViewLeaderCenters))
                .ReverseMap()
                .ForPath(x => x.Candidate, opt => opt.Ignore())
                .ForPath(x => x.Job, opt => opt.Ignore())
                .ForPath(x => x.StatusInterview, opt => opt.Ignore());
            
            CreateMap<Interview, CreateInterviewCommand>()
                .ForMember(dest => dest.CandidateName,
                    opt => opt.MapFrom(src => src.CandidateName))
                .ForMember(dest => dest.EverJob,
                    opt => opt.MapFrom(src => src.EverJob))
                .ForMember(dest => dest.AllocationTypeDescription,
                    opt => opt.MapFrom(src => src.AllocationType))
                .ForMember(dest => dest.City,
                    opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.RecruiterName,
                    opt => opt.MapFrom(src => src.CandidateRecruiterName))
                .ForMember(dest => dest.Technology,
                    opt => opt.MapFrom(src => src.CandidateTechnology))
                .ForMember(dest => dest.YearsOfExperience,
                    opt => opt.MapFrom(src => src.CandidateYearsOfExperience))
                .ForMember(dest => dest.CandidateCreatedDate,
                    opt => opt.MapFrom(src => src.CandidateCreatedDate))
                .ForMember(dest => dest.StatusDescription,
                    opt => opt.MapFrom(src => src.CandidateStatus))
                .ForMember(dest => dest.SalaryClaim,
                    opt => opt.MapFrom(src => src.SalaryClaim))
                .ForMember(dest => dest.LeaderCenters,
                    opt => opt.MapFrom(src => src.LeaderCenters))
                .ForMember(dest => dest.LtfOrPl,
                    opt => opt.MapFrom(src => src.LeaderCenters))
                .ForMember(dest => dest.ManagerSp,
                    opt => opt.MapFrom(src => src.ManagerSp))
                .ForMember(dest => dest.Community,
                    opt => opt.MapFrom(src => src.Community))
                .ForMember(dest => dest.JobRecruiterName,
                    opt => opt.MapFrom(src => src.JobRecruiterName))
                .ForMember(dest => dest.JobTechnology,
                    opt => opt.MapFrom(src => src.JobTechnology))
                .ForMember(dest => dest.JobYearsOfExperience,
                    opt => opt.MapFrom(src => src.JobYearsOfExperience))
                .ForMember(dest => dest.MaximumSalary,
                    opt => opt.MapFrom(src => src.MaximumSalary))
                .ForMember(dest => dest.StatusInterviewId,
                    opt => opt.MapFrom(src => src.StatusInterviewId))
                .ForMember(dest => dest.JobId,
                    opt => opt.MapFrom(src => src.JobId))
                .ForMember(dest => dest.CandidateId,
                    opt => opt.MapFrom(src => src.CandidateId))
                .ForMember(dest => dest.ProjectId,
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(dest => dest.InterviewerLeaderCenters,
                    opt => opt.MapFrom(src => src.InterViewLeaderCenters))
                .ReverseMap()
                .ForPath(x => x.Candidate, opt => opt.Ignore())
                .ForPath(x => x.Job, opt => opt.Ignore())
                .ForPath(x => x.StatusInterview, opt => opt.Ignore());
            
                
                
            CreateMap<Interview, CreateInterviewDto>();
            CreateMap<Interview, InterviewListVm>()
                .ForMember(dest => dest.CandidateName,
                    opt => opt.MapFrom(src => src.CandidateName))
                .ForMember(dest => dest.EverJob,
                    opt => opt.MapFrom(src => src.EverJob))
                .ForMember(dest => dest.AllocationTypeDescription,
                    opt => opt.MapFrom(src => src.AllocationType))
                .ForMember(dest => dest.City,
                    opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.RecruiterName,
                    opt => opt.MapFrom(src => src.CandidateRecruiterName))
                .ForMember(dest => dest.Technology,
                    opt => opt.MapFrom(src => src.CandidateTechnology))
                .ForMember(dest => dest.YearsOfExperience,
                    opt => opt.MapFrom(src => src.CandidateYearsOfExperience))
                .ForMember(dest => dest.CandidateCreatedDate,
                    opt => opt.MapFrom(src => src.CandidateCreatedDate))
                .ForMember(dest => dest.StatusDescription,
                    opt => opt.MapFrom(src => src.CandidateStatus))
                .ForMember(dest => dest.SalaryClaim,
                    opt => opt.MapFrom(src => src.SalaryClaim))
                .ForMember(dest => dest.LeaderCenters,
                    opt => opt.MapFrom(src => src.LeaderCenters))
                .ForMember(dest => dest.LtfOrPl,
                    opt => opt.MapFrom(src => src.LeaderCenters))
                .ForMember(dest => dest.ManagerSp,
                    opt => opt.MapFrom(src => src.ManagerSp))
                .ForMember(dest => dest.Community,
                    opt => opt.MapFrom(src => src.Community))
                .ForMember(dest => dest.JobRecruiterName,
                    opt => opt.MapFrom(src => src.JobRecruiterName))
                .ForMember(dest => dest.JobTechnology,
                    opt => opt.MapFrom(src => src.JobTechnology))
                .ForMember(dest => dest.JobYearsOfExperience,
                    opt => opt.MapFrom(src => src.JobYearsOfExperience))
                .ForMember(dest => dest.MaximumSalary,
                    opt => opt.MapFrom(src => src.MaximumSalary))
                .ForMember(dest => dest.StatusInterviewId,
                    opt => opt.MapFrom(src => src.StatusInterviewId))
                .ForMember(dest => dest.JobId,
                    opt => opt.MapFrom(src => src.JobId))
                .ForMember(dest => dest.CandidateId,
                    opt => opt.MapFrom(src => src.CandidateId))
                .ForMember(dest => dest.ProjectId,
                    opt => opt.MapFrom(src => src.ProjectId))
                .ForMember(dest => dest.InterviewerLeaderCenters,
                    opt => opt.MapFrom(src => src.InterViewLeaderCenters))
                .ReverseMap()
                .ForPath(x => x.Candidate, opt => opt.Ignore())
                .ForPath(x => x.Job, opt => opt.Ignore())
                .ForPath(x => x.StatusInterview, opt => opt.Ignore());
            CreateMap<StatusInterview, StatusInterviewListVm>().ReverseMap();

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

           CreateMap<StatusCandidate, StatusCandidateListVm>();
           CreateMap<AllocationType, AllocationTypeListVm>();
        }
        
    }
}