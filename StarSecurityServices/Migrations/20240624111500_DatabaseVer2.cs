using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarSecurityServices.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseVer2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "NVARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");
        }
    }
}
