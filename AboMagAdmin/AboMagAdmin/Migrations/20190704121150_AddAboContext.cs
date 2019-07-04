using Microsoft.EntityFrameworkCore.Migrations;

namespace AboMagAdmin.Migrations
{
    public partial class AddAboContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonnement_Magazines_MagazineId",
                table: "Abonnement");

            migrationBuilder.DropForeignKey(
                name: "FK_Abonnement_AspNetUsers_UserId",
                table: "Abonnement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abonnement",
                table: "Abonnement");

            migrationBuilder.RenameTable(
                name: "Abonnement",
                newName: "Abonnements");

            migrationBuilder.RenameIndex(
                name: "IX_Abonnement_UserId",
                table: "Abonnements",
                newName: "IX_Abonnements_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abonnement_MagazineId",
                table: "Abonnements",
                newName: "IX_Abonnements_MagazineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abonnements",
                table: "Abonnements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonnements_Magazines_MagazineId",
                table: "Abonnements",
                column: "MagazineId",
                principalTable: "Magazines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abonnements_AspNetUsers_UserId",
                table: "Abonnements",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonnements_Magazines_MagazineId",
                table: "Abonnements");

            migrationBuilder.DropForeignKey(
                name: "FK_Abonnements_AspNetUsers_UserId",
                table: "Abonnements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abonnements",
                table: "Abonnements");

            migrationBuilder.RenameTable(
                name: "Abonnements",
                newName: "Abonnement");

            migrationBuilder.RenameIndex(
                name: "IX_Abonnements_UserId",
                table: "Abonnement",
                newName: "IX_Abonnement_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Abonnements_MagazineId",
                table: "Abonnement",
                newName: "IX_Abonnement_MagazineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abonnement",
                table: "Abonnement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonnement_Magazines_MagazineId",
                table: "Abonnement",
                column: "MagazineId",
                principalTable: "Magazines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abonnement_AspNetUsers_UserId",
                table: "Abonnement",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
