using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MEalAPI.Migrations
{
    public partial class Update001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Units",
                schema: "MEal",
                table: "recipe_ingredients",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "recipes",
                schema: "MEal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PrepTime = table.Column<int>(type: "integer", nullable: true),
                    CookTime = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sections",
                schema: "MEal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sections", x => x.Id);
                },
                comment: "Table representing grocery store sections such as Dairy, Bulk, Produce, etc.");

            migrationBuilder.CreateTable(
                name: "recipe_steps",
                schema: "MEal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    RecipeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_recipe_steps_recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalSchema: "MEal",
                        principalTable: "recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Table representing steps within a recipe's directions.");

            migrationBuilder.CreateTable(
                name: "ingredients",
                schema: "MEal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SectionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ingredients_sections_SectionId",
                        column: x => x.SectionId,
                        principalSchema: "MEal",
                        principalTable: "sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_recipe_ingredients_IngredientId",
                schema: "MEal",
                table: "recipe_ingredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_ingredients_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_ingredients_SectionId",
                schema: "MEal",
                table: "ingredients",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_steps_RecipeId",
                schema: "MEal",
                table: "recipe_steps",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_ingredients_ingredients_IngredientId",
                schema: "MEal",
                table: "recipe_ingredients",
                column: "IngredientId",
                principalSchema: "MEal",
                principalTable: "ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_ingredients_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients",
                column: "RecipeId",
                principalSchema: "MEal",
                principalTable: "recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recipe_ingredients_ingredients_IngredientId",
                schema: "MEal",
                table: "recipe_ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_recipe_ingredients_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients");

            migrationBuilder.DropTable(
                name: "ingredients",
                schema: "MEal");

            migrationBuilder.DropTable(
                name: "recipe_steps",
                schema: "MEal");

            migrationBuilder.DropTable(
                name: "sections",
                schema: "MEal");

            migrationBuilder.DropTable(
                name: "recipes",
                schema: "MEal");

            migrationBuilder.DropIndex(
                name: "IX_recipe_ingredients_IngredientId",
                schema: "MEal",
                table: "recipe_ingredients");

            migrationBuilder.DropIndex(
                name: "IX_recipe_ingredients_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients");

            migrationBuilder.AlterColumn<string>(
                name: "Units",
                schema: "MEal",
                table: "recipe_ingredients",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
