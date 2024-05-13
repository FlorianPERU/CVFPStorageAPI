using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVFPDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateHardSkillsAndTypeAndAssociationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoLink",
                table: "SoftSkills",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "HardSkillType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkillType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HardSkillTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardSkills_HardSkillType_HardSkillTypeId",
                        column: x => x.HardSkillTypeId,
                        principalTable: "HardSkillType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssociationCandidatesHardSkills",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    HardSkillId = table.Column<int>(type: "int", nullable: false),
                    PositionHardSkill = table.Column<int>(type: "int", nullable: false),
                    PositionHardSkillType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociationCandidatesHardSkills", x => new { x.CandidateId, x.HardSkillId });
                    table.ForeignKey(
                        name: "FK_AssociationCandidatesHardSkills_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssociationCandidatesHardSkills_HardSkills_HardSkillId",
                        column: x => x.HardSkillId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssociationCandidatesHardSkills_HardSkillId",
                table: "AssociationCandidatesHardSkills",
                column: "HardSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_HardSkills_HardSkillTypeId",
                table: "HardSkills",
                column: "HardSkillTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssociationCandidatesHardSkills");

            migrationBuilder.DropTable(
                name: "HardSkills");

            migrationBuilder.DropTable(
                name: "HardSkillType");

            migrationBuilder.DropColumn(
                name: "LogoLink",
                table: "SoftSkills");
        }
    }
}
