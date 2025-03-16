using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("0ea15258-d93e-49a2-bb2d-971fed390632"));

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("358d551f-0fcb-4f98-a096-eca9433590cf"));

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("f9a11259-9772-40be-b451-a5f0187332b2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7de93e70-d4dc-474a-9059-3ed98db54534"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("adfb0e4a-e34a-433c-ac8b-65c598438ee9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d802f1d-6e59-4b0c-99df-8ab2eeaf76b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0890c08-5227-480a-bee0-d392f47c53ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d29bc0fb-440f-42a2-893c-4abab533337f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1267ed85-cfad-4296-bce0-966a9365606c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7256e029-349d-491b-890d-e02d0223c0ab"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Category", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("906d2c38-92be-4d31-a900-d5e72cfbff76"), "ASUS-1234", "Електроніка", "Ноутбук ASUS", 25000.0 },
                    { new Guid("969e9845-9cb4-4f18-9f87-aaa287a26028"), "SAMS-5678", "Електроніка", "Смартфон Samsung", 18000.0 },
                    { new Guid("d100d97d-db37-4b64-9e17-686dcbe335c7"), "LG-91011", "Техніка для дому", "Мікрохвильова піч LG", 7000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "FullName" },
                values: new object[,]
                {
                    { new Guid("4a516000-ff9d-4e6f-97b5-25f1cf5d675b"), new DateTime(2025, 3, 15, 22, 33, 58, 940, DateTimeKind.Utc).AddTicks(4447), new DateOnly(1990, 5, 15), "Петренко Петро Петрович" },
                    { new Guid("c7231e28-8144-4451-b0d2-24a8b957c91d"), new DateTime(2025, 3, 15, 22, 33, 58, 940, DateTimeKind.Utc).AddTicks(4574), new DateOnly(1985, 10, 20), "Іваненко Іван Іванович" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("c3d515c6-4826-4965-811c-4042301460ea"), new Guid("c7231e28-8144-4451-b0d2-24a8b957c91d"), new DateTime(2025, 3, 15, 22, 33, 58, 941, DateTimeKind.Utc).AddTicks(688), 43000.0 },
                    { new Guid("f239a9d6-ce7a-4fb0-b02d-4e20fe11db7f"), new Guid("4a516000-ff9d-4e6f-97b5-25f1cf5d675b"), new DateTime(2025, 3, 15, 22, 33, 58, 941, DateTimeKind.Utc).AddTicks(337), 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("a8d0f2ef-b6a0-41e3-a843-73fcebd784d9"), new Guid("f239a9d6-ce7a-4fb0-b02d-4e20fe11db7f"), new Guid("d100d97d-db37-4b64-9e17-686dcbe335c7"), 1 },
                    { new Guid("bec3964d-a23c-41c2-9e49-1c3877299da0"), new Guid("f239a9d6-ce7a-4fb0-b02d-4e20fe11db7f"), new Guid("906d2c38-92be-4d31-a900-d5e72cfbff76"), 1 },
                    { new Guid("e73f76ec-a64f-43e2-8b6e-abac7790000d"), new Guid("c3d515c6-4826-4965-811c-4042301460ea"), new Guid("969e9845-9cb4-4f18-9f87-aaa287a26028"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("a8d0f2ef-b6a0-41e3-a843-73fcebd784d9"));

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("bec3964d-a23c-41c2-9e49-1c3877299da0"));

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: new Guid("e73f76ec-a64f-43e2-8b6e-abac7790000d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c3d515c6-4826-4965-811c-4042301460ea"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f239a9d6-ce7a-4fb0-b02d-4e20fe11db7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("906d2c38-92be-4d31-a900-d5e72cfbff76"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("969e9845-9cb4-4f18-9f87-aaa287a26028"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d100d97d-db37-4b64-9e17-686dcbe335c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a516000-ff9d-4e6f-97b5-25f1cf5d675b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7231e28-8144-4451-b0d2-24a8b957c91d"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "Category", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("7d802f1d-6e59-4b0c-99df-8ab2eeaf76b7"), "SAMS-5678", "Електроніка", "Смартфон Samsung", 18000.0 },
                    { new Guid("d0890c08-5227-480a-bee0-d392f47c53ec"), "LG-91011", "Техніка для дому", "Мікрохвильова піч LG", 7000.0 },
                    { new Guid("d29bc0fb-440f-42a2-893c-4abab533337f"), "ASUS-1234", "Електроніка", "Ноутбук ASUS", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "FullName" },
                values: new object[,]
                {
                    { new Guid("1267ed85-cfad-4296-bce0-966a9365606c"), new DateTime(2025, 3, 15, 22, 32, 38, 349, DateTimeKind.Utc).AddTicks(3448), new DateOnly(1990, 5, 15), "Петренко Петро Петрович" },
                    { new Guid("7256e029-349d-491b-890d-e02d0223c0ab"), new DateTime(2025, 3, 15, 22, 32, 38, 349, DateTimeKind.Utc).AddTicks(3640), new DateOnly(1985, 10, 20), "Іваненко Іван Іванович" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("7de93e70-d4dc-474a-9059-3ed98db54534"), new Guid("1267ed85-cfad-4296-bce0-966a9365606c"), new DateTime(2025, 3, 15, 22, 32, 38, 350, DateTimeKind.Utc).AddTicks(3466), 25000.0 },
                    { new Guid("adfb0e4a-e34a-433c-ac8b-65c598438ee9"), new Guid("7256e029-349d-491b-890d-e02d0223c0ab"), new DateTime(2025, 3, 15, 22, 32, 38, 350, DateTimeKind.Utc).AddTicks(3740), 43000.0 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0ea15258-d93e-49a2-bb2d-971fed390632"), new Guid("7de93e70-d4dc-474a-9059-3ed98db54534"), new Guid("d0890c08-5227-480a-bee0-d392f47c53ec"), 1 },
                    { new Guid("358d551f-0fcb-4f98-a096-eca9433590cf"), new Guid("7de93e70-d4dc-474a-9059-3ed98db54534"), new Guid("d29bc0fb-440f-42a2-893c-4abab533337f"), 1 },
                    { new Guid("f9a11259-9772-40be-b451-a5f0187332b2"), new Guid("adfb0e4a-e34a-433c-ac8b-65c598438ee9"), new Guid("7d802f1d-6e59-4b0c-99df-8ab2eeaf76b7"), 1 }
                });
        }
    }
}
