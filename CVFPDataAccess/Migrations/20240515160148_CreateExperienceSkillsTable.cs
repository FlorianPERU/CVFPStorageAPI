using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVFPDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateExperienceSkillsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExperienceSkills",
                columns: table => new
                {
                    Position = table.Column<int>(type: "int", nullable: false),
                    ExperienceId = table.Column<int>(type: "int", nullable: false),
                    SoftSkillId = table.Column<int>(type: "int", nullable: true),
                    HardSkillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceSkills", x => new { x.ExperienceId, x.Position });
                    table.ForeignKey(
                        name: "FK_ExperienceSkills_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceSkills_HardSkills_HardSkillId",
                        column: x => x.HardSkillId,
                        principalTable: "HardSkills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExperienceSkills_SoftSkills_SoftSkillId",
                        column: x => x.SoftSkillId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkills_HardSkillId",
                table: "ExperienceSkills",
                column: "HardSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceSkills_SoftSkillId",
                table: "ExperienceSkills",
                column: "SoftSkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienceSkills");
        }
    }
}
