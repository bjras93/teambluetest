using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInputs",
                columns: table => new
                {
                    DistinctText = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInputs", x => x.DistinctText);
                });

            migrationBuilder.CreateTable(
                name: "WatchListWords",
                columns: table => new
                {
                    Word = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchListWords", x => x.Word);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInputs_DistinctText",
                table: "UserInputs",
                column: "DistinctText",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WatchListWords_Word",
                table: "WatchListWords",
                column: "Word",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInputs");

            migrationBuilder.DropTable(
                name: "WatchListWords");
        }
    }
}
