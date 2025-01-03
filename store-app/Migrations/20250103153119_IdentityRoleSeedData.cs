using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace store_app.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "359b3d94-38b5-4cd9-9710-dae52201bd47", null, "User", "USER" },
                    { "70e1d4e8-f265-46e5-ba92-5fe70685d292", null, "Admin", "ADMIN" },
                    { "db5d8d57-1414-4f1e-ac09-e672d629db98", null, "Editor", "EDITOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "359b3d94-38b5-4cd9-9710-dae52201bd47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70e1d4e8-f265-46e5-ba92-5fe70685d292");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db5d8d57-1414-4f1e-ac09-e672d629db98");
        }
    }
}
