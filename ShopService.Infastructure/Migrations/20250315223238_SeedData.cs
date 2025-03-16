using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderProducts");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

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

            migrationBuilder.RenameTable(
                name: "OrderProducts",
                newName: "OrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderItems",
                newName: "IX_OrderItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
