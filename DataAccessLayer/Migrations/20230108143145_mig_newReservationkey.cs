using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_newReservationkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_DestinationId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "DestinationId",
                table: "Reservations",
                newName: "DestinationID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_DestinationId",
                table: "Reservations",
                newName: "IX_Reservations_DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_DestinationID",
                table: "Reservations",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_DestinationID",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "DestinationID",
                table: "Reservations",
                newName: "DestinationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_DestinationID",
                table: "Reservations",
                newName: "IX_Reservations_DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_DestinationId",
                table: "Reservations",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
