using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VarPlugApi.Migrations
{
    public partial class ProvinceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "universities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "province",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_province", x => x.ProvinceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_universities_ProvinceId",
                table: "universities",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_universities_province_ProvinceId",
                table: "universities",
                column: "ProvinceId",
                principalTable: "province",
                principalColumn: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_universities_province_ProvinceId",
                table: "universities");

            migrationBuilder.DropTable(
                name: "province");

            migrationBuilder.DropIndex(
                name: "IX_universities_ProvinceId",
                table: "universities");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "universities");
        }
    }
}
