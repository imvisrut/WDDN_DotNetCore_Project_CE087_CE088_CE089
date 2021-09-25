using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations.ApplicationDb
{
    public partial class moreseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductTable",
                columns: new[] { "Id", "Category", "Description", "ImageURL1", "ImageURL2", "MainImageURL", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 7, "Keyboard", "PC GAMING KEYBOARD AND GAMING MOUSE COMBO: Includes Redragon RGB Backlit Computer Gaming Keyboard and RGB Backlit Gaming Mouse. ALL-IN-ONE PC GAMER VALUE KIT, Fantastic for Gamers (New Improved Version)", "https://m.media-amazon.com/images/I/71uIslKmtoL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/71H6y1GGbAL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/71kr3WAj1FL._AC_SL1500_.jpg", "Redragon Keyboard", 4000, 200 },
                    { 8, "Keyboard", "Mini 60% Keyboard: RK61 mini 60% gaming keyboard is a ultra-compact layout with 61 keys makes you a neat desktop with your organized gears on, even folks have nothing to do with Minimalist will dive into its tiny practical design. Tips you might want to know is that keyboard without numpad is most FPS gamers' choice, more spaces left for mouse movements.", "https://m.media-amazon.com/images/I/71ji90FcW4L._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/71TYtZyvCrS._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/61mBAMckzJL._AC_SL1500_.jpg", "RK ROYAL KLUDGE", 3000, 100 },
                    { 9, "CPU", "Ryzen 5 3600 6-Core 3.6GHz (4.2GHz Max Boost) CPU Processor | 500G SSD – Up to 30x Faster Than Traditional HDD NVIDIA GeForce GTX 1660 Super 6GB GDDR5 Video Card | 16 GB Gaming Memory DDR4 3000 with Heat Spreader | Windows 10 Home 64 - bit", "https://m.media-amazon.com/images/I/71kwAe2O6xL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/9182gfeh28L._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81Vm7yrdKCL._AC_SL1500_.jpg", "SkyTech Blaze II", 60000, 50 },
                    { 10, "Games", "Lightning Speed - Harness the power of a custom CPU, GPU, and SSD with Integrated I/O that rewrite the rules of what a PlayStation console can do. Stunning Games - Marvel at incredible graphics and experience new PS5 features.", "https://m.media-amazon.com/images/I/619BkvKW35L._SL1500_.jpg", "https://m.media-amazon.com/images/I/71v7RDRYBTL._SL1500_.jpg", "https://m.media-amazon.com/images/I/71vWi5Iuz3L._SL1500_.jpg", "PlayStation 5 Console", 50000, 400 },
                    { 11, "Headphones", "Built for a new generation - Fine-tuned for 3D Audio on PS5 consoles. Enjoy comfortable gaming with refined earpads and headband strap. Play in style with a sleek design that complements the PS5 console. Available when feature is supported by game.", "https://m.media-amazon.com/images/I/71lrh6vzPcL._SL1500_.jpg", "https://m.media-amazon.com/images/I/71tU3AxObuL._SL1500_.jpg", "https://m.media-amazon.com/images/I/610SsJ5aAQL._SL1393_.jpg", "Sony PULSE 3D Wireless Headset", 6000, 300 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductTable",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
