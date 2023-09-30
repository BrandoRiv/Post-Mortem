using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class entityNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_VoteableEntity_ToID",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_BannedUsers_AspNetUsers_BanUserId",
                table: "BannedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_UserId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_VoteableEntity_EntityID",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_AspNetUsers_PosterId",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_AspNetUsers_UserId",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_EntityID",
                table: "VoteableEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_AspNetUsers_UserId",
                table: "Votes");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_VoteableEntity_EntityID",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_EntityID",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_UserId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_BannedUsers_BanUserId",
                table: "BannedUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VoteableEntity",
                table: "VoteableEntity");

            migrationBuilder.DropColumn(
                name: "EntityID",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Archived",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "BanUserId",
                table: "BannedUsers");

            migrationBuilder.DropColumn(
                name: "Archived",
                table: "VoteableEntity");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "VoteableEntity");

            migrationBuilder.RenameTable(
                name: "VoteableEntity",
                newName: "InteractiveEntity");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reports",
                newName: "ReporterId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                newName: "IX_Reports_ReporterId");

            migrationBuilder.RenameColumn(
                name: "ToID",
                table: "Awards",
                newName: "RecipientID");

            migrationBuilder.RenameIndex(
                name: "IX_Awards_ToID",
                table: "Awards",
                newName: "IX_Awards_RecipientID");

            migrationBuilder.RenameColumn(
                name: "Comment_Message",
                table: "InteractiveEntity",
                newName: "Post_Message");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "InteractiveEntity",
                newName: "Post_OwnerId");

            migrationBuilder.RenameColumn(
                name: "PosterId",
                table: "InteractiveEntity",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "EntityID",
                table: "InteractiveEntity",
                newName: "ParentID");

            migrationBuilder.RenameIndex(
                name: "IX_VoteableEntity_UserId",
                table: "InteractiveEntity",
                newName: "IX_InteractiveEntity_Post_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_VoteableEntity_PosterId",
                table: "InteractiveEntity",
                newName: "IX_InteractiveEntity_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_VoteableEntity_EntityID",
                table: "InteractiveEntity",
                newName: "IX_InteractiveEntity_ParentID");

            migrationBuilder.AddColumn<int>(
                name: "RecipientID",
                table: "Votes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BannedUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Awards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "RecipientNotified",
                table: "Awards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "InteractiveEntity",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InteractiveEntity",
                table: "InteractiveEntity",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_RecipientID",
                table: "Votes",
                column: "RecipientID");

            migrationBuilder.CreateIndex(
                name: "IX_BannedUsers_UserId",
                table: "BannedUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_InteractiveEntity_RecipientID",
                table: "Awards",
                column: "RecipientID",
                principalTable: "InteractiveEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BannedUsers_AspNetUsers_UserId",
                table: "BannedUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InteractiveEntity_AspNetUsers_OwnerId",
                table: "InteractiveEntity",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_InteractiveEntity_AspNetUsers_Post_OwnerId",
                table: "InteractiveEntity",
                column: "Post_OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_InteractiveEntity_InteractiveEntity_ParentID",
                table: "InteractiveEntity",
                column: "ParentID",
                principalTable: "InteractiveEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_ReporterId",
                table: "Reports",
                column: "ReporterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_InteractiveEntity_EntityID",
                table: "Reports",
                column: "EntityID",
                principalTable: "InteractiveEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_InteractiveEntity_RecipientID",
                table: "Votes",
                column: "RecipientID",
                principalTable: "InteractiveEntity",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_InteractiveEntity_RecipientID",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_BannedUsers_AspNetUsers_UserId",
                table: "BannedUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_InteractiveEntity_AspNetUsers_OwnerId",
                table: "InteractiveEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_InteractiveEntity_AspNetUsers_Post_OwnerId",
                table: "InteractiveEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_InteractiveEntity_InteractiveEntity_ParentID",
                table: "InteractiveEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_ReporterId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_InteractiveEntity_EntityID",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_InteractiveEntity_RecipientID",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_RecipientID",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_BannedUsers_UserId",
                table: "BannedUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InteractiveEntity",
                table: "InteractiveEntity");

            migrationBuilder.DropColumn(
                name: "RecipientID",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BannedUsers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "RecipientNotified",
                table: "Awards");

            migrationBuilder.RenameTable(
                name: "InteractiveEntity",
                newName: "VoteableEntity");

            migrationBuilder.RenameColumn(
                name: "ReporterId",
                table: "Reports",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ReporterId",
                table: "Reports",
                newName: "IX_Reports_UserId");

            migrationBuilder.RenameColumn(
                name: "RecipientID",
                table: "Awards",
                newName: "ToID");

            migrationBuilder.RenameIndex(
                name: "IX_Awards_RecipientID",
                table: "Awards",
                newName: "IX_Awards_ToID");

            migrationBuilder.RenameColumn(
                name: "Post_Message",
                table: "VoteableEntity",
                newName: "Comment_Message");

            migrationBuilder.RenameColumn(
                name: "Post_OwnerId",
                table: "VoteableEntity",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "VoteableEntity",
                newName: "EntityID");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "VoteableEntity",
                newName: "PosterId");

            migrationBuilder.RenameIndex(
                name: "IX_InteractiveEntity_Post_OwnerId",
                table: "VoteableEntity",
                newName: "IX_VoteableEntity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_InteractiveEntity_ParentID",
                table: "VoteableEntity",
                newName: "IX_VoteableEntity_EntityID");

            migrationBuilder.RenameIndex(
                name: "IX_InteractiveEntity_OwnerId",
                table: "VoteableEntity",
                newName: "IX_VoteableEntity_PosterId");

            migrationBuilder.AddColumn<int>(
                name: "EntityID",
                table: "Votes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Votes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Archived",
                table: "Reports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Reports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BanUserId",
                table: "BannedUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "VoteableEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Archived",
                table: "VoteableEntity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "VoteableEntity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VoteableEntity",
                table: "VoteableEntity",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_EntityID",
                table: "Votes",
                column: "EntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BannedUsers_BanUserId",
                table: "BannedUsers",
                column: "BanUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_VoteableEntity_ToID",
                table: "Awards",
                column: "ToID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BannedUsers_AspNetUsers_BanUserId",
                table: "BannedUsers",
                column: "BanUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_UserId",
                table: "Reports",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_VoteableEntity_EntityID",
                table: "Reports",
                column: "EntityID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_AspNetUsers_PosterId",
                table: "VoteableEntity",
                column: "PosterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_AspNetUsers_UserId",
                table: "VoteableEntity",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoteableEntity_VoteableEntity_EntityID",
                table: "VoteableEntity",
                column: "EntityID",
                principalTable: "VoteableEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_AspNetUsers_UserId",
                table: "Votes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
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
