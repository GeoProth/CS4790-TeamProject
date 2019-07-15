using Microsoft.EntityFrameworkCore.Migrations;

namespace CS4790TeamProject.Data.Migrations
{
    public partial class addedRecipeLineNameField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipeName",
                table: "AssemblyRecipe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeName",
                table: "AssemblyRecipe");
        }
    }
}
