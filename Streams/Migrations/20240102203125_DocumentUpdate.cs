using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Streams.Migrations
{
    public partial class DocumentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Document",
                newName: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DocumentId",
                table: "Document",
                newName: "Id");
        }
    }
}
