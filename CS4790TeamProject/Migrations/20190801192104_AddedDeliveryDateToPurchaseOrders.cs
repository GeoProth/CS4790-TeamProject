using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CS4790TeamProject.Migrations
{
    public partial class AddedDeliveryDateToPurchaseOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "PurchaseOrder",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "PurchaseOrder");

        }
    }
}
