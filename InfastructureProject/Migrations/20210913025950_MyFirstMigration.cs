using Microsoft.EntityFrameworkCore.Migrations;

namespace InfastructureProject.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tree",
                columns: table => new
                {
                    TreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeftTreeId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tree", x => x.TreeId);
                    table.ForeignKey(
                        name: "FK_Tree_Tree_LeftTreeId",
                        column: x => x.LeftTreeId,
                        principalTable: "Tree",
                        principalColumn: "TreeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tree_LeftTreeId",
                table: "Tree",
                column: "LeftTreeId",
                unique: true,
                filter: "[LeftTreeId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tree");
        }
    }
}
