using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolcarZadanie.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaskCreationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "WorkTasks",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "WorkTasks");
        }
    }
}
