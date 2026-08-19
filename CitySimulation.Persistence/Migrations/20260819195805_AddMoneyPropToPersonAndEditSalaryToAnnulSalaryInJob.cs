using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitySimulation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddMoneyPropToPersonAndEditSalaryToAnnulSalaryInJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Salary",
                table: "Jobs");

            migrationBuilder.AddColumn<decimal>(
                name: "Money",
                table: "Persons",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AnnualSalary",
                table: "Jobs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), "Lviv" });

            migrationBuilder.InsertData(
                table: "Workplaces",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[,]
                {
                    { new Guid("508d59e5-41b6-4560-bf9d-8b11ecde274d"), 5, "Lviv School" },
                    { new Guid("7e76b8eb-ac42-436e-9045-153286f5a333"), 10, "Tech Company" },
                    { new Guid("f94949b1-b1ba-452b-813b-a78202f4e875"), 5, "City Hospital" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AnnualSalary", "Title", "WorkplaceId" },
                values: new object[,]
                {
                    { new Guid("16e1b967-3326-4ca8-801e-15828447f2ac"), 3000m, "Software Developer", new Guid("7e76b8eb-ac42-436e-9045-153286f5a333") },
                    { new Guid("328cb786-10de-4b72-9bcc-b30d502df34a"), 4000m, "Project Manager", new Guid("7e76b8eb-ac42-436e-9045-153286f5a333") },
                    { new Guid("438cd5dd-a5c2-453b-8de5-8ddea426ccf9"), 2500m, "Nurse", new Guid("f94949b1-b1ba-452b-813b-a78202f4e875") },
                    { new Guid("4a7dc922-2408-4885-be9e-dbc1c8d86e46"), 4500m, "Doctor", new Guid("f94949b1-b1ba-452b-813b-a78202f4e875") },
                    { new Guid("6551d8ac-f741-4a40-b776-c36070d4c7eb"), 2000m, "Teacher", new Guid("508d59e5-41b6-4560-bf9d-8b11ecde274d") }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CityId", "Gender", "JobId", "Money", "Name", "PartnerId" },
                values: new object[,]
                {
                    { new Guid("68e84d67-649b-4d0b-88eb-0c4c53963b93"), 70, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 1, null, 0m, "Mia", null },
                    { new Guid("9be88d60-ea11-48cb-8002-fde5c3b28407"), 17, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 1, null, 0m, "Sophie", null },
                    { new Guid("a0775f49-8734-4bfa-be5e-eae51e6373c2"), 67, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 0, null, 0m, "James", null },
                    { new Guid("a8f9a481-f34d-4b72-a3a5-686b29c69c57"), 16, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 0, null, 0m, "Daniel", null },
                    { new Guid("d693dd51-0eb0-4e9b-a937-453631f977ca"), 8, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 1, null, 0m, "Olivia", null },
                    { new Guid("418255a0-8646-419d-836a-028229a0515c"), 28, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 1, new Guid("6551d8ac-f741-4a40-b776-c36070d4c7eb"), 0m, "Anna", null },
                    { new Guid("61462904-0af5-429f-98be-2756187952a5"), 31, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 1, new Guid("4a7dc922-2408-4885-be9e-dbc1c8d86e46"), 0m, "Emma", null },
                    { new Guid("84bd3808-fb5b-4865-a118-52410f6d7002"), 22, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 0, new Guid("16e1b967-3326-4ca8-801e-15828447f2ac"), 0m, "Max", null },
                    { new Guid("c3a2a8f4-dbd7-4d62-89ea-ba81ba825e11"), 35, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 0, new Guid("328cb786-10de-4b72-9bcc-b30d502df34a"), 0m, "John", null },
                    { new Guid("e413fb20-b525-4abb-a61c-3f06459396ef"), 25, new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"), 0, new Guid("438cd5dd-a5c2-453b-8de5-8ddea426ccf9"), 0m, "Alex", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("418255a0-8646-419d-836a-028229a0515c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("61462904-0af5-429f-98be-2756187952a5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("68e84d67-649b-4d0b-88eb-0c4c53963b93"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("84bd3808-fb5b-4865-a118-52410f6d7002"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9be88d60-ea11-48cb-8002-fde5c3b28407"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a0775f49-8734-4bfa-be5e-eae51e6373c2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a8f9a481-f34d-4b72-a3a5-686b29c69c57"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("c3a2a8f4-dbd7-4d62-89ea-ba81ba825e11"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("d693dd51-0eb0-4e9b-a937-453631f977ca"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e413fb20-b525-4abb-a61c-3f06459396ef"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a8bd7ba3-63bd-4874-a617-e41d80868960"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("16e1b967-3326-4ca8-801e-15828447f2ac"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("328cb786-10de-4b72-9bcc-b30d502df34a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("438cd5dd-a5c2-453b-8de5-8ddea426ccf9"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4a7dc922-2408-4885-be9e-dbc1c8d86e46"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6551d8ac-f741-4a40-b776-c36070d4c7eb"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("508d59e5-41b6-4560-bf9d-8b11ecde274d"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("7e76b8eb-ac42-436e-9045-153286f5a333"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("f94949b1-b1ba-452b-813b-a78202f4e875"));

            migrationBuilder.DropColumn(
                name: "Money",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "AnnualSalary",
                table: "Jobs");

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
