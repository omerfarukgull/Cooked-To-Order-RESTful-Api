using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1eaaed38-a6cc-4bd0-8b04-6b4f815b9d14", "29853fcf-0ec2-40d6-bfc9-696ffe6a924d", "User", "USER" },
                    { "361e8eee-556c-46b0-8e08-fc05c73c9620", "e158159b-8306-4165-b4a9-a3670ad8577f", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eaaed38-a6cc-4bd0-8b04-6b4f815b9d14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "361e8eee-556c-46b0-8e08-fc05c73c9620");
        }
    }
}
