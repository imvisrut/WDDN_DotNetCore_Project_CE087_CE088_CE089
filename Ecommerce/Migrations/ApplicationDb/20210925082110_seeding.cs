using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations.ApplicationDb
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductTable",
                columns: new[] { "Id", "Category", "Description", "ImageURL1", "ImageURL2", "MainImageURL", "Name", "Price", "Stock" },
                values: new object[] { 6, "Headphones", "Built for a new generation - Fine-tuned for 2D Audio on PS6 consoles. Enjoy comfortable gaming with refined earpads and headband strap. Play in style with a sleek design that complements the PS5 console. Available when feature is supported by game.", "https://m.media-amazon.com/images/I/71lrh6vzPcL._SL1500_.jpg", "https://m.media-amazon.com/images/I/71tU3AxObuL._SL1500_.jpg", "https://m.media-amazon.com/images/I/610SsJ5aAQL._SL1393_.jpg", "Sony PULSE 2D Wireless Headset", 2000, 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
