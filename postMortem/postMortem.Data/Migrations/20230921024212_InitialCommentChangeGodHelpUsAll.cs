using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommentChangeGodHelpUsAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Users_FromID",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_Awards_VoteableEntity_ToID",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_BannedUsers_Users_UserID",
                table: "BannedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_UserID",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_VoteableEntity_EntityID",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_Users_PosterID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_Users_UserID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_ParentID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_PostID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_VoteableEntity_EntityID",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_VoteableEntity_ParentID",
                table: "VoteableEntity");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "VoteableEntity");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "VoteableEntity",
                newName: "EntityID");

            migrationBuilder.RenameIndex(
                name: "IX_VoteableEntity_PostID",
                table: "VoteableEntity",
                newName: "IX_VoteableEntity_EntityID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Votes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EntityID",
                table: "Votes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Reports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EntityID",
                table: "Reports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "BannedUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ToID",
                table: "Awards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FromID",
                table: "Awards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Users_FromID",
                table: "Awards",
                column: "FromID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_VoteableEntity_ToID",
                table: "Awards",
                column: "ToID",
                principalTable: "VoteableEntity",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BannedUsers_Users_UserID",
                table: "BannedUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_UserID",
                table: "Reports",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_VoteableEntity_EntityID",
                table: "Reports",
                column: "EntityID",
                principalTable: "VoteableEntity",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_Users_PosterID",
                table: "VoteableEntity",
                column: "PosterID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_Users_UserID",
                table: "VoteableEntity",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_EntityID",
                table: "VoteableEntity",
                column: "EntityID",
                principalTable: "VoteableEntity",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_VoteableEntity_EntityID",
                table: "Votes",
                column: "EntityID",
                principalTable: "VoteableEntity",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Users_FromID",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_Awards_VoteableEntity_ToID",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_BannedUsers_Users_UserID",
                table: "BannedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_UserID",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_VoteableEntity_EntityID",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_Users_PosterID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_Users_UserID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_EntityID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_VoteableEntity_EntityID",
                table: "Votes");

            migrationBuilder.RenameColumn(
                name: "EntityID",
                table: "VoteableEntity",
                newName: "PostID");

            migrationBuilder.RenameIndex(
                name: "IX_VoteableEntity_EntityID",
                table: "VoteableEntity",
                newName: "IX_VoteableEntity_PostID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Votes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntityID",
                table: "Votes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentID",
                table: "VoteableEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntityID",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "BannedUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ToID",
                table: "Awards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FromID",
                table: "Awards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoteableEntity_ParentID",
                table: "VoteableEntity",
                column: "ParentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Users_FromID",
                table: "Awards",
                column: "FromID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_VoteableEntity_ToID",
                table: "Awards",
                column: "ToID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BannedUsers_Users_UserID",
                table: "BannedUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_UserID",
                table: "Reports",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_VoteableEntity_EntityID",
                table: "Reports",
                column: "EntityID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_Users_PosterID",
                table: "VoteableEntity",
                column: "PosterID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_Users_UserID",
                table: "VoteableEntity",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_ParentID",
                table: "VoteableEntity",
                column: "ParentID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_PostID",
                table: "VoteableEntity",
                column: "PostID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_VoteableEntity_EntityID",
                table: "Votes",
                column: "EntityID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
