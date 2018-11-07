using Microsoft.EntityFrameworkCore.Migrations;

namespace Estimator.Migrations
{
    public partial class AddDataStructureFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoryId",
                table: "Features",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Features_StoryId",
                table: "Features",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Stories_StoryId",
                table: "Features",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Stories_StoryId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_StoryId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "StoryId",
                table: "Features");
        }
    }
}
