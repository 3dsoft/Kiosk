using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateTime = table.Column<DateTime>(nullable: false),
                    paymentType = table.Column<string>(nullable: true),
                    totalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_PaymentLists_PaymentListId",
                table: "MenuItems");

            migrationBuilder.DropTable(
                name: "PaymentLists");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_PaymentListId",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "PaymentListId",
                table: "MenuItems");
        }
    }
}
