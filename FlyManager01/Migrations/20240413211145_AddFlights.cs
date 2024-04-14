using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlyManager01.Migrations
{
    /// <inheritdoc />
    public partial class AddFlights : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypePlane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberPlane = table.Column<int>(type: "int", nullable: false),
                    FromCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPilot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuisnessClass = table.Column<int>(type: "int", nullable: true),
                    PriceBuisness = table.Column<double>(type: "float", nullable: true),
                    OrdinaryTicket = table.Column<int>(type: "int", nullable: false),
                    Ticket = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
