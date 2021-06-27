using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomAllocation3.Data.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherCode",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TeacherID",
                table: "Booking",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Teacher_TeacherID",
                table: "Booking",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Teacher_TeacherID",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TeacherID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "TeacherCode",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
