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
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<StatusCandidate> StatusCandidates { get; set; }
        public DbSet<AllocationType> AllocationTypes { get; set; }
        public DbSet<StatusInterview> InterviewStatus { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EverisHireDbContext).Assembly);

            //seed data, added through migrations

            // ===========================//
            
            /*Project*/
            var projectGuid = Guid.Parse("{91BB85AC-8E13-4B9F-BBCB-A21B1F1A3C9A}");
            var projectSantanderGuid = Guid.Parse("{c132b5dd-479a-4c57-8969-0fd5f62d7def}");
            var projectItauGuid = Guid.Parse("{dce7d803-a44f-4a92-b52d-aa2006376bc6}");
            var projectHsbcGuid = Guid.Parse("{d6f0b8bd-2c2c-4d44-ae92-b6a29c7c73e9}");
            var projectAmericaGuid = Guid.Parse("{4a92afdf-bff6-454d-bff5-45e5b1fd2edb}");
            var projectCaixaGuid = Guid.Parse("{5ceaa5ef-a0a1-495f-8b69-178ce284d018}");
            var projectInterGuid = Guid.Parse("{4f8d68ea-78a2-4449-be9c-6b474f4f2ffd}");


            var priorityGuid = Guid.Parse("{192a00ec-a662-4a6f-9376-cf59c241698e}");
            var squadGuid = Guid.Parse("{b38454c2-9d8b-48fe-8e0d-e5f3bf3f80b7}");
            
            /*Tecnology*/
            var technologyGuid = Guid.Parse("{1080b4e8-6c88-4937-b041-01158f7649a2}");
            var reactGuid = Guid.Parse("{fc69eabf-ead5-4a93-8a17-c76882913453}");
            var flutterGuid = Guid.Parse("{b6dc1e53-9b22-4884-aba2-c5b66e17df48}");
            var VueJsGuid = Guid.Parse("{889c8a85-567b-476c-be06-00a018b5254a}");


            var yearsOfExperienceGuid = Guid.Parse("{03cef292-b366-4ec0-b1ec-e02e54380ef6}");
            
            // ===========================//


            modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectGuid,
               Name = "Banco Ita??",
               Description = "Sem descri????o"
            });          
            
             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectSantanderGuid,
               Name = "Santander",
               Description = "Sem descri????o"
            });
            
            
             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectItauGuid,
               Name = "Ita??",
               Description = "Sem descri????o"
            });
            
             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectHsbcGuid,
               Name = "Hsbc",
               Description = "Sem descri????o"
            });
            
             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectAmericaGuid,
               Name = "Am??rica",
               Description = "Sem descri????o"
            });
            
             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectCaixaGuid,
               Name = "Caixa",
               Description = "Sem descri????o"
            });
            
             modelBuilder.Entity<Project>().HasData(new Project 
            {
               ProjectId = projectInterGuid,
               Name = "Inter",
               Description = "Sem descri????o"
            });
            
            
            modelBuilder.Entity<Community>().HasData(new Community {
                CommunityId = Guid.NewGuid(),
                Name = "Rede de Ag??ncias",
                Description = "Comunidade respons??vel por desenvolver software para ag??ncias de bancos. "
            });
            
            modelBuilder.Entity<Community>().HasData(new Community {
                CommunityId = Guid.NewGuid(),
                Name = "Seguimento Jur??dico",
                Description = "Comunidade respons??vel por desenvolver software para o judici??rio "
            });
            
            modelBuilder.Entity<Priority>().HasData(new Priority {
                PriorityId = priorityGuid,
                Code = 10,
                Description = "Prioridade m??xima para o n??vel de contrata????o",
            });
            
            modelBuilder.Entity<Priority>().HasData(new Priority {
                PriorityId = Guid.NewGuid(),
                Code = 1,
                Description = "Prioridade inicial para o n??vel de contrata????o",
            });
            
            modelBuilder.Entity<Priority>().HasData(new Priority {
                PriorityId = Guid.NewGuid(),
                Code = 5,
                Description = "Prioridade m??dia para o n??vel de contrata????o",
            });
            
            modelBuilder.Entity<Recruiter>().HasData(new Recruiter {
                RecruiterId = Guid.NewGuid(),
                Name = "Amanda Nobrega",
            });
            
            modelBuilder.Entity<Recruiter>().HasData(new Recruiter {
                RecruiterId = Guid.NewGuid(),
                Name = "Benedito Cl??udio Bernardes",
            });
            
            modelBuilder.Entity<Recruiter>().HasData(new Recruiter {
                RecruiterId = Guid.NewGuid(),
                Name = "Mariana Eliane Patr??cia Assis",
            });
            
            modelBuilder.Entity<Recruiter>().HasData(new Recruiter {
                RecruiterId = Guid.NewGuid(),
                Name = "Gustavo Nicolas Leandro da Silva",
            });
            
            modelBuilder.Entity<Squad>().HasData(new Squad 
            {
                SquadId = Guid.NewGuid(),
                Name = "Automa????o",
                Description = "Automa????o de processos"
            });
            
            modelBuilder.Entity<Squad>().HasData(new Squad 
            {
                SquadId = Guid.NewGuid(),
                Name = "Extens??o",
                Description = "Extens??o da squad no cliente"
            });
            
            modelBuilder.Entity<Squad>().HasData(new Squad 
            {
                SquadId = Guid.NewGuid(),
                Name = "Solu????es customizadas",
                Description = "Squad que atua o desenvolvimento de novas solu????es"
            });
            
            modelBuilder.Entity<StatusJob>().HasData(new StatusJob 
            {
                StatusJobId = Guid.NewGuid(),
                Description = "Aberto" 
            });
            
            modelBuilder.Entity<StatusJob>().HasData(new StatusJob 
            {
                StatusJobId = Guid.NewGuid(),
                Description = "Fechado" 
            });
            
            modelBuilder.Entity<Technology>().HasData(new Technology 
            {
                TechnologyId = technologyGuid,
                Name = "AngularJS",
                Description = "Framework para desenvolvimento de Single Page Applications",
                Type = "Frontend"
            });
            
            modelBuilder.Entity<Technology>().HasData(new Technology 
            {
                TechnologyId = reactGuid,
                Name = "ReactJS",
                Description = "Framework para desenvolvimento de Single Page Applications",
                Type = "Frontend"
            });
            
             modelBuilder.Entity<Technology>().HasData(new Technology 
             {
                TechnologyId = flutterGuid,
                Name = "Flutter",
                Description = "Framework para desenvolvimento de Single Page Applications e Mobile",
                Type = "Frontend"
            });
            
            
             modelBuilder.Entity<Technology>().HasData(new Technology 
             {
                TechnologyId = VueJsGuid,
                Name = "VueJS",
                Description = "Framework para desenvolvimento de Single Page Applications",
                Type = "Frontend"
            });
             
            modelBuilder.Entity<ManagerSp>().HasData(new ManagerSp 
            {
                ManagerSpId = Guid.NewGuid(),
                Name =  "Luiz Cl??udio Emanuel Barros"
            });
            
            modelBuilder.Entity<ManagerSp>().HasData(new ManagerSp 
            {
                ManagerSpId = Guid.NewGuid(),
                Name =  "Bruno Tom??s Fernandes"
            });
            
            modelBuilder.Entity<ManagerSp>().HasData(new ManagerSp 
            {
                ManagerSpId = Guid.NewGuid(),
                Name =  "Rafael Benjamin Marcos Vinicius da Paz"
            });
            
            modelBuilder.Entity<ManagerSp>().HasData(new ManagerSp 
            {
                ManagerSpId = Guid.NewGuid(),
                Name =  "Henry Renato Mendes"
            });
            
            modelBuilder.Entity<Ltf>().HasData(new Ltf 
            {
                LtfId = Guid.NewGuid(),
                Name = "Julia Rebeca Alana da Rosa"
            });
            
            modelBuilder.Entity<Ltf>().HasData(new Ltf 
            {
                LtfId = Guid.NewGuid(),
                Name = "Filipe Raul Oliver Sales"
            });
            
            modelBuilder.Entity<Ltf>().HasData(new Ltf 
            {
                LtfId = Guid.NewGuid(),
                Name = "Anderson Oliveira Barbosa"
            });
            
            modelBuilder.Entity<LeaderCenters>().HasData(new LeaderCenters 
            {
                LeaderCentersId = Guid.NewGuid(),
                Name = "Mirella Malu Vit??ria Pereira"
            });
            
            modelBuilder.Entity<LeaderCenters>().HasData(new LeaderCenters 
            {
                LeaderCentersId = Guid.NewGuid(),
                Name = "Lucca Felipe Renato Ara??jo"
            });
            
            modelBuilder.Entity<LeaderCenters>().HasData(new LeaderCenters 
            {
                LeaderCentersId = Guid.NewGuid(),
                Name = "Alexandre Heitor Pedro Henrique Ferreira"
            });
            
            modelBuilder.Entity<LeaderCenters>().HasData(new LeaderCenters 
            {
                LeaderCentersId = Guid.NewGuid(),
                Name = "Ros??ngela Andreia Manuela Nogueira"
            });
            
            modelBuilder.Entity<StatusCandidate>().HasData(new StatusCandidate
            {
                StatusCandidateId = Guid.NewGuid(),
                Description = "Contratado"
            });
            
            modelBuilder.Entity<StatusCandidate>().HasData(new StatusCandidate
            {
                StatusCandidateId = Guid.NewGuid(),
                Description = "Reprovado"
            });
            
            modelBuilder.Entity<StatusCandidate>().HasData(new StatusCandidate
            {
                StatusCandidateId = Guid.NewGuid(),
                Description = "Dispon??vel"
            });
            
            modelBuilder.Entity<StatusCandidate>().HasData(new StatusCandidate
            {
                StatusCandidateId = Guid.NewGuid(),
                Description = "Indispon??vel"
            });
            
            modelBuilder.Entity<AllocationType>().HasData(new AllocationType
            {
                AllocationTypeId = Guid.NewGuid(),
                Description = "Presencial"
            });
            
            modelBuilder.Entity<AllocationType>().HasData(new AllocationType
            {
                AllocationTypeId = Guid.NewGuid(),
                Description = "Teletrabalho"
            });
            
            modelBuilder.Entity<StatusInterview>().HasData(new StatusInterview
            {
                StatusInterviewId = Guid.NewGuid(),
                Description = "Aberto"
            });
            
            modelBuilder.Entity<StatusInterview>().HasData(new StatusInterview
            {
                StatusInterviewId = Guid.NewGuid(),
                Description = "Fechado"
            });
            
            modelBuilder.Entity<StatusInterview>().HasData(new StatusInterview
            {
                StatusInterviewId = Guid.NewGuid(),
                Description = "Contratado"
            });
            
            modelBuilder.Entity<StatusInterview>().HasData(new StatusInterview
            {
                StatusInterviewId = Guid.NewGuid(),
                Description = "Reprovado"
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