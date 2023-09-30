using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class tagChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GiverId",
                table: "Votes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_GiverId",
                table: "Votes",
                column: "GiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_AspNetUsers_GiverId",
                table: "Votes",
                column: "GiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_AspNetUsers_GiverId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_GiverId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "GiverId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tags");
        }
    }
}
