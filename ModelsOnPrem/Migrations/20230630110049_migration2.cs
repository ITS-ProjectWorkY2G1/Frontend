using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelsOnPrem.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pw_gruppo1");

            migrationBuilder.CreateTable(
                name: "smartwatches",
                schema: "pw_gruppo1",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    buying_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    production_batch = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_smartwatches", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "smartwatches",
                schema: "pw_gruppo1");
        }
    }
}
