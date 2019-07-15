using Microsoft.EntityFrameworkCore.Migrations;

namespace CS4790TeamProject.Data.Migrations
{
    public partial class AddedForeignKeyConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Reconciled",
                table: "InventoryLog",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeLine_AssemblyRecipeID",
                table: "RecipeLine",
                column: "AssemblyRecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeLine_ItemID",
                table: "RecipeLine",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_RecievedItems_OrderItemID",
                table: "RecievedItems",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_VendorID",
                table: "PurchaseOrder",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ItemID",
                table: "OrderItem",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_PurchaseOrderID",
                table: "OrderItem",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLog_ItemID",
                table: "InventoryLog",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_AssemblyHistory_ItemID",
                table: "AssemblyHistory",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_AssemblyHistory_Item_ItemID",
                table: "AssemblyHistory",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLog_Item_ItemID",
                table: "InventoryLog",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Item_ItemID",
                table: "OrderItem",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_PurchaseOrder_PurchaseOrderID",
                table: "OrderItem",
                column: "PurchaseOrderID",
                principalTable: "PurchaseOrder",
                principalColumn: "PurchaseOrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Vendor_VendorID",
                table: "PurchaseOrder",
                column: "VendorID",
                principalTable: "Vendor",
                principalColumn: "VendorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecievedItems_OrderItem_OrderItemID",
                table: "RecievedItems",
                column: "OrderItemID",
                principalTable: "OrderItem",
                principalColumn: "OrderItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeLine_AssemblyRecipe_AssemblyRecipeID",
                table: "RecipeLine",
                column: "AssemblyRecipeID",
                principalTable: "AssemblyRecipe",
                principalColumn: "AssemblyRecipeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeLine_Item_ItemID",
                table: "RecipeLine",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssemblyHistory_Item_ItemID",
                table: "AssemblyHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLog_Item_ItemID",
                table: "InventoryLog");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Item_ItemID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_PurchaseOrder_PurchaseOrderID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Vendor_VendorID",
                table: "PurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_RecievedItems_OrderItem_OrderItemID",
                table: "RecievedItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeLine_AssemblyRecipe_AssemblyRecipeID",
                table: "RecipeLine");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeLine_Item_ItemID",
                table: "RecipeLine");

            migrationBuilder.DropIndex(
                name: "IX_RecipeLine_AssemblyRecipeID",
                table: "RecipeLine");

            migrationBuilder.DropIndex(
                name: "IX_RecipeLine_ItemID",
                table: "RecipeLine");

            migrationBuilder.DropIndex(
                name: "IX_RecievedItems_OrderItemID",
                table: "RecievedItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder_VendorID",
                table: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ItemID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_PurchaseOrderID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_InventoryLog_ItemID",
                table: "InventoryLog");

            migrationBuilder.DropIndex(
                name: "IX_AssemblyHistory_ItemID",
                table: "AssemblyHistory");

            migrationBuilder.DropColumn(
                name: "Reconciled",
                table: "InventoryLog");
        }
    }
}
