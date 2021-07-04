using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomAllocation3.Data.Migrations
{
    public partial class removedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_DayOfTheWeek_DayOfTheWeekID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Period_PeriodID",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "DayOfTheWeek");

            migrationBuilder.DropTable(
                name: "Period");

            migrationBuilder.DropIndex(
                name: "IX_Booking_DayOfTheWeekID",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_PeriodID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "DayOfTheWeekID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "PeriodID",
                table: "Booking");

            migrationBuilder.AddColumn<bool>(
                name: "Booked",
                table: "Booking",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Period",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Booked",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "DayOfTheWeekID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PeriodID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DayOfTheWeek",
                columns: table => new
                {
                    DayOfTheWeekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfTheWeekName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOfTheWeek", x => x.DayOfTheWeekID);
                });

            migrationBuilder.CreateTable(
                name: "Period",
                columns: table => new
                {
                    PeriodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Period", x => x.PeriodID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_DayOfTheWeekID",
                table: "Booking",
                column: "DayOfTheWeekID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_PeriodID",
                table: "Booking",
                column: "PeriodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_DayOfTheWeek_DayOfTheWeekID",
                table: "Booking",
                column: "DayOfTheWeekID",
                principalTable: "DayOfTheWeek",
                principalColumn: "DayOfTheWeekID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Period_PeriodID",
                table: "Booking",
                column: "PeriodID",
                principalTable: "Period",
                principalColumn: "PeriodID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
