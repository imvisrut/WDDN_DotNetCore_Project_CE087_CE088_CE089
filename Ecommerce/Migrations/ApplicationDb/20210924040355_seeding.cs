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
                values: new object[] { 1, "Keyboard", "PC GAMING KEYBOARD AND GAMING MOUSE COMBO: Includes Redragon RGB Backlit Computer Gaming Keyboard and RGB Backlit Gaming Mouse. ALL-IN-ONE PC GAMER VALUE KIT, Fantastic for Gamers (New Improved Version)", "https://m.media-amazon.com/images/I/71uIslKmtoL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/71H6y1GGbAL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/71kr3WAj1FL._AC_SL1500_.jpg", "Redragon Keyboard", 4000, 200 });

            migrationBuilder.InsertData(
                table: "ProductTable",
                columns: new[] { "Id", "Category", "Description", "ImageURL1", "ImageURL2", "MainImageURL", "Name", "Price", "Stock" },
                values: new object[] { 2, "Keyboard", "Mini 60% Keyboard: RK61 mini 60% gaming keyboard is a ultra-compact layout with 61 keys makes you a neat desktop with your organized gears on, even folks have nothing to do with Minimalist will dive into its tiny practical design. Tips you might want to know is that keyboard without numpad is most FPS gamers' choice, more spaces left for mouse movements.", "https://m.media-amazon.com/images/I/71ji90FcW4L._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/71TYtZyvCrS._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/61mBAMckzJL._AC_SL1500_.jpg", "RK ROYAL KLUDGE", 3000, 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
