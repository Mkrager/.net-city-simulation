using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitySimulation.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRestrictDeleteBehaviorPersonToPartner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PartnerId",
                table: "Persons",
                column: "PartnerId",
                unique: true,
                filter: "[PartnerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_PartnerId",
                table: "Persons",
                column: "PartnerId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
    }
}
