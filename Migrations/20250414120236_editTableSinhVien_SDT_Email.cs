using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebsite.Migrations
{
    /// <inheritdoc />
    public partial class editTableSinhVien_SDT_Email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SinhViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SDT",
                table: "SinhViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "SinhViens");

            migrationBuilder.DropColumn(
                name: "SDT",
                table: "SinhViens");
        }
    }
}
