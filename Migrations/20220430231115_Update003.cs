using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MEalAPI.Migrations
{
    public partial class Update003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recipe_ingredients_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_recipe_steps_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_steps");

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                schema: "MEal",
                table: "recipes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                schema: "MEal",
                table: "recipe_steps",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                schema: "MEal",
                table: "recipe_steps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                schema: "MEal",
                table: "recipe_ingredients",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "meals",
                schema: "MEal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meals", x => x.Id);
                },
                comment: "Table representing specific meals, primarily breakfast, lunch, and dinner.");

            migrationBuilder.CreateIndex(
                name: "IX_recipes_MealId",
                schema: "MEal",
                table: "recipes",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_ingredients_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients",
                column: "RecipeId",
                principalSchema: "MEal",
                principalTable: "recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_steps_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_steps",
                column: "RecipeId",
                principalSchema: "MEal",
                principalTable: "recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_recipes_meals_MealId",
                schema: "MEal",
                table: "recipes",
                column: "MealId",
                principalSchema: "MEal",
                principalTable: "meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recipe_ingredients_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_recipe_steps_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_recipes_meals_MealId",
                schema: "MEal",
                table: "recipes");

            migrationBuilder.DropTable(
                name: "meals",
                schema: "MEal");

            migrationBuilder.DropIndex(
                name: "IX_recipes_MealId",
                schema: "MEal",
                table: "recipes");

            migrationBuilder.DropColumn(
                name: "MealId",
                schema: "MEal",
                table: "recipes");

            migrationBuilder.DropColumn(
                name: "Order",
                schema: "MEal",
                table: "recipe_steps");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                schema: "MEal",
                table: "recipe_steps",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                schema: "MEal",
                table: "recipe_ingredients",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_ingredients_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_ingredients",
                column: "RecipeId",
                principalSchema: "MEal",
                principalTable: "recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_steps_recipes_RecipeId",
                schema: "MEal",
                table: "recipe_steps",
                column: "RecipeId",
                principalSchema: "MEal",
                principalTable: "recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
