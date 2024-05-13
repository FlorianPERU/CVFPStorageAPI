using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVFPDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateSoftSkillsAndAssocoationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoftSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociationCandidatesSoftSkills",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    SoftSkillId = table.Column<int>(type: "int", nullable: false),
                    SkillMasteryPercentage = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociationCandidatesSoftSkills", x => new { x.CandidateId, x.SoftSkillId });
                    table.ForeignKey(
                        name: "FK_AssociationCandidatesSoftSkills_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssociationCandidatesSoftSkills_SoftSkills_SoftSkillId",
                        column: x => x.SoftSkillId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociationCandidatesSoftSkills_SoftSkillId",
                table: "AssociationCandidatesSoftSkills",
                column: "SoftSkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociationCandidatesSoftSkills");

            migrationBuilder.DropTable(
                name: "SoftSkills");
        }
    }
}
