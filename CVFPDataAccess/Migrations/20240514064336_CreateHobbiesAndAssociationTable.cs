using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVFPDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateHobbiesAndAssociationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociationCandidateHobbies",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    HobbieId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociationCandidateHobbies", x => new { x.CandidateId, x.HobbieId });
                    table.ForeignKey(
                        name: "FK_AssociationCandidateHobbies_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssociationCandidateHobbies_Hobbies_HobbieId",
                        column: x => x.HobbieId,
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociationCandidateHobbies_HobbieId",
                table: "AssociationCandidateHobbies",
                column: "HobbieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociationCandidateHobbies");

            migrationBuilder.DropTable(
                name: "Hobbies");
        }
    }
}
