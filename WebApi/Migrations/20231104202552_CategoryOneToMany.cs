using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class CategoryOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a97f4a3-e465-4679-9871-7c6ca2539d24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5d5676c-3c86-4a83-a8c5-d97df67c903d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "000eb2d6-4b96-421e-b977-ff5ad21c1763", "3851079a-8cd4-40d6-9938-61c3de4cac85", "User", "USER" },
                    { "e2e70518-a0a9-482f-9ea1-bb7aa9760128", "c8a2799b-27a2-47ac-befe-03205d135f11", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "000eb2d6-4b96-421e-b977-ff5ad21c1763");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2e70518-a0a9-482f-9ea1-bb7aa9760128");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a97f4a3-e465-4679-9871-7c6ca2539d24", "71494e75-cb29-4ec9-9698-e44194b9d7f1", "User", "USER" },
                    { "c5d5676c-3c86-4a83-a8c5-d97df67c903d", "8d371a01-733e-45bf-9363-9cb0617d7285", "Admin", "ADMIN" }
                });
        }
    }
}
