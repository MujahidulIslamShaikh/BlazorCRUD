using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCRUD.API.Migrations
{
    /// <inheritdoc />
    public partial class addPhonetoEmp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "tbl_Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "tbl_Employee");
        }
    }
}
