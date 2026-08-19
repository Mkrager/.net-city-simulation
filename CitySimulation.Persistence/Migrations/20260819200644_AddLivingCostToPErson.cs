using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitySimulation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddLivingCostToPErson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("1f1a6935-51ef-4368-adb5-cd99df124867"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4e1fa8ad-4819-49ef-bf64-0d20520f2d7e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("697cb4d9-6530-43d6-a0c3-a0d2ca7c3ebe"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6b1cdd4f-6e73-48f5-95db-a847e25234b5"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6ca886ca-0033-434d-893b-1fd7d8272769"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("8ff3cba4-bab9-41c2-b990-a50fe59a4fc3"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("94adffcc-fb7a-4f93-880f-0b8e14669f6a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("cd4e25e2-c376-42f2-bfd1-679e19d9a55a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fda5dee7-e66d-45c6-bd45-d9756d0018e2"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("ff5c4db5-d6cb-4c79-a723-c9546edfdf4b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3511646d-8567-46ad-9d05-74a2fac21f91"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("844ef091-c288-47f4-8edb-884cee07aaa6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9a201367-19cb-4cd7-a7e7-e20a1d7c1562"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b5631cc9-d4f2-4014-8f50-5c6f4d6cfe2f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("caf684c8-f8b3-42b9-83a1-ce99c66b6c06"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("17ebdb58-0989-4061-b66c-78173ebeac5a"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("31221fda-95c9-4da7-a168-250d41d3257a"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("abeb2d35-c30b-40b1-8e5c-abacf8f6f437"));

            migrationBuilder.AddColumn<decimal>(
                name: "LivingCost",
                table: "Persons",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), "Lviv" });

            migrationBuilder.InsertData(
                table: "Workplaces",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[,]
                {
                    { new Guid("1e973114-3f0b-4a68-a1cb-6351d5c58e19"), 10, "Tech Company" },
                    { new Guid("4e5adcce-cb0b-4d2a-92ae-03802011bbb7"), 5, "Lviv School" },
                    { new Guid("c168f849-9964-4e83-a610-c2a19f8d8821"), 5, "City Hospital" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AnnualSalary", "Title", "WorkplaceId" },
                values: new object[,]
                {
                    { new Guid("0182d978-7424-43aa-8516-07f72c96abc3"), 2500m, "Nurse", new Guid("c168f849-9964-4e83-a610-c2a19f8d8821") },
                    { new Guid("31e161a7-233c-4c07-a793-e8855d66abd0"), 4000m, "Project Manager", new Guid("1e973114-3f0b-4a68-a1cb-6351d5c58e19") },
                    { new Guid("483d36b6-0f37-434e-ba7e-8cd419489611"), 2000m, "Teacher", new Guid("4e5adcce-cb0b-4d2a-92ae-03802011bbb7") },
                    { new Guid("7aa3fe04-cc0d-4a71-bf1e-c2056c148899"), 3000m, "Software Developer", new Guid("1e973114-3f0b-4a68-a1cb-6351d5c58e19") },
                    { new Guid("90e78a65-b781-4a81-8a81-efce26a4b90d"), 4500m, "Doctor", new Guid("c168f849-9964-4e83-a610-c2a19f8d8821") }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CityId", "Gender", "JobId", "LivingCost", "Money", "Name", "PartnerId" },
                values: new object[,]
                {
                    { new Guid("19b33a99-037c-44b4-852a-7fda0ebbcae0"), 67, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 0, null, 0m, 0m, "James", null },
                    { new Guid("5828f5ad-223f-4a5e-8a93-fe4bd5f62619"), 17, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 1, null, 0m, 0m, "Sophie", null },
                    { new Guid("6f91a300-b8f6-46a0-b9fd-d7b6299a5d68"), 16, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 0, null, 0m, 0m, "Daniel", null },
                    { new Guid("96618793-8305-4aba-8c36-883e7dd74c6b"), 70, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 1, null, 0m, 0m, "Mia", null },
                    { new Guid("aa9c490a-b3c4-4203-a795-9c79debef739"), 8, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 1, null, 0m, 0m, "Olivia", null },
                    { new Guid("0fc54110-eb46-40c3-a9a5-f86a991bbb79"), 22, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 0, new Guid("7aa3fe04-cc0d-4a71-bf1e-c2056c148899"), 0m, 0m, "Max", null },
                    { new Guid("af6481e8-80a0-47bd-bcbc-2c2c926523ba"), 25, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 0, new Guid("0182d978-7424-43aa-8516-07f72c96abc3"), 0m, 0m, "Alex", null },
                    { new Guid("dcaf5951-377a-4106-a9cd-a20fb046ccd8"), 35, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 0, new Guid("31e161a7-233c-4c07-a793-e8855d66abd0"), 0m, 0m, "John", null },
                    { new Guid("e545f057-3801-4190-a984-703a5aa8909c"), 28, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 1, new Guid("483d36b6-0f37-434e-ba7e-8cd419489611"), 0m, 0m, "Anna", null },
                    { new Guid("fc975e4e-dd7d-40ed-bd52-41142e7eb22b"), 31, new Guid("59b8a68f-913a-4a06-a532-0da494c71099"), 1, new Guid("90e78a65-b781-4a81-8a81-efce26a4b90d"), 0m, 0m, "Emma", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("0fc54110-eb46-40c3-a9a5-f86a991bbb79"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("19b33a99-037c-44b4-852a-7fda0ebbcae0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5828f5ad-223f-4a5e-8a93-fe4bd5f62619"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("6f91a300-b8f6-46a0-b9fd-d7b6299a5d68"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("96618793-8305-4aba-8c36-883e7dd74c6b"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("aa9c490a-b3c4-4203-a795-9c79debef739"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("af6481e8-80a0-47bd-bcbc-2c2c926523ba"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("dcaf5951-377a-4106-a9cd-a20fb046ccd8"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e545f057-3801-4190-a984-703a5aa8909c"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("fc975e4e-dd7d-40ed-bd52-41142e7eb22b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("59b8a68f-913a-4a06-a532-0da494c71099"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0182d978-7424-43aa-8516-07f72c96abc3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("31e161a7-233c-4c07-a793-e8855d66abd0"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("483d36b6-0f37-434e-ba7e-8cd419489611"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7aa3fe04-cc0d-4a71-bf1e-c2056c148899"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("90e78a65-b781-4a81-8a81-efce26a4b90d"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("1e973114-3f0b-4a68-a1cb-6351d5c58e19"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("4e5adcce-cb0b-4d2a-92ae-03802011bbb7"));

            migrationBuilder.DeleteData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: new Guid("c168f849-9964-4e83-a610-c2a19f8d8821"));

            migrationBuilder.DropColumn(
                name: "LivingCost",
                table: "Persons");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), "Lviv" });

            migrationBuilder.InsertData(
                table: "Workplaces",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[,]
                {
                    { new Guid("17ebdb58-0989-4061-b66c-78173ebeac5a"), 5, "Lviv School" },
                    { new Guid("31221fda-95c9-4da7-a168-250d41d3257a"), 10, "Tech Company" },
                    { new Guid("abeb2d35-c30b-40b1-8e5c-abacf8f6f437"), 5, "City Hospital" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AnnualSalary", "Title", "WorkplaceId" },
                values: new object[,]
                {
                    { new Guid("3511646d-8567-46ad-9d05-74a2fac21f91"), 4000m, "Project Manager", new Guid("31221fda-95c9-4da7-a168-250d41d3257a") },
                    { new Guid("844ef091-c288-47f4-8edb-884cee07aaa6"), 3000m, "Software Developer", new Guid("31221fda-95c9-4da7-a168-250d41d3257a") },
                    { new Guid("9a201367-19cb-4cd7-a7e7-e20a1d7c1562"), 2000m, "Teacher", new Guid("17ebdb58-0989-4061-b66c-78173ebeac5a") },
                    { new Guid("b5631cc9-d4f2-4014-8f50-5c6f4d6cfe2f"), 4500m, "Doctor", new Guid("abeb2d35-c30b-40b1-8e5c-abacf8f6f437") },
                    { new Guid("caf684c8-f8b3-42b9-83a1-ce99c66b6c06"), 2500m, "Nurse", new Guid("abeb2d35-c30b-40b1-8e5c-abacf8f6f437") }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CityId", "Gender", "JobId", "Money", "Name", "PartnerId" },
                values: new object[,]
                {
                    { new Guid("1f1a6935-51ef-4368-adb5-cd99df124867"), 70, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 1, null, 0m, "Mia", null },
                    { new Guid("4e1fa8ad-4819-49ef-bf64-0d20520f2d7e"), 8, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 1, null, 0m, "Olivia", null },
                    { new Guid("8ff3cba4-bab9-41c2-b990-a50fe59a4fc3"), 16, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 0, null, 0m, "Daniel", null },
                    { new Guid("94adffcc-fb7a-4f93-880f-0b8e14669f6a"), 17, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 1, null, 0m, "Sophie", null },
                    { new Guid("fda5dee7-e66d-45c6-bd45-d9756d0018e2"), 67, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 0, null, 0m, "James", null },
                    { new Guid("697cb4d9-6530-43d6-a0c3-a0d2ca7c3ebe"), 35, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 0, new Guid("3511646d-8567-46ad-9d05-74a2fac21f91"), 0m, "John", null },
                    { new Guid("6b1cdd4f-6e73-48f5-95db-a847e25234b5"), 22, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 0, new Guid("844ef091-c288-47f4-8edb-884cee07aaa6"), 0m, "Max", null },
                    { new Guid("6ca886ca-0033-434d-893b-1fd7d8272769"), 28, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 1, new Guid("9a201367-19cb-4cd7-a7e7-e20a1d7c1562"), 0m, "Anna", null },
                    { new Guid("cd4e25e2-c376-42f2-bfd1-679e19d9a55a"), 31, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 1, new Guid("b5631cc9-d4f2-4014-8f50-5c6f4d6cfe2f"), 0m, "Emma", null },
                    { new Guid("ff5c4db5-d6cb-4c79-a723-c9546edfdf4b"), 25, new Guid("f6a87de8-abd7-4bd0-a69c-ea5735e8a10e"), 0, new Guid("caf684c8-f8b3-42b9-83a1-ce99c66b6c06"), 0m, "Alex", null }
                });
        }
    }
}
