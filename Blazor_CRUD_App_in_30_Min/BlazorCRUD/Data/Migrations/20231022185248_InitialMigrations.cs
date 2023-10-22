using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 4096, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "Example Content for Post 1", "Post 1" },
                    { 2, "Example Content for Post 2", "Post 2" },
                    { 3, "Example Content for Post 3", "Post 3" },
                    { 4, "Example Content for Post 4", "Post 4" },
                    { 5, "Example Content for Post 5", "Post 5" },
                    { 6, "Example Content for Post 6", "Post 6" },
                    { 7, "Example Content for Post 7", "Post 7" },
                    { 8, "Example Content for Post 8", "Post 8" },
                    { 9, "Example Content for Post 9", "Post 9" },
                    { 10, "Example Content for Post 10", "Post 10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
