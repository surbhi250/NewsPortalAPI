using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Migrations
{
    public partial class NewsSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HLine = table.Column<string>(nullable: false),
                    NDetails = table.Column<string>(nullable: false),
                    NCity = table.Column<string>(nullable: false),
                    NDate = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
