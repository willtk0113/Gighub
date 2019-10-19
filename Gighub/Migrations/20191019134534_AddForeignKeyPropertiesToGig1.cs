using Microsoft.EntityFrameworkCore.Migrations;

namespace Gighub.Migrations
{
    public partial class AddForeignKeyPropertiesToGig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_AspNetUsers_ArtistId1",
                table: "Gigs");

            migrationBuilder.DropIndex(
                name: "IX_Gigs_ArtistId1",
                table: "Gigs");

            migrationBuilder.DropColumn(
                name: "ArtistId1",
                table: "Gigs");

            migrationBuilder.AlterColumn<string>(
                name: "ArtistId",
                table: "Gigs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Gigs_ArtistId",
                table: "Gigs",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_AspNetUsers_ArtistId",
                table: "Gigs",
                column: "ArtistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_AspNetUsers_ArtistId",
                table: "Gigs");

            migrationBuilder.DropIndex(
                name: "IX_Gigs_ArtistId",
                table: "Gigs");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Gigs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ArtistId1",
                table: "Gigs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gigs_ArtistId1",
                table: "Gigs",
                column: "ArtistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_AspNetUsers_ArtistId1",
                table: "Gigs",
                column: "ArtistId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
