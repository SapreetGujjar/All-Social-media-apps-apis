using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace All_Social_media_apps_apis.Migrations
{
    /// <inheritdoc />
    public partial class UpadateTableGmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sender",
                table: "Gmails",
                newName: "To");

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Gmails",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Gmails");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "Gmails",
                newName: "Sender");
        }
    }
}
