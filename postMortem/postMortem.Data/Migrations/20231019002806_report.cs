using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class report : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportReason",
                table: "Reports");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "95211fb3-ea0e-4760-afaf-eca8a5c605dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Moderator",
                column: "ConcurrencyStamp",
                value: "55dcfec5-5eff-455c-b6a2-f0c73186a903");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User",
                column: "ConcurrencyStamp",
                value: "4153adf0-c07c-4f1e-812b-20f19c06ca16");
        }
    }
}
