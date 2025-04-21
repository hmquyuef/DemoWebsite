using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebsite.Migrations
{
    /// <inheritdoc />
    public partial class editTableSinhVien_SoDienThoai_Delete_Email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "SinhViens");

            migrationBuilder.RenameColumn(
                name: "SDT",
                table: "SinhViens",
                newName: "SoDienThoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "SinhViens",
                newName: "SDT");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SinhViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
