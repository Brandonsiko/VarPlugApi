using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VarPlugApi.Migrations
{
    public partial class finalMigrationCareer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_universities_UniversityId",
                table: "Faculty");

            migrationBuilder.DropForeignKey(
                name: "FK_universities_province_ProvinceId",
                table: "universities");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "universities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "career",
                columns: table => new
                {
                    Career_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Career_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_career", x => x.Career_Id);
                });

            migrationBuilder.CreateTable(
                name: "CareerFaculty",
                columns: table => new
                {
                    CareerId = table.Column<int>(type: "int", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerFaculty", x => new { x.CareerId, x.FacultyId });
                    table.ForeignKey(
                        name: "FK_CareerFaculty_career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "career",
                        principalColumn: "Career_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerFaculty_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareerUniverities",
                columns: table => new
                {
                    CareerId = table.Column<int>(type: "int", nullable: false),
                    UniversityId = table.Column<int>(type: "int", nullable: false),
                    CareerUniversityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerUniverities", x => new { x.CareerId, x.UniversityId });
                    table.ForeignKey(
                        name: "FK_CareerUniverities_career_CareerId",
                        column: x => x.CareerId,
                        principalTable: "career",
                        principalColumn: "Career_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CareerUniverities_universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "universities",
                        principalColumn: "UNI_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareerFaculty_FacultyId",
                table: "CareerFaculty",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_CareerUniverities_UniversityId",
                table: "CareerUniverities",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_universities_UniversityId",
                table: "Faculty",
                column: "UniversityId",
                principalTable: "universities",
                principalColumn: "UNI_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_universities_province_ProvinceId",
                table: "universities",
                column: "ProvinceId",
                principalTable: "province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_universities_UniversityId",
                table: "Faculty");

            migrationBuilder.DropForeignKey(
                name: "FK_universities_province_ProvinceId",
                table: "universities");

            migrationBuilder.DropTable(
                name: "CareerFaculty");

            migrationBuilder.DropTable(
                name: "CareerUniverities");

            migrationBuilder.DropTable(
                name: "career");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "universities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_universities_UniversityId",
                table: "Faculty",
                column: "UniversityId",
                principalTable: "universities",
                principalColumn: "UNI_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_universities_province_ProvinceId",
                table: "universities",
                column: "ProvinceId",
                principalTable: "province",
                principalColumn: "ProvinceId");
        }
    }
}
