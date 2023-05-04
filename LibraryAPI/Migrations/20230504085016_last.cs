using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverUrl", "Description", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", "https://www.book1.com", "Description 1", 3.8999999999999999, "Title 1" },
                    { 2, "Author 2", "https://www.book2.com", "Description 2", 3.8999999999999999, "Title 2" },
                    { 3, "Author 3", "https://www.book3.com", "Description 3", 3.8999999999999999, "Title 3" },
                    { 4, "Author 4", "https://www.book4.com", "Description 4", 3.8999999999999999, "Title 4" },
                    { 5, "Author 5", "https://www.book5.com", "Description 5", 3.8999999999999999, "Title 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
