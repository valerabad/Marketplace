using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.Data.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metadata = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Buyer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishedDt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Metadata", "Name" },
                values: new object[,]
                {
                    { 1, "Natus omnis eius quidem a.", "voluptatem", "Licensed Concrete Pants" },
                    { 51, "Natus omnis eius quidem a.", "voluptatem", "Licensed Concrete Pants" },
                    { 52, "Non ea velit consequatur pariatur sapiente sed voluptas et labore.", "dolor", "Generic Wooden Soap" },
                    { 53, "Repellat quo corporis ipsum et.", "rerum", "Unbranded Wooden Chips" },
                    { 54, "Libero expedita qui provident animi rem molestias architecto velit mollitia.", "quibusdam", "Intelligent Plastic Ball" },
                    { 55, "Minima qui natus sunt eius amet consequatur ea recusandae.", "porro", "Intelligent Metal Chips" },
                    { 56, "Voluptatum molestiae velit voluptatem dolorum aspernatur totam.", "dicta", "Handmade Metal Pizza" },
                    { 57, "Repellendus possimus officia inventore officia illo temporibus.", "omnis", "Sleek Rubber Pizza" },
                    { 58, "Aut omnis ut iusto assumenda.", "eum", "Small Plastic Bacon" },
                    { 59, "Sint laudantium explicabo magnam cupiditate quibusdam dolore ad ea in.", "et", "Fantastic Cotton Mouse" },
                    { 60, "Incidunt ad repellendus cupiditate dolore quibusdam.", "molestiae", "Licensed Fresh Shoes" },
                    { 61, "Facere mollitia et quia.", "ducimus", "Handmade Wooden Mouse" },
                    { 62, "Non dolorem reprehenderit autem perferendis qui consectetur cum est.", "similique", "Refined Metal Shirt" },
                    { 63, "Eaque minus delectus.", "ab", "Handmade Plastic Tuna" },
                    { 64, "Sint incidunt delectus.", "rem", "Handcrafted Plastic Chips" },
                    { 65, "Iste velit minus saepe modi.", "quae", "Fantastic Steel Shirt" },
                    { 66, "Officiis sed ipsum tenetur sed tenetur qui quia quia ad.", "modi", "Tasty Wooden Towels" },
                    { 67, "Dolor porro fugit temporibus corporis est quas autem.", "est", "Handmade Cotton Hat" },
                    { 68, "Dolor dolor laboriosam sit ipsam id debitis ducimus rerum placeat.", "non", "Tasty Fresh Mouse" },
                    { 69, "Nihil suscipit labore est adipisci dolores harum natus iste iste.", "voluptatem", "Gorgeous Steel Shoes" },
                    { 70, "Quia et incidunt.", "quo", "Gorgeous Concrete Gloves" },
                    { 71, "Asperiores animi omnis nam rem sint expedita.", "deleniti", "Rustic Soft Bacon" },
                    { 72, "Animi maxime libero.", "et", "Practical Steel Chicken" },
                    { 73, "Vero et aperiam aut nisi est eum consectetur autem.", "consequatur", "Unbranded Steel Cheese" },
                    { 74, "Inventore ut molestiae quo cum quidem similique.", "aut", "Licensed Wooden Mouse" },
                    { 75, "Ut cupiditate blanditiis deserunt qui odit iste.", "et", "Handcrafted Soft Hat" },
                    { 76, "Aut aut vero enim deserunt sit.", "dolorem", "Incredible Soft Tuna" },
                    { 77, "Est provident aut qui ullam et ut modi.", "asperiores", "Practical Concrete Shoes" },
                    { 78, "Quia delectus et atque quaerat.", "iusto", "Awesome Metal Table" },
                    { 79, "Non est laudantium quaerat ipsam vel maxime facilis.", "labore", "Gorgeous Concrete Tuna" },
                    { 80, "Qui sit voluptas veritatis maxime aut modi placeat deserunt.", "iure", "Tasty Granite Shirt" },
                    { 81, "Nulla doloribus vel rerum et est.", "aut", "Tasty Concrete Gloves" },
                    { 82, "Voluptatem corporis delectus laboriosam repellat cupiditate qui possimus quis placeat.", "ipsam", "Ergonomic Wooden Fish" },
                    { 83, "Illo totam illum magnam doloremque optio quis et adipisci accusantium.", "sit", "Unbranded Metal Table" },
                    { 84, "Voluptas temporibus molestias vel velit.", "et", "Licensed Frozen Ball" },
                    { 85, "Minus sit est quo quidem beatae.", "quaerat", "Unbranded Rubber Bacon" },
                    { 86, "Accusamus voluptate natus sapiente labore deleniti accusantium perspiciatis enim.", "adipisci", "Ergonomic Soft Towels" },
                    { 87, "Tempora et et ab amet.", "delectus", "Rustic Wooden Sausages" },
                    { 88, "Facilis eius necessitatibus necessitatibus dolor.", "quia", "Sleek Cotton Fish" },
                    { 89, "Adipisci quaerat tempore unde.", "sequi", "Tasty Cotton Table" },
                    { 90, "Rem amet autem occaecati non et accusamus.", "qui", "Sleek Cotton Sausages" },
                    { 91, "Tempora quis quae ratione accusantium ipsa consectetur cupiditate.", "labore", "Practical Soft Bacon" },
                    { 92, "Illo mollitia pariatur.", "eligendi", "Gorgeous Granite Pants" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Metadata", "Name" },
                values: new object[,]
                {
                    { 93, "Veniam fugit id consequatur sed optio ad adipisci aperiam.", "et", "Handcrafted Plastic Tuna" },
                    { 94, "Aut quo neque ipsa incidunt.", "nihil", "Fantastic Plastic Table" },
                    { 95, "Sequi saepe illum velit.", "eos", "Generic Soft Gloves" },
                    { 96, "Aut nemo in sed ipsum aut veritatis consectetur occaecati.", "voluptates", "Incredible Steel Soap" },
                    { 97, "Et explicabo temporibus.", "sit", "Small Wooden Car" },
                    { 98, "Voluptas dolorem quibusdam recusandae quas voluptatem quis occaecati aspernatur.", "repellat", "Small Soft Soap" },
                    { 99, "Odit repellendus ad corporis omnis.", "rerum", "Sleek Rubber Tuna" },
                    { 100, "Et velit tempore quis asperiores sint suscipit ea rerum alias.", "voluptates", "Ergonomic Frozen Bacon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ItemId",
                table: "Sales",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
