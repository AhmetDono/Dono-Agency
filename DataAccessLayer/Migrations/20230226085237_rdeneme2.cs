using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class rdeneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Agents_AgentID",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "AgentID",
                table: "Properties",
                newName: "AgentRefID");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_AgentID",
                table: "Properties",
                newName: "IX_Properties_AgentRefID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Agents_AgentRefID",
                table: "Properties",
                column: "AgentRefID",
                principalTable: "Agents",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Agents_AgentRefID",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "AgentRefID",
                table: "Properties",
                newName: "AgentID");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_AgentRefID",
                table: "Properties",
                newName: "IX_Properties_AgentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Agents_AgentID",
                table: "Properties",
                column: "AgentID",
                principalTable: "Agents",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
