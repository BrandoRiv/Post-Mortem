using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class usersettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SettingsId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseDarkMode = table.Column<bool>(type: "bit", nullable: false),
                    ShowNSFWContent = table.Column<bool>(type: "bit", nullable: false),
                    PrivateAccount = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SettingsId",
                table: "AspNetUsers",
                column: "SettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserSettings_SettingsId",
                table: "AspNetUsers",
                column: "SettingsId",
                principalTable: "UserSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserSettings_SettingsId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SettingsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SettingsId",
                table: "AspNetUsers");
        }
    }
}
