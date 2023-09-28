using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace postMortem.Data.Migrations
{
    /// <inheritdoc />
    public partial class tags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_InteractiveEntity_RecipientID",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_InteractiveEntity_InteractiveEntity_ParentID",
                table: "InteractiveEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_InteractiveEntity_EntityID",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_InteractiveEntity_RecipientID",
                table: "Votes");

            migrationBuilder.RenameColumn(
                name: "RecipientID",
                table: "Votes",
                newName: "RecipientId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Votes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Votes_RecipientID",
                table: "Votes",
                newName: "IX_Votes_RecipientId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Subscriptions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EntityID",
                table: "Reports",
                newName: "EntityId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Reports",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_EntityID",
                table: "Reports",
                newName: "IX_Reports_EntityId");

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "InteractiveEntity",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "InteractiveEntity",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_InteractiveEntity_ParentID",
                table: "InteractiveEntity",
                newName: "IX_InteractiveEntity_ParentId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "BannedUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RecipientID",
                table: "Awards",
                newName: "RecipientId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Awards",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Awards_RecipientID",
                table: "Awards",
                newName: "IX_Awards_RecipientId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "InteractiveEntity",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_InteractiveEntity_RecipientId",
                table: "Awards",
                column: "RecipientId",
                principalTable: "InteractiveEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_InteractiveEntity_InteractiveEntity_ParentId",
                table: "InteractiveEntity",
                column: "ParentId",
                principalTable: "InteractiveEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_InteractiveEntity_EntityId",
                table: "Reports",
                column: "EntityId",
                principalTable: "InteractiveEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_InteractiveEntity_RecipientId",
                table: "Votes",
                column: "RecipientId",
                principalTable: "InteractiveEntity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_InteractiveEntity_RecipientId",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_InteractiveEntity_InteractiveEntity_ParentId",
                table: "InteractiveEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_InteractiveEntity_EntityId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_InteractiveEntity_RecipientId",
                table: "Votes");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.RenameColumn(
                name: "RecipientId",
                table: "Votes",
                newName: "RecipientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Votes",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Votes_RecipientId",
                table: "Votes",
                newName: "IX_Votes_RecipientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subscriptions",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "EntityId",
                table: "Reports",
                newName: "EntityID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reports",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_EntityId",
                table: "Reports",
                newName: "IX_Reports_EntityID");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "InteractiveEntity",
                newName: "ParentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InteractiveEntity",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_InteractiveEntity_ParentId",
                table: "InteractiveEntity",
                newName: "IX_InteractiveEntity_ParentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BannedUsers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RecipientId",
                table: "Awards",
                newName: "RecipientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Awards",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Awards_RecipientId",
                table: "Awards",
                newName: "IX_Awards_RecipientID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "InteractiveEntity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_InteractiveEntity_RecipientID",
                table: "Awards",
                column: "RecipientID",
                principalTable: "InteractiveEntity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InteractiveEntity_InteractiveEntity_ParentID",
                table: "InteractiveEntity",
                column: "ParentID",
                principalTable: "InteractiveEntity",
                principalColumn: "ID",
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
    }
}
