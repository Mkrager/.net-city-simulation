using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitySimulation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeededDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("fc911511-5645-420c-b821-49ea5df976e8"), "Lviv" });

            migrationBuilder.InsertData(
                table: "Workplaces",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[,]
                {
                    { new Guid("208fb852-49a2-4e83-a380-cd0c364fbd65"), 5, "City Hospital" },
                    { new Guid("90661f93-d29b-4282-b43f-a5c2b1ae120b"), 10, "Tech Company" },
                    { new Guid("ddc380f3-7ae8-4766-b147-aba16bc259da"), 5, "Lviv School" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Salary", "Title", "WorkplaceId" },
                values: new object[,]
                {
                    { new Guid("0d3d2c4b-839b-45a9-b1ba-5e4f1e51c773"), 4500, "Doctor", new Guid("208fb852-49a2-4e83-a380-cd0c364fbd65") },
                    { new Guid("1a87ee13-a494-4e33-8098-82f6552cb167"), 4000, "Project Manager", new Guid("90661f93-d29b-4282-b43f-a5c2b1ae120b") },
                    { new Guid("3a56ce67-81d7-4aec-b63d-0aa660a35241"), 3000, "Software Developer", new Guid("90661f93-d29b-4282-b43f-a5c2b1ae120b") },
                    { new Guid("66cb4162-e423-4779-a48a-28c1b0a49b49"), 2500, "Nurse", new Guid("208fb852-49a2-4e83-a380-cd0c364fbd65") },
                    { new Guid("8165c34b-de0a-4219-b4ca-ce4bd666be66"), 2000, "Teacher", new Guid("ddc380f3-7ae8-4766-b147-aba16bc259da") }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CityId", "Gender", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("2d2856ac-e397-4bbf-830e-936ea8a4b092"), 16, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 0, null, "Daniel" },
                    { new Guid("4424ac4a-e973-4230-a7f1-ad3cccbb84ef"), 8, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 1, null, "Olivia" },
                    { new Guid("70eab2fa-ced4-4fe2-aedf-526e6ee271e8"), 67, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 0, null, "James" },
                    { new Guid("86460eee-5fdf-4caa-be6c-36b6454a2c15"), 70, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 1, null, "Mia" },
                    { new Guid("cfa3e603-cec9-4c06-9b83-cbe80aeab478"), 17, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 1, null, "Sophie" },
                    { new Guid("117f4d96-d91c-4822-8107-d38109fec3e4"), 22, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 0, new Guid("3a56ce67-81d7-4aec-b63d-0aa660a35241"), "Max" },
                    { new Guid("29408384-5154-46cd-845b-68596e35984e"), 28, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 1, new Guid("8165c34b-de0a-4219-b4ca-ce4bd666be66"), "Anna" },
                    { new Guid("5cf2777b-e8ab-434b-83a7-9f9de7066ca1"), 25, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 0, new Guid("66cb4162-e423-4779-a48a-28c1b0a49b49"), "Alex" },
                    { new Guid("656d0a00-ef8e-4b05-880d-6ef73daee850"), 31, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 1, new Guid("0d3d2c4b-839b-45a9-b1ba-5e4f1e51c773"), "Emma" },
                    { new Guid("9dacc560-a3e1-4516-8e34-cc49b657ffc5"), 35, new Guid("fc911511-5645-420c-b821-49ea5df976e8"), 0, new Guid("1a87ee13-a494-4e33-8098-82f6552cb167"), "John" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("117f4d96-d91c-4822-8107-d38109fec3e4"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("29408384-5154-46cd-845b-68596e35984e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("2d2856ac-e397-4bbf-830e-936ea8a4b092"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4424ac4a-e973-4230-a7f1-ad3cccbb84ef"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5cf2777b-e8ab-434b-83a7-9f9de7066ca1"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("656d0a00-ef8e-4b05-880d-6ef73daee850"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("70eab2fa-ced4-4fe2-aedf-526e6ee271e8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("86460eee-5fdf-4caa-be6c-36b6454a2c15"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9dacc560-a3e1-4516-8e34-cc49b657ffc5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cfa3e603-cec9-4c06-9b83-cbe80aeab478"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fc911511-5645-420c-b821-49ea5df976e8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0d3d2c4b-839b-45a9-b1ba-5e4f1e51c773"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1a87ee13-a494-4e33-8098-82f6552cb167"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3a56ce67-81d7-4aec-b63d-0aa660a35241"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("66cb4162-e423-4779-a48a-28c1b0a49b49"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8165c34b-de0a-4219-b4ca-ce4bd666be66"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("208fb852-49a2-4e83-a380-cd0c364fbd65"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("90661f93-d29b-4282-b43f-a5c2b1ae120b"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("ddc380f3-7ae8-4766-b147-aba16bc259da"));
        }
    }
}
