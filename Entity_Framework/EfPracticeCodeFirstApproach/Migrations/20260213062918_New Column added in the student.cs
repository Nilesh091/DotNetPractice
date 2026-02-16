using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfPracticeCodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnaddedinthestudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Students");
        }
    }
}
