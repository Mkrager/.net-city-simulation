using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitySimulation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Money = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workplaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workplaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workplaces_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkplaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Workplaces_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Money = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LivingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Persons_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("71e68882-246a-4585-8c93-5e09b953f288"), "Lviv" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CityId", "Money", "Name" },
                values: new object[,]
                {
                    { new Guid("5d15b85a-21c6-4dc5-abef-87f3210b9575"), new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 100000m, "LvivTech" },
                    { new Guid("9201172d-f027-47a7-9a4a-01a6054c9c78"), new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 150000m, "Lviv Health" },
                    { new Guid("f3059cf6-850d-4b4f-a6be-bd848cf37c9a"), new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 50000m, "Lviv Education" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CityId", "Gender", "JobId", "LivingCost", "Money", "Name", "PartnerId" },
                values: new object[,]
                {
                    { new Guid("2dcebe48-649f-479e-a859-22336076ce48"), 16, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 0, null, 0m, 0m, "Daniel", null },
                    { new Guid("49f5aadb-6e4b-4758-93d3-0f646c6a810e"), 70, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 1, null, 0m, 0m, "Mia", null },
                    { new Guid("83a6afa1-a8c6-4c22-9e60-d304724e41e7"), 17, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 1, null, 0m, 0m, "Sophie", null },
                    { new Guid("cdcb284a-c636-449e-a3ee-3f0987c28586"), 67, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 0, null, 0m, 0m, "James", null },
                    { new Guid("f1e0f11d-541b-41d3-9191-738bf9bd4cba"), 8, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 1, null, 0m, 0m, "Olivia", null }
                });

            migrationBuilder.InsertData(
                table: "Workplaces",
                columns: new[] { "Id", "Capacity", "CompanyId", "Name" },
                values: new object[,]
                {
                    { new Guid("95c4785c-6925-4498-88c3-764f5d75d2de"), 5, new Guid("9201172d-f027-47a7-9a4a-01a6054c9c78"), "City Hospital" },
                    { new Guid("d2b917be-1d6a-4573-9c15-a4cf31cb139a"), 5, new Guid("f3059cf6-850d-4b4f-a6be-bd848cf37c9a"), "Lviv School" },
                    { new Guid("f35827e8-1e4b-4fde-8d0f-c13b19efbca0"), 10, new Guid("5d15b85a-21c6-4dc5-abef-87f3210b9575"), "Tech Office" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AnnualSalary", "Title", "WorkplaceId" },
                values: new object[,]
                {
                    { new Guid("034ddd96-db4a-473a-9e6c-0af9b9667d73"), 2000m, "Teacher", new Guid("d2b917be-1d6a-4573-9c15-a4cf31cb139a") },
                    { new Guid("2a8bc2f4-6362-4a5f-81cc-5306d396e524"), 2500m, "Nurse", new Guid("95c4785c-6925-4498-88c3-764f5d75d2de") },
                    { new Guid("3b3f07bc-16ee-4aea-907c-3d4488de4602"), 4000m, "Project Manager", new Guid("f35827e8-1e4b-4fde-8d0f-c13b19efbca0") },
                    { new Guid("76415459-d820-4645-bd72-1ab96d7e92a9"), 4500m, "Doctor", new Guid("95c4785c-6925-4498-88c3-764f5d75d2de") },
                    { new Guid("fa0312dc-932b-4b6b-82d3-36e60b40f847"), 3000m, "Software Developer", new Guid("f35827e8-1e4b-4fde-8d0f-c13b19efbca0") }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CityId", "Gender", "JobId", "LivingCost", "Money", "Name", "PartnerId" },
                values: new object[,]
                {
                    { new Guid("5af65687-7427-41d3-ab7c-43b6a0772b7a"), 22, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 0, new Guid("fa0312dc-932b-4b6b-82d3-36e60b40f847"), 0m, 0m, "Max", null },
                    { new Guid("8cbc58aa-aa1c-41d7-98e3-0fb7db93d84d"), 28, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 1, new Guid("034ddd96-db4a-473a-9e6c-0af9b9667d73"), 0m, 0m, "Anna", null },
                    { new Guid("af506742-37ef-42d6-8198-fb0099d80365"), 35, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 0, new Guid("3b3f07bc-16ee-4aea-907c-3d4488de4602"), 0m, 0m, "John", null },
                    { new Guid("f89d8f19-977b-45a8-a0e9-eac070d6ec41"), 31, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 1, new Guid("76415459-d820-4645-bd72-1ab96d7e92a9"), 0m, 0m, "Emma", null },
                    { new Guid("f9fdba5a-4baf-4b39-a0bb-7ead1e693074"), 25, new Guid("71e68882-246a-4585-8c93-5e09b953f288"), 0, new Guid("2a8bc2f4-6362-4a5f-81cc-5306d396e524"), 0m, 0m, "Alex", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_WorkplaceId",
                table: "Jobs",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CityId",
                table: "Persons",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_JobId",
                table: "Persons",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PartnerId",
                table: "Persons",
                column: "PartnerId",
                unique: true,
                filter: "[PartnerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Workplaces_CompanyId",
                table: "Workplaces",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Workplaces");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
