using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbClinic.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PersonalData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnamnesisDesise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnamnesisLife = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectStatus = table.Column<bool>(type: "bit", nullable: false),
                    PlanSurvey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanTherapy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
