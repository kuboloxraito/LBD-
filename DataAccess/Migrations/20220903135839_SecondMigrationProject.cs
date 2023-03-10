using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SecondMigrationProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "rating");

            migrationBuilder.AddColumn<bool>(
                name: "IsRecommended",
                table: "recomendation",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRecommended",
                table: "recomendation");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "rating",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}