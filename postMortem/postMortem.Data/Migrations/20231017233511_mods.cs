using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class mods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "498bdbf3-6cfb-4dce-961d-a97561c86624", "22accdf0-4424-44a7-afc7-f4a6cbc6561b", "User", "USER" },
                    { "74736d06-a48f-4aad-8c91-1d2efd3a2208", "0169ae09-5e61-4618-938a-4c8212431af0", "Admin", "ADMIN" },
                    { "79fcd6e2-cb00-4c91-a7b7-b8c639131d38", "7403a026-2fd4-4628-a119-d427a55108be", "Moderator", "MODERATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "498bdbf3-6cfb-4dce-961d-a97561c86624");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74736d06-a48f-4aad-8c91-1d2efd3a2208");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79fcd6e2-cb00-4c91-a7b7-b8c639131d38");
        }
    }
}
