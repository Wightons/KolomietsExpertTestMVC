using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KolomietsExpertTestMVC.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmCategory_Category_CategoryId",
                table: "FilmCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmCategory_Film_FilmId",
                table: "FilmCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmCategory",
                table: "FilmCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Film",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "FilmCategory",
                newName: "FilmCategories");

            migrationBuilder.RenameTable(
                name: "Film",
                newName: "Films");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_FilmCategory_FilmId",
                table: "FilmCategories",
                newName: "IX_FilmCategories_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmCategory_CategoryId",
                table: "FilmCategories",
                newName: "IX_FilmCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmCategories",
                table: "FilmCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmCategories_Categories_CategoryId",
                table: "FilmCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmCategories_Films_FilmId",
                table: "FilmCategories",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmCategories_Categories_CategoryId",
                table: "FilmCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmCategories_Films_FilmId",
                table: "FilmCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmCategories",
                table: "FilmCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Film");

            migrationBuilder.RenameTable(
                name: "FilmCategories",
                newName: "FilmCategory");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_FilmCategories_FilmId",
                table: "FilmCategory",
                newName: "IX_FilmCategory_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmCategories_CategoryId",
                table: "FilmCategory",
                newName: "IX_FilmCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Film",
                table: "Film",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmCategory",
                table: "FilmCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmCategory_Category_CategoryId",
                table: "FilmCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmCategory_Film_FilmId",
                table: "FilmCategory",
                column: "FilmId",
                principalTable: "Film",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
