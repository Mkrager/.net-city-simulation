using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitySimulation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPatnerToPersonEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PartnerId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0671f1db-4475-426e-8652-b698be601684"), "Lviv" });

            migrationBuilder.InsertData(
                table: "Workplaces",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[,]
                {
                    { new Guid("0fe42522-4d18-4251-a0ef-f7d3e98b20cf"), 10, "Tech Company" },
                    { new Guid("5da77971-c022-44d2-8169-fcc0f12d9383"), 5, "City Hospital" },
                    { new Guid("b13a6e29-0933-4daf-bb52-482924f29f38"), 5, "Lviv School" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Salary", "Title", "WorkplaceId" },
                values: new object[,]
                {
                    { new Guid("0b1ce234-f0fe-4138-9123-bf214bf5555b"), 3000, "Software Developer", new Guid("0fe42522-4d18-4251-a0ef-f7d3e98b20cf") },
                    { new Guid("25a20379-7696-47fa-a685-a702fb20858f"), 4500, "Doctor", new Guid("5da77971-c022-44d2-8169-fcc0f12d9383") },
                    { new Guid("ab707990-22be-4a3d-a964-82638fd719ab"), 2000, "Teacher", new Guid("b13a6e29-0933-4daf-bb52-482924f29f38") },
                    { new Guid("acbc6165-c0dc-4af7-a33f-4e5dfe24b2d7"), 4000, "Project Manager", new Guid("0fe42522-4d18-4251-a0ef-f7d3e98b20cf") },
                    { new Guid("d7bbe413-829d-42db-b68b-094a07793849"), 2500, "Nurse", new Guid("5da77971-c022-44d2-8169-fcc0f12d9383") }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CityId", "Gender", "JobId", "Name", "PartnerId" },
                values: new object[,]
                {
                    { new Guid("1215714b-4e11-4f64-bc69-6874d039974c"), 17, new Guid("0671f1db-4475-426e-8652-b698be601684"), 1, null, "Sophie", null },
                    { new Guid("71aec48b-620c-4db7-918a-4210dd2a058a"), 70, new Guid("0671f1db-4475-426e-8652-b698be601684"), 1, null, "Mia", null },
                    { new Guid("73aa66b6-12ce-4901-87e7-eb8bbe187ffa"), 16, new Guid("0671f1db-4475-426e-8652-b698be601684"), 0, null, "Daniel", null },
                    { new Guid("78f9b7d2-67ee-44dc-89d9-4117b7ce10c7"), 8, new Guid("0671f1db-4475-426e-8652-b698be601684"), 1, null, "Olivia", null },
                    { new Guid("e866e4e4-7a84-4c4e-ba3b-6beb1abd422c"), 67, new Guid("0671f1db-4475-426e-8652-b698be601684"), 0, null, "James", null },
                    { new Guid("38e9cf12-aebc-4f37-9f58-4d009b067e82"), 35, new Guid("0671f1db-4475-426e-8652-b698be601684"), 0, new Guid("acbc6165-c0dc-4af7-a33f-4e5dfe24b2d7"), "John", null },
                    { new Guid("6995627f-51dd-4772-a041-91e28def0cdd"), 28, new Guid("0671f1db-4475-426e-8652-b698be601684"), 1, new Guid("ab707990-22be-4a3d-a964-82638fd719ab"), "Anna", null },
                    { new Guid("8349f334-0f7e-4d4e-9bf6-9a610e622bdb"), 22, new Guid("0671f1db-4475-426e-8652-b698be601684"), 0, new Guid("0b1ce234-f0fe-4138-9123-bf214bf5555b"), "Max", null },
                    { new Guid("c21098ce-5f32-49ed-9363-d596d95d3f25"), 25, new Guid("0671f1db-4475-426e-8652-b698be601684"), 0, new Guid("d7bbe413-829d-42db-b68b-094a07793849"), "Alex", null },
                    { new Guid("f968793c-dd27-4ded-b2b1-bd62f070f373"), 31, new Guid("0671f1db-4475-426e-8652-b698be601684"), 1, new Guid("25a20379-7696-47fa-a685-a702fb20858f"), "Emma", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PartnerId",
                table: "Persons",
                column: "PartnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_PartnerId",
                table: "Persons",
                column: "PartnerId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_PartnerId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PartnerId",
                table: "Persons");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1215714b-4e11-4f64-bc69-6874d039974c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("38e9cf12-aebc-4f37-9f58-4d009b067e82"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6995627f-51dd-4772-a041-91e28def0cdd"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("71aec48b-620c-4db7-918a-4210dd2a058a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("73aa66b6-12ce-4901-87e7-eb8bbe187ffa"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("78f9b7d2-67ee-44dc-89d9-4117b7ce10c7"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8349f334-0f7e-4d4e-9bf6-9a610e622bdb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c21098ce-5f32-49ed-9363-d596d95d3f25"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e866e4e4-7a84-4c4e-ba3b-6beb1abd422c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f968793c-dd27-4ded-b2b1-bd62f070f373"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0671f1db-4475-426e-8652-b698be601684"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0b1ce234-f0fe-4138-9123-bf214bf5555b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("25a20379-7696-47fa-a685-a702fb20858f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ab707990-22be-4a3d-a964-82638fd719ab"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("acbc6165-c0dc-4af7-a33f-4e5dfe24b2d7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d7bbe413-829d-42db-b68b-094a07793849"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("0fe42522-4d18-4251-a0ef-f7d3e98b20cf"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("5da77971-c022-44d2-8169-fcc0f12d9383"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("b13a6e29-0933-4daf-bb52-482924f29f38"));

            migrationBuilder.DropColumn(
                name: "PartnerId",
                table: "Persons");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
