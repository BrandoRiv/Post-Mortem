using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ban : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReferencedEntityId",
                table: "BannedUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BannedUsers_ReferencedEntityId",
                table: "BannedUsers",
                column: "ReferencedEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BannedUsers_InteractiveEntity_ReferencedEntityId",
                table: "BannedUsers",
                column: "ReferencedEntityId",
                principalTable: "InteractiveEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BannedUsers_InteractiveEntity_ReferencedEntityId",
                table: "BannedUsers");

            migrationBuilder.DropIndex(
                name: "IX_BannedUsers_ReferencedEntityId",
                table: "BannedUsers");

            migrationBuilder.DropColumn(
                name: "ReferencedEntityId",
                table: "BannedUsers");
        }
    }
}
