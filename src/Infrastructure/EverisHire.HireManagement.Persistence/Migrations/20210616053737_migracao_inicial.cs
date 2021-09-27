using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EverisHire.HireManagement.Persistence.Migrations
{
    public partial class migracao_inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "StatusJobs",
                columns: table => new
                {
                    StatusJobId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Code = table.Column<int>(nullable: false),
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
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    EverJob = table.Column<int>(nullable: false),
                    LeaderCenters = table.Column<string>(nullable: true),
                    LtfOrPl = table.Column<string>(nullable: true),
                    ManagerSp = table.Column<string>(maxLength: 50, nullable: false),
                    Community = table.Column<string>(nullable: true),
                    Squad = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: false),
                    AllocationType = table.Column<string>(nullable: true),
                    OpeningDate = table.Column<DateTime>(nullable: true),
                    Technology = table.Column<string>(maxLength: 20, nullable: true),
                    YearsOfExperience = table.Column<Guid>(nullable: false),
                    DesiredDate = table.Column<DateTime>(nullable: true),
                    MaximumSalary = table.Column<decimal>(nullable: false),
                    Recruiter = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    PriorityDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(maxLength: 20, nullable: false),
                    Justification = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Jobs_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
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
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    AlocationType = table.Column<string>(maxLength: 50, nullable: false),
                    YearsOfExperience = table.Column<int>(nullable: false),
                    WhoIndicated = table.Column<string>(nullable: true),
                    SalaryClaim = table.Column<decimal>(nullable: false),
                    JobId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.CandidateId);
                    table.ForeignKey(
                        name: "FK_Candidates_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "CommunityId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("556e39aa-1ee6-4447-9579-ec561c45eb3e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comunidade responsável por desenvolver software para agências de bancos. ", null, null, "Rede de Agências" });

            migrationBuilder.InsertData(
                table: "LeaderCenters",
                columns: new[] { "LeaderCentersId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("95c9689d-4a0d-4c34-b1fc-77d1581a30f8"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Roosevelt Gaipo" });

            migrationBuilder.InsertData(
                table: "Ltf",
                columns: new[] { "LtfId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("af9d512a-26ed-492c-ba66-79c73badd20d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Anderson Oliveira Barbosa" });

            migrationBuilder.InsertData(
                table: "ManagerSp",
                columns: new[] { "ManagerSpId", "Name" },
                values: new object[] { new Guid("2bed1707-291b-491e-b01a-87827d7b8351"), "Daiane Viana dos Santos" });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "Code", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate" },
                values: new object[] { new Guid("192a00ec-a662-4a6f-9376-cf59c241698e"), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prioridade máxima para o nível de contratação", null, null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4f8d68ea-78a2-4449-be9c-6b474f4f2ffd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Inter" },
                    { new Guid("5ceaa5ef-a0a1-495f-8b69-178ce284d018"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Caixa" },
                    { new Guid("d6f0b8bd-2c2c-4d44-ae92-b6a29c7c73e9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Hsbc" },
                    { new Guid("4a92afdf-bff6-454d-bff5-45e5b1fd2edb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "América" },
                    { new Guid("c132b5dd-479a-4c57-8969-0fd5f62d7def"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Santander" },
                    { new Guid("91bb85ac-8e13-4b9f-bbcb-a21b1f1a3c9a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Banco Itaú" },
                    { new Guid("dce7d803-a44f-4a92-b52d-aa2006376bc6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem descrição", null, null, "Itaú" }
                });

            migrationBuilder.InsertData(
                table: "Recruiters",
                columns: new[] { "RecruiterId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("1fb97415-ceaf-4a99-ac53-0476620c0d61"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Amanda Nobrega" });

            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "SquadId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { new Guid("b38454c2-9d8b-48fe-8e0d-e5f3bf3f80b7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Squad de colaboradores que atuam por teletrabalho", null, null, "Squad de automação" });

            migrationBuilder.InsertData(
                table: "StatusJobs",
                columns: new[] { "StatusJobId", "Code", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate" },
                values: new object[] { new Guid("75410d2f-8784-401d-97f8-a4d00b8c0309"), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aberta", null, null });

            migrationBuilder.InsertData(
                table: "Techonologies",
                columns: new[] { "TechnologyId", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("889c8a85-567b-476c-be06-00a018b5254a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications", null, null, "VueJS", "Frontend" },
                    { new Guid("1080b4e8-6c88-4937-b041-01158f7649a2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications", null, null, "AngularJS", "Frontend" },
                    { new Guid("fc69eabf-ead5-4a93-8a17-c76882913453"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications", null, null, "ReactJS", "Frontend" },
                    { new Guid("b6dc1e53-9b22-4884-aba2-c5b66e17df48"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Framework para desenvolvimento de Single Page Applications e Mobile", null, null, "Flutter", "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "YearsOfExperience",
                columns: new[] { "YearsOfExperienceId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "ViewValue" },
                values: new object[] { new Guid("03cef292-b366-4ec0-b1ec-e02e54380ef6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "1 - 2" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobId", "AllocationType", "Community", "CreatedBy", "CreatedDate", "DesiredDate", "EverJob", "Justification", "LastModifiedBy", "LastModifiedDate", "LeaderCenters", "LtfOrPl", "ManagerSp", "MaximumSalary", "OpeningDate", "Priority", "PriorityDate", "ProjectId", "Recruiter", "Squad", "Status", "Technology", "YearsOfExperience" },
                values: new object[] { new Guid("4bacb9db-5cdc-408a-8a8b-bd2e3727ba05"), "Remoto", "Inovação", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 176498, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec enim condimentum.", null, null, "Roosevelt Gaipó", "Adilson Hemmel Dias", "Renato Oliveira", 15000m, new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("91bb85ac-8e13-4b9f-bbcb-a21b1f1a3c9a"), "Amanda Silva", "Automação sustentável", "Aberto", ".NET CORE", new Guid("03cef292-b366-4ec0-b1ec-e02e54380ef6") });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_JobId",
                table: "Candidates",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ProjectId",
                table: "Jobs",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "Events");

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
                name: "StatusJobs");

            migrationBuilder.DropTable(
                name: "Techonologies");

            migrationBuilder.DropTable(
                name: "YearsOfExperience");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
