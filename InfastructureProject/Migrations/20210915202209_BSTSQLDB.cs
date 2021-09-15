using Microsoft.EntityFrameworkCore.Migrations;

namespace InfastructureProject.Migrations
{
    public partial class BSTSQLDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tree",
                columns: table => new
                {
                    TreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RightId = table.Column<int>(type: "int", nullable: true),
                    LeftId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tree", x => x.TreeId);
                    table.ForeignKey(
                        name: "FK_Tree_Tree_LeftId",
                        column: x => x.LeftId,
                        principalTable: "Tree",
                        principalColumn: "TreeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tree_Tree_RightId",
                        column: x => x.RightId,
                        principalTable: "Tree",
                        principalColumn: "TreeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tree_LeftId",
                table: "Tree",
                column: "LeftId");

            migrationBuilder.CreateIndex(
                name: "IX_Tree_RightId",
                table: "Tree",
                column: "RightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tree");
        }
    }
}
