using Microsoft.EntityFrameworkCore.Migrations;

namespace FileScannerApp.Migrations
{
    public partial class DeletedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullPath",
                table: "Folders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullPath",
                table: "Folders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
