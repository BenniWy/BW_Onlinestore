using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { "0adeb68b-a7ba-469c-a87f-dc2c308dec59", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/20/500", 20000L, "Product 20" },
                    { "1dfd92eb-eb2c-4a05-aa27-82bac215a27b", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/2/500", 2000L, "Product 2" },
                    { "262b56e5-690c-4657-833a-54d2ed73137b", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/12/500", 12000L, "Product 12" },
                    { "28420ca1-1c20-47ac-a11c-0ca7a9600daa", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/18/500", 18000L, "Product 18" },
                    { "2dec1732-1a4e-465b-b5b7-0565dd957293", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/13/500", 13000L, "Product 13" },
                    { "37061a6a-bc1f-466e-b333-ad27c6081fec", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/3/500", 3000L, "Product 3" },
                    { "37608311-2a47-4c25-a37b-b03972642320", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/14/500", 14000L, "Product 14" },
                    { "49c7f262-5793-4ef1-ba11-7ff640dd5606", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/5/500", 5000L, "Product 5" },
                    { "6c3da1c3-112f-4e64-86f8-7340d344bd8a", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/9/500", 9000L, "Product 9" },
                    { "764c3b61-210f-4df4-ad93-74119cf347ea", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/11/500", 11000L, "Product 11" },
                    { "80176f01-43cb-458e-b771-d4ed8c846e06", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/15/500", 15000L, "Product 15" },
                    { "a3cc9f56-8c20-4972-9c85-74bd74f38f88", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/10/500", 10000L, "Product 10" },
                    { "ad7bf947-951d-4f7c-aa0d-e4750c2a0235", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/4/500", 4000L, "Product 4" },
                    { "b2200873-a325-4517-b801-a07731f09264", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/6/500", 6000L, "Product 6" },
                    { "b8fbc19f-b24b-445d-ab79-ae421908e92a", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/19/500", 19000L, "Product 19" },
                    { "d4b36de2-262a-4a0b-8dee-e6eac5309d47", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/8/500", 8000L, "Product 8" },
                    { "e072e012-349c-49d8-861b-5eefd8816af3", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/17/500", 17000L, "Product 17" },
                    { "e45f6f12-894d-4a7a-848f-08b99a66dac4", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/1/500", 1000L, "Product 1" },
                    { "ed5ed498-0f35-41af-91c8-4e8405f9d7f7", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/7/500", 7000L, "Product 7" },
                    { "f05a2e2c-f39c-4699-b361-ad69c4fe6cea", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/16/500", 16000L, "Product 16" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
