using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorToDoLab.Migrations
{
    public partial class hannes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aufgaben",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Erledigt = table.Column<bool>(nullable: false),
                    EditModus = table.Column<bool>(nullable: false),
                    Bearbeiter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aufgaben", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aufgaben");
        }
    }
}
