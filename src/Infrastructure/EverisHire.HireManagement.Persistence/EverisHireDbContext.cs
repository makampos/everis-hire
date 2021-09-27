using System;
using System.Threading;
using System.Threading.Tasks;
using EverisHire.HireManagement.Domain.Common;
using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EverisHire.HireManagement.Persistence
{
    public class EverisHireDbContext : DbContext
    {
        public EverisHireDbContext(DbContextOptions<EverisHireDbContext> options)
            : base(options)
        {            
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Community> Communities { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<Squad> Squads { get; set; }
        public DbSet<StatusJob> StatusJobs { get; set; }
        public DbSet<Technology> Techonologies { get; set; }
        public DbSet<YearsOfExperience> YearsOfExperience { get; set; }

        public DbSet<ManagerSp> ManagerSp { get; set; }
        public DbSet<Ltf> Ltf { get; set; }
        
        public DbSet<LeaderCenters> LeaderCenters { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EverisHireDbContext).Assembly);

            //seed data, added through migrations

            // ===========================//

            var jobGuid = Guid.Parse("{4BACB9DB-5CDC-408A-8A8B-BD2E3727BA05}");
            var candidateGuid = Guid.Parse("{B715995B-AB01-4B6B-991E-F1B2DF79D87D}");

            /*Project*/
            var projectGuid = Guid.Parse("{91BB85AC-8E13-4B9F-BBCB-A21B1F1A3C9A}");
            var projectSantanderGuid = Guid.Parse("{c132b5dd-479a-4c57-8969-0fd5f62d7def}");
            var projectItauGuid = Guid.Parse("{dce7d803-a44f-4a92-b52d-aa2006376bc6}");
            var projectHsbcGuid = Guid.Parse("{d6f0b8bd-2c2c-4d44-ae92-b6a29c7c73e9}");
            var projectAmericaGuid = Guid.Parse("{4a92afdf-bff6-454d-bff5-45e5b1fd2edb}");
            var projectCaixaGuid = Guid.Parse("{5ceaa5ef-a0a1-495f-8b69-178ce284d018}");
            var projectInterGuid = Guid.Parse("{4f8d68ea-78a2-4449-be9c-6b474f4f2ffd}");


            var communityGuid = Guid.Parse("{556e39aa-1ee6-4447-9579-ec561c45eb3e}");
            var priorityGuid = Guid.Parse("{192a00ec-a662-4a6f-9376-cf59c241698e}");
            var recruiterGuid = Guid.Parse("{1fb97415-ceaf-4a99-ac53-0476620c0d61}");
            var squadGuid = Guid.Parse("{b38454c2-9d8b-48fe-8e0d-e5f3bf3f80b7}");
            var statusJobGuid = Guid.Parse("{75410d2f-8784-401d-97f8-a4d00b8c0309}");

            /*Tecnology*/
            var technologyGuid = Guid.Parse("{1080b4e8-6c88-4937-b041-01158f7649a2}");
            var reactGuid = Guid.Parse("{fc69eabf-ead5-4a93-8a17-c76882913453}");
            var flutterGuid = Guid.Parse("{b6dc1e53-9b22-4884-aba2-c5b66e17df48}");
            var VueJsGuid = Guid.Parse("{889c8a85-567b-476c-be06-00a018b5254a}");


            var yearsOfExperienceGuid = Guid.Parse("{03cef292-b366-4ec0-b1ec-e02e54380ef6}");
            var managerSpGuid = Guid.Parse("{2bed1707-291b-491e-b01a-87827d7b8351}");
            var ltfGuid = Guid.Parse("{af9d512a-26ed-492c-ba66-79c73badd20d}");
            var leaderCentersGuid = Guid.Parse("{95c9689d-4a0d-4c34-b1fc-77d1581a30f8}");
            



            // ===========================//

            modelBuilder.Entity<Job>().HasData(new Job 
            {
                JobId = jobGuid,
                EverJob = 176498,
                LeaderCenters = "Roosevelt Gaipó",
                LtfOrPl = "Adilson Hemmel Dias",                               
                ManagerSp = "Renato Oliveira",
                Community = "Inovação",                
                Squad = "Automação sustentável",
                ProjectId = projectGuid,   
                AllocationType = "Remoto",
                OpeningDate =  DateTime.ParseExact("06-05-2021","MM-dd-yyyy",null),
                Technology = ".NET CORE",
                YearsOfExperience = yearsOfExperienceGuid,
                DesiredDate = DateTime.ParseExact("07-09-2022","MM-dd-yyyy",null),
                MaximumSalary = 15000,
                Recruiter = "Amanda Silva",
                Priority = 10,        
                PriorityDate = DateTime.ParseExact("06-05-2021","MM-dd-yyyy",null),
                Status = "Aberto",
                Justification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec enim condimentum.",
                             
            });
         
            // modelBuilder.Entity<Candidate>().HasData(new Candidate 
            // {
            //     CandidateId = candidateGuid,
            //     Name = "Matheus",
            //     Status ="Disponível",
            //     AlocationType = "Remoto",
            //     YearsOfExperience = 3,
            //     WhoIndicated = null,
            //     SalaryClaim = 7000,
            //     JobId = jobGuid
            // });

            modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectGuid,
               Name = "Banco Itaú",
               Description = "Sem descrição"
            });          

             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectSantanderGuid,
               Name = "Santander",
               Description = "Sem descrição"
            });


             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectItauGuid,
               Name = "Itaú",
               Description = "Sem descrição"
            });

             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectHsbcGuid,
               Name = "Hsbc",
               Description = "Sem descrição"
            });

             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectAmericaGuid,
               Name = "América",
               Description = "Sem descrição"
            });

             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectCaixaGuid,
               Name = "Caixa",
               Description = "Sem descrição"
            });

             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectInterGuid,
               Name = "Inter",
               Description = "Sem descrição"
            });


            modelBuilder.Entity<Community>().HasData(new Community {
                CommunityId = communityGuid,
                Name = "Rede de Agências",
                Description = "Comunidade responsável por desenvolver software para agências de bancos. "
            });

            modelBuilder.Entity<Priority>().HasData(new Priority {
                PriorityId = priorityGuid,
                Code = 10,
                Description = "Prioridade máxima para o nível de contratação",
            });

            modelBuilder.Entity<Recruiter>().HasData(new Recruiter {
                RecruiterId = recruiterGuid,
                Name = "Amanda Nobrega",
            });

            modelBuilder.Entity<Squad>().HasData(new Squad {
                SquadId = squadGuid,
                Name = "Squad de automação",
                Description = "Squad de colaboradores que atuam por teletrabalho"
            });

            modelBuilder.Entity<StatusJob>().HasData(new StatusJob {
                StatusJobId = statusJobGuid,
                Code = 1,
                Description = "Aberta" 
            });

            modelBuilder.Entity<Technology>().HasData(new Technology {
                TechnologyId = technologyGuid,
                Name = "AngularJS",
                Description = "Framework para desenvolvimento de Single Page Applications",
                Type = "Frontend"
            });

            modelBuilder.Entity<Technology>().HasData(new Technology {
                TechnologyId = reactGuid,
                Name = "ReactJS",
                Description = "Framework para desenvolvimento de Single Page Applications",
                Type = "Frontend"
            });

             modelBuilder.Entity<Technology>().HasData(new Technology {
                TechnologyId = flutterGuid,
                Name = "Flutter",
                Description = "Framework para desenvolvimento de Single Page Applications e Mobile",
                Type = "Frontend"
            });


             modelBuilder.Entity<Technology>().HasData(new Technology {
                TechnologyId = VueJsGuid,
                Name = "VueJS",
                Description = "Framework para desenvolvimento de Single Page Applications",
                Type = "Frontend"
            });

            modelBuilder.Entity<YearsOfExperience>().HasData(new YearsOfExperience {
                YearsOfExperienceId = yearsOfExperienceGuid,
                ViewValue = "1 - 2"
            });

            modelBuilder.Entity<ManagerSp>().HasData(new ManagerSp {
                ManagerSpId = managerSpGuid,
                Name =  "Daiane Viana dos Santos"
            });

            modelBuilder.Entity<Ltf>().HasData(new Ltf {
                LtfId = ltfGuid,
                Name = "Anderson Oliveira Barbosa"
            });
            
            modelBuilder.Entity<LeaderCenters>().HasData(new LeaderCenters {
                LeaderCentersId = leaderCentersGuid,
                Name = "Roosevelt Gaipo"
            });

             // ===========================//
        }

        public override Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = new CancellationToken()) 
            {
                foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
                {
                    switch(entry.State)
                    {
                        case EntityState.Added:
                             entry.Entity.CreatedDate = DateTime.Now;
                             break;
                        case EntityState.Modified:
                             entry.Entity.LastModifiedDate = DateTime.Now;
                             break;
                    }
                }
                return base.SaveChangesAsync(cancellationToken);
            }
    }
}