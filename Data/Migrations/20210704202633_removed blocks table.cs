using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomAllocation3.Data.Migrations
{
    public partial class removedblockstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Block_BlockID",
                table: "Room");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropIndex(
                name: "IX_Room_BlockID",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "BlockID",
                table: "Room");

            migrationBuilder.AddColumn<string>(
                name: "Block",
                table: "Room",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Block",
                table: "Room");

            migrationBuilder.AddColumn<int>(
                name: "BlockID",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    BlockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.BlockID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_BlockID",
                table: "Room",
                column: "BlockID");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Block_BlockID",
                table: "Room",
                column: "BlockID",
                principalTable: "Block",
                principalColumn: "BlockID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
