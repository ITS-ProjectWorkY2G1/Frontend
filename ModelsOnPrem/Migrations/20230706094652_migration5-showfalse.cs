using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelsOnPrem.Migrations
{
    /// <inheritdoc />
    public partial class migration5showfalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "show",
                schema: "pw_gruppo1",
                table: "smartwatches",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "show",
                schema: "pw_gruppo1",
                table: "smartwatches");
        }
    }
}
