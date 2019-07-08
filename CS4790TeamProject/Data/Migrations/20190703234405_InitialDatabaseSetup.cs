using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CS4790TeamProject.Data.Migrations
{
    public partial class InitialDatabaseSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssemblyHistory",
                columns: table => new
                {
                    AssemblyHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    AssemblyDate = table.Column<DateTime>(nullable: false),
                    QtyAssembled = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssemblyHistory", x => x.AssemblyHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "AssemblyRecipe",
                columns: table => new
                {
                    AssemblyRecipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssemblyRecipe", x => x.AssemblyRecipeId);
                });

            migrationBuilder.CreateTable(
                name: "InventoryLog",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    PreviousQty = table.Column<int>(nullable: false),
                    NewQty = table.Column<int>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryLog", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    OnhandQty = table.Column<int>(nullable: false),
                    ListRetailCost = table.Column<decimal>(nullable: false),
                    ReorderQty = table.Column<int>(nullable: false),
                    MaxQty = table.Column<int>(nullable: false),
                    MeasureID = table.Column<int>(nullable: false),
                    MeasureAmnt = table.Column<decimal>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    MeasureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeasureName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.MeasureId);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    PurchaseOrderID = table.Column<int>(nullable: false),
                    VendorSKU = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    QuantityOrdered = table.Column<int>(nullable: false),
                    DateDelivered = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorID = table.Column<int>(nullable: false),
                    DateOrdered = table.Column<DateTime>(nullable: false),
                    VendorPO = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.PurchaseOrderId);
                });

            migrationBuilder.CreateTable(
                name: "RecievedItems",
                columns: table => new
                {
                    ReceivedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderItemID = table.Column<int>(nullable: false),
                    QuantityReceived = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecievedItems", x => x.ReceivedId);
                });

            migrationBuilder.CreateTable(
                name: "RecipeLine",
                columns: table => new
                {
                    RecipeLineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssemblyRecipeID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    RequiredItemQuantity = table.Column<int>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeLine", x => x.RecipeLineId);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorName = table.Column<string>(nullable: true),
                    VendorAddress = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssemblyHistory");

            migrationBuilder.DropTable(
                name: "AssemblyRecipe");

            migrationBuilder.DropTable(
                name: "InventoryLog");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "RecievedItems");

            migrationBuilder.DropTable(
                name: "RecipeLine");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
