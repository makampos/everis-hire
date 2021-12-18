using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EverisHire.HireManagement.Persistence.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllocationTypes",
                columns: table => new
                {
                    AllocationTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllocationTypes", x => x.AllocationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    CommunityId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.CommunityId);
                });

            migrationBuilder.CreateTable(
                name: "InterviewStatus",
                columns: table => new
                {
                    StatusInterviewId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewStatus", x => x.StatusInterviewId);
                });

            migrationBuilder.CreateTable(
                name: "LeaderCenters",
                columns: table => new
                {
                    LeaderCentersId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaderCenters", x => x.LeaderCentersId);
                });

            migrationBuilder.CreateTable(
                name: "Ltf",
                columns: table => new
                {
                    LtfId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ltf", x => x.LtfId);
                });

            migrationBuilder.CreateTable(
                name: "ManagerSp",
                columns: table => new
                {
                    ManagerSpId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerSp", x => x.ManagerSpId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    OrderTotal = table.Column<int>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false),
                    OrderPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    PriorityId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Code = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.PriorityId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Recruiters",
                columns: table => new
                {
                    RecruiterId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiters", x => x.RecruiterId);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    SquadId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.SquadId);
                });

            migrationBuilder.CreateTable(
                name: "StatusCandidates",
                columns: table => new
                {
                    StatusCandidateId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCandidates", x => x.StatusCandidateId);
                });

            migrationBuilder.CreateTable(
                name: "StatusJobs",
                columns: table => new
                {
                    StatusJobId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusJobs", x => x.StatusJobId);
                });

            migrationBuilder.CreateTable(
                name: "Techonologies",
                columns: table => new
                {
                    TechnologyId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Techonologies", x => x.TechnologyId);
                });

            migrationBuilder.CreateTable(
                name: "YearsOfExperience",
                columns: table => new
                {
                    YearsOfExperienceId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    ViewValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearsOfExperience", x => x.YearsOfExperienceId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    CandidateId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    YearsOfExperience = table.Column<int>(nullable: false),
                    WhoIndicated = table.Column<string>(nullable: true),
                    SalaryClaim = table.Column<decimal>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Technology = table.Column<string>(nullable: true),
                    LeaderCenters = table.Column<string>(nullable: true),
                    Recruiter = table.Column<string>(nullable: true),
                    Resume = table.Column<string>(nullable: true),
                    StatusCandidateId = table.Column<Guid>(maxLength: 50, nullable: false),
                    AllocationTypeId = table.Column<Guid>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.CandidateId);
                    table.ForeignKey(
                        name: "FK_Candidates_AllocationTypes_AllocationTypeId",
                        column: x => x.AllocationTypeId,
                        principalTable: "AllocationTypes",
                        principalColumn: "AllocationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidates_StatusCandidates_StatusCandidateId",
                        column: x => x.StatusCandidateId,
                        principalTable: "StatusCandidates",
                        principalColumn: "StatusCandidateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false),
                    AllocationTypeId = table.Column<Guid>(nullable: false),
                    EverJob = table.Column<int>(nullable: false),
                    LeaderCenters = table.Column<string>(nullable: true),
                    LtfOrPl = table.Column<string>(nullable: true),
                    ManagerSp = table.Column<string>(maxLength: 50, nullable: false),
                    Community = table.Column<string>(nullable: true),
                    Squad = table.Column<string>(nullable: true),
                    OpeningDate = table.Column<DateTime>(nullable: true),
                    Technology = table.Column<string>(maxLength: 30, nullable: true),
                    YearsOfExperience = table.Column<int>(nullable: false),
                    DesiredDate = table.Column<DateTime>(nullable: true),
                    MaximumSalary = table.Column<decimal>(nullable: false),
                    Recruiter = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    PriorityDate = table.Column<DateTime>(nullable: true),
                    StatusJobId = table.Column<Guid>(maxLength: 50, nullable: false),
                    Justification = table.Column<string>(maxLength: 1000, nullable: true),
                    AllocationTypeId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Jobs_AllocationTypes_AllocationTypeId",
                        column: x => x.AllocationTypeId,
                        principalTable: "AllocationTypes",
                        principalColumn: "AllocationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_AllocationTypes_AllocationTypeId1",
                        column: x => x.AllocationTypeId1,
                        principalTable: "AllocationTypes",
                        principalColumn: "AllocationTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jobs_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jobs_StatusJobs_StatusJobId",
                        column: x => x.StatusJobId,
                        principalTable: "StatusJobs",
                        principalColumn: "StatusJobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    InterviewId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    CandidateName = table.Column<string>(nullable: true),
                    EverJob = table.Column<int>(nullable: false),
                    AllocationType = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CandidateRecruiterName = table.Column<string>(nullable: true),
                    CandidateTechnology = table.Column<string>(nullable: true),
                    CandidateYearsOfExperience = table.Column<int>(nullable: false),
                    CandidateCreatedDate = table.Column<DateTime>(nullable: false),
                    CandidateStatus = table.Column<string>(nullable: true),
                    SalaryClaim = table.Column<decimal>(nullable: false),
                    LeaderCenters = table.Column<string>(nullable: true),
                    LtfOrPl = table.Column<string>(nullable: true),
                    ManagerSp = table.Column<string>(nullable: true),
                    Community = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false),
                    JobRecruiterName = table.Column<string>(nullable: true),
                    JobTechnology = table.Column<string>(nullable: true),
                    JobYearsOfExperience = table.Column<int>(nullable: false),
                    MaximumSalary = table.Column<decimal>(nullable: false),
                    DateInterView = table.Column<DateTime>(nullable: false),
                    AvailableDate = table.Column<DateTime>(nullable: false),
                    InterViewLeaderCenters = table.Column<string>(nullable: true),
                    TechnicalInterviewer = table.Column<string>(nullable: true),
                    Offer = table.Column<decimal>(nullable: false),
                    StatusInterviewId = table.Column<Guid>(nullable: false),
                    CandidateId = table.Column<Guid>(nullable: false),
                    JobId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.InterviewId);
                    table.ForeignKey(
                        name: "FK_Interviews_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_InterviewStatus_StatusInterviewId",
                        column: x => x.StatusInterviewId,
                        principalTable: "InterviewStatus",
                        principalColumn: "StatusInterviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AllocationTypes",
                columns: new[] { "AllocationTypeId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("edd0a0aa-3025-4d7f-a10e-d8ab6fb748fd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Presencial", null, null },
                    { new Guid("fce83b42-94bb-42ad-9f29-a609c1af02fc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teletrabalho", null, null }
                });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "CommunityId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1fce3dca-7e41-4300-8b72-3edacadb5863"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comunidade responsável por desenvolver software para agências de bancos. ", null, null, "Rede de Agências" },
                    { new Guid("d5382ed7-6de5-475e-8faf-361aaa4e335a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comunidade responsável por desenvolver software para o judiciário ", null, null, "Seguimento Jurídico" }
                });

            migrationBuilder.InsertData(
                table: "InterviewStatus",
                columns: new[] { "StatusInterviewId", "Description" },
                values: new object[,]
                {
                    { new Guid("87b87f11-969e-4ba4-85bc-537caf1c08e2"), "Aberto" },
                    { new Guid("4d535cd2-6a10-48a4-995f-8a4527db47c5"), "Fechado" },
                    { new Guid("789d31f7-e584-45cc-82fd-7b4b332b9ac7"), "Contratado" },
                    { new Guid("71ce3523-552f-4394-948f-4f5a1a61f5c1"), "Reprovado" }
                });

            migrationBuilder.InsertData(
                table: "LeaderCenters",
                columns: new[] { "LeaderCentersId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("88f77a96-db57-4c49-ac38-287d29d3cce4"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mirella Malu Vitória Pereira" },
                    { new Guid("2c3c9eda-cf5e-4a49-95c5-0c0537bdceb6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lucca Felipe Renato Araújo" },
                    { new Guid("56600516-88d8-43df-97e8-f2c9cb81dc84"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Alexandre Heitor Pedro Henrique Ferreira" },
                    { new Guid("f8507c2d-7579-42d3-a533-e499a605c768"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rosângela Andreia Manuela Nogueira" }
                });

            migrationBuilder.InsertData(
                table: "Ltf",
                columns: new[] { "LtfId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("d1ea6cfb-c8b6-4240-83ec-1e270cf4ffc1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Julia Rebeca Alana da Rosa" },
                    { new Guid("def35ef4-b62e-4703-ba53-2081d624fcce"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Filipe Raul Oliver Sales" },
                    { new Guid("09e779c2-8ddc-485c-a1af-35f688900541"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Anderson Oliveira Barbosa" }
                });

            migrationBuilder.InsertData(
                table: "ManagerSp",
                columns: new[] { "ManagerSpId", "Name" },
                values: new object[,]
                {
                    { new Guid("6521a664-018f-48a9-9d8e-36e5288ee611"), "Luiz Cláudio Emanuel Barros" },
                    { new Guid("28d79a49-f4b4-483b-8c9f-b5a831f145b7"), "Henry Renato Mendes" },
                    { new Guid("cff2ccef-c67c-447b-9717-cca91732c18a"), "Rafael Benjamin Marcos Vinicius da Paz" },
                    { new Guid("54aa0ac2-3b29-4ba3-98ea-00eb668b417c"), "Bruno Tomás Fernandes" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "Code", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("8c699ce3-f17e-41fe-be04-56dd8d44221d"), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prioridade inicial para o nível de contratação", null, null },
                    { new Guid("13787591-4682-4f55-bb66-d6eb53b41f22"), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prioridade média para o nível de contratação", null, null },
                    { new Guid("192a00ec-a662-4a6f-9376-cf59c241698e"), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prioridade máxima para o nível de contratação", null, null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4f8d68ea-78a2-4449-be9c-6b474f4f2ffd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Inter" },
                    { new Guid("4a92afdf-bff6-454d-bff5-45e5b1fd2edb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "América" },
                    { new Guid("91bb85ac-8e13-4b9f-bbcb-a21b1f1a3c9a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Banco Itaú" },
                    { new Guid("c132b5dd-479a-4c57-8969-0fd5f62d7def"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Santander" },
                    { new Guid("5ceaa5ef-a0a1-495f-8b69-178ce284d018"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Caixa" },
                    { new Guid("dce7d803-a44f-4a92-b52d-aa2006376bc6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Itaú" },
                    { new Guid("d6f0b8bd-2c2c-4d44-ae92-b6a29c7c73e9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Hsbc" }
                });

            migrationBuilder.InsertData(
                table: "Recruiters",
                columns: new[] { "RecruiterId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("7c80caac-ca78-4ae1-8760-6fadb5f17454"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Amanda Nobrega" },
                    { new Guid("10692d46-29db-4757-9974-54ff69dfbd60"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Benedito Cláudio Bernardes" },
                    { new Guid("e7a3a895-9c23-4f9e-b95b-f9b00155a35d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mariana Eliane Patrícia Assis" },
                    { new Guid("a716de56-6f1d-44e6-8e87-2118f88f8fbe"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Gustavo Nicolas Leandro da Silva" }
                });

            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "SquadId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("6b233f3f-b9a5-4bca-8888-6c05e7efd5f0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automação de processos", null, null, "Automação" },
                    { new Guid("cb81dbb3-521f-417c-a0eb-d1e609621694"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Extensão da squad no cliente", null, null, "Extensão" },
                    { new Guid("2fc6c21f-c70b-4a67-b9dc-6f428aff39e8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Squad que atua o desenvolvimento de novas soluções", null, null, "Soluções customizadas" }
                });

            migrationBuilder.InsertData(
                table: "StatusCandidates",
                columns: new[] { "StatusCandidateId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("86829568-fa06-497a-9179-d88ebd1ff876"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disponível", null, null },
                    { new Guid("bcfcb699-d73e-4d91-8a0a-df0da45445df"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprovado", null, null },
                    { new Guid("b7eb1a42-58a7-456d-addd-afdca19e7974"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contratado", null, null },
                    { new Guid("0ac67cf3-8bfa-4b3f-b68b-da2159065afe"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indisponível", null, null }
                });

            migrationBuilder.InsertData(
                table: "StatusJobs",
                columns: new[] { "StatusJobId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { new Guid("b3fc5eff-0179-45d4-a6f9-561958538b71"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fechado", null, null },
                    { new Guid("8b5b6de5-7af8-497a-b4a9-af51dbde126f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aberto", null, null }
                });

            migrationBuilder.InsertData(
                table: "Techonologies",
                columns: new[] { "TechnologyId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("fc69eabf-ead5-4a93-8a17-c76882913453"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications", null, null, "ReactJS", "Frontend" },
                    { new Guid("b6dc1e53-9b22-4884-aba2-c5b66e17df48"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications e Mobile", null, null, "Flutter", "Frontend" },
                    { new Guid("1080b4e8-6c88-4937-b041-01158f7649a2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications", null, null, "AngularJS", "Frontend" },
                    { new Guid("889c8a85-567b-476c-be06-00a018b5254a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications", null, null, "VueJS", "Frontend" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_AllocationTypeId",
                table: "Candidates",
                column: "AllocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_StatusCandidateId",
                table: "Candidates",
                column: "StatusCandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_CandidateId",
                table: "Interviews",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_JobId",
                table: "Interviews",
                column: "JobId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_StatusInterviewId",
                table: "Interviews",
                column: "StatusInterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_AllocationTypeId",
                table: "Jobs",
                column: "AllocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_AllocationTypeId1",
                table: "Jobs",
                column: "AllocationTypeId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ProjectId",
                table: "Jobs",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_StatusJobId",
                table: "Jobs",
                column: "StatusJobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "LeaderCenters");

            migrationBuilder.DropTable(
                name: "Ltf");

            migrationBuilder.DropTable(
                name: "ManagerSp");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Recruiters");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropTable(
                name: "Techonologies");

            migrationBuilder.DropTable(
                name: "YearsOfExperience");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "InterviewStatus");

            migrationBuilder.DropTable(
                name: "StatusCandidates");

            migrationBuilder.DropTable(
                name: "AllocationTypes");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "StatusJobs");
        }
    }
}
