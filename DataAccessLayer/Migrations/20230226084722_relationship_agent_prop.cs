using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class relationship_agent_prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentID",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentID",
                table: "Properties",
                column: "AgentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Agents_AgentID",
                table: "Properties",
                column: "AgentID",
                principalTable: "Agents",
                principalColumn: "AgentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Agents_AgentID",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_AgentID",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "AgentID",
                table: "Properties");
        }
    }
}
