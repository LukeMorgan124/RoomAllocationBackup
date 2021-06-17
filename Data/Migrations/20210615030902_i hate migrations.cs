using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomAllocation3.Data.Migrations
{
    public partial class ihatemigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blocks_Blocks_BlockID1",
                table: "Blocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Bookings_BookingID1",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Rooms_RoomID1",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomID1",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_BookingID1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Blocks_BlockID1",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "RoomID1",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "BookingID1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DayOfWeekID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BlockID1",
                table: "Blocks");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Bookings",
                newName: "DayOfTheWeekID");

            migrationBuilder.AddColumn<string>(
                name: "TeacherCode",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BlockID",
                table: "Rooms",
                column: "BlockID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CourseID",
                table: "Bookings",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DayOfTheWeekID",
                table: "Bookings",
                column: "DayOfTheWeekID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PeriodID",
                table: "Bookings",
                column: "PeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomID",
                table: "Bookings",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Courses_CourseID",
                table: "Bookings",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_DayOfTheWeek_DayOfTheWeekID",
                table: "Bookings",
                column: "DayOfTheWeekID",
                principalTable: "DayOfTheWeek",
                principalColumn: "DayOfTheWeekID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Periods_PeriodID",
                table: "Bookings",
                column: "PeriodID",
                principalTable: "Periods",
                principalColumn: "PeriodID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rooms_RoomID",
                table: "Bookings",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Blocks_BlockID",
                table: "Rooms",
                column: "BlockID",
                principalTable: "Blocks",
                principalColumn: "BlockID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Courses_CourseID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_DayOfTheWeek_DayOfTheWeekID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Periods_PeriodID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Rooms_RoomID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Blocks_BlockID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_BlockID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CourseID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DayOfTheWeekID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PeriodID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_RoomID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TeacherCode",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "DayOfTheWeekID",
                table: "Bookings",
                newName: "TeacherID");

            migrationBuilder.AddColumn<int>(
                name: "RoomID1",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingID1",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekID",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlockID1",
                table: "Blocks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomID1",
                table: "Rooms",
                column: "RoomID1");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingID1",
                table: "Bookings",
                column: "BookingID1");

            migrationBuilder.CreateIndex(
                name: "IX_Blocks_BlockID1",
                table: "Blocks",
                column: "BlockID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Blocks_Blocks_BlockID1",
                table: "Blocks",
                column: "BlockID1",
                principalTable: "Blocks",
                principalColumn: "BlockID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Bookings_BookingID1",
                table: "Bookings",
                column: "BookingID1",
                principalTable: "Bookings",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Rooms_RoomID1",
                table: "Rooms",
                column: "RoomID1",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
