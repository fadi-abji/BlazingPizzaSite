using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingPizzaSite.Migrations
{
    /// <inheritdoc />
    public partial class sizefamily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FixedSize",
                table: "Specials",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: 1,
                column: "FixedSize",
                value: null);

            migrationBuilder.UpdateData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: 2,
                column: "FixedSize",
                value: null);

            migrationBuilder.UpdateData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: 3,
                column: "FixedSize",
                value: null);

            migrationBuilder.UpdateData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: 4,
                column: "FixedSize",
                value: null);

            migrationBuilder.UpdateData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: 5,
                column: "FixedSize",
                value: null);

            migrationBuilder.UpdateData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: 6,
                column: "FixedSize",
                value: null);

            migrationBuilder.InsertData(
                table: "Specials",
                columns: new[] { "Id", "BasePrice", "Description", "FixedSize", "ImageUrl", "Name" },
                values: new object[] { 9, 14.99m, "24\" of pure tomatoes and basil", 24, "img/pizzas/margherita.jpg", "Margherita Family Size" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "FixedSize",
                table: "Specials");
        }
    }
}
