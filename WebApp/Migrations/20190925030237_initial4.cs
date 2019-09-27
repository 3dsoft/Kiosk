using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_PaymentLists_PaymentListId",
                table: "MenuItems");

            migrationBuilder.DropTable(
                name: "PaymentLists");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_PaymentListId",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "PaymentListId",
                table: "MenuItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentListId",
                table: "MenuItems",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentLists", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_PaymentListId",
                table: "MenuItems",
                column: "PaymentListId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_PaymentLists_PaymentListId",
                table: "MenuItems",
                column: "PaymentListId",
                principalTable: "PaymentLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
