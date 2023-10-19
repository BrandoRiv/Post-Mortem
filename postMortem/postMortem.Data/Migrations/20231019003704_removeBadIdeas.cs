using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class removeBadIdeas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportReason",
                table: "Reports");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "1662877f-0306-4434-bf23-d9255359bd62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Moderator",
                column: "ConcurrencyStamp",
                value: "1752a51c-768f-464c-8a1f-0de135bf413f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User",
                column: "ConcurrencyStamp",
                value: "e978810c-eaeb-4b10-9376-ed348be5a6b3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportReason",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "eb787c0e-d92e-40fe-bb51-225b971e6c43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Moderator",
                column: "ConcurrencyStamp",
                value: "6a69efa4-9649-4a59-bd67-d760fbb8f2d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User",
                column: "ConcurrencyStamp",
                value: "ee202775-4615-48f9-be6e-d955466623c0");
        }
    }
}
