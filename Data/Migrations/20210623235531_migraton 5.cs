using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomAllocation3.Data.Migrations
{
    public partial class migraton5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Periods",
                table: "Periods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blocks",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "TeacherCode",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameTable(
                name: "Periods",
                newName: "Period");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "Blocks",
                newName: "Block");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_BlockID",
                table: "Room",
                newName: "IX_Room_BlockID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_RoomID",
                table: "Booking",
                newName: "IX_Booking_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_PeriodID",
                table: "Booking",
                newName: "IX_Booking_PeriodID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_DayOfTheWeekID",
                table: "Booking",
                newName: "IX_Booking_DayOfTheWeekID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_CourseID",
                table: "Booking",
                newName: "IX_Booking_CourseID");

            migrationBuilder.AlterColumn<int>(
                name: "RoomNumber",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherCode",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearLevel",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Period",
                table: "Period",
                column: "PeriodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Block",
                table: "Block",
                column: "BlockID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Course_CourseID",
                table: "Booking",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Room_RoomID",
                table: "Booking",
                column: "RoomID",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Block_BlockID",
                table: "Room",
                column: "BlockID",
                principalTable: "Block",
                principalColumn: "BlockID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Course_CourseID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_DayOfTheWeek_DayOfTheWeekID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Period_PeriodID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_RoomID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Block_BlockID",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Period",
                table: "Period");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Block",
                table: "Block");

            migrationBuilder.DropColumn(
                name: "TeacherCode",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "YearLevel",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "Period",
                newName: "Periods");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "Block",
                newName: "Blocks");

            migrationBuilder.RenameIndex(
                name: "IX_Room_BlockID",
                table: "Rooms",
                newName: "IX_Rooms_BlockID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_RoomID",
                table: "Bookings",
                newName: "IX_Bookings_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_PeriodID",
                table: "Bookings",
                newName: "IX_Bookings_PeriodID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_DayOfTheWeekID",
                table: "Bookings",
                newName: "IX_Bookings_DayOfTheWeekID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_CourseID",
                table: "Bookings",
                newName: "IX_Bookings_CourseID");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "TeacherCode",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Periods",
                table: "Periods",
                column: "PeriodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blocks",
                table: "Blocks",
                column: "BlockID");

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
    }
}
