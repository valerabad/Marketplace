using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marketplace.Data.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Metadata", "Name" },
                values: new object[,]
                {
                    { 51, "Officiis qui corrupti est dolor dicta voluptatum.", "aut", "Generic Metal Bike" },
                    { 52, "Necessitatibus sed commodi quos nam ad ut.", "distinctio", "Handmade Plastic Mouse" },
                    { 53, "Dicta facilis eum temporibus laborum sit molestiae sint iusto.", "cumque", "Handcrafted Cotton Chips" },
                    { 54, "Temporibus nostrum et necessitatibus.", "hic", "Rustic Fresh Keyboard" },
                    { 55, "Ut magni optio vel soluta eos.", "fuga", "Generic Wooden Sausages" },
                    { 56, "Modi nulla quia.", "laudantium", "Unbranded Metal Towels" },
                    { 57, "Animi pariatur exercitationem quos labore.", "officiis", "Refined Frozen Salad" },
                    { 58, "Hic vero nihil ab at a.", "rerum", "Sleek Cotton Towels" },
                    { 59, "Molestiae ut provident unde consectetur et voluptatum.", "aut", "Generic Granite Pizza" },
                    { 60, "Aut dolores vero voluptatum blanditiis omnis accusantium.", "modi", "Unbranded Frozen Table" },
                    { 61, "Pariatur quisquam qui laborum quo.", "ab", "Handmade Soft Sausages" },
                    { 62, "Voluptates quo perferendis quasi sed consequatur ut.", "odio", "Intelligent Rubber Pizza" },
                    { 63, "Ex pariatur optio dolore laudantium sed ullam.", "eaque", "Incredible Soft Chips" },
                    { 64, "Voluptas est ea et repudiandae ipsam cupiditate totam aut.", "voluptates", "Sleek Frozen Bacon" },
                    { 65, "Sint dolor nihil temporibus minus delectus facere eligendi.", "hic", "Handmade Rubber Bike" },
                    { 66, "Officia sint omnis sit aut sed.", "sit", "Unbranded Metal Pizza" },
                    { 67, "Mollitia nisi unde.", "aut", "Tasty Soft Sausages" },
                    { 68, "Et est non.", "enim", "Refined Rubber Sausages" },
                    { 69, "Et doloribus animi.", "perferendis", "Awesome Granite Chair" },
                    { 70, "Sapiente excepturi in.", "alias", "Incredible Granite Bike" },
                    { 71, "Eligendi et temporibus corporis qui.", "et", "Tasty Steel Car" },
                    { 72, "Cum quis commodi ex voluptatem ea consequuntur consequuntur neque.", "facilis", "Ergonomic Wooden Ball" },
                    { 73, "Sapiente id enim.", "aut", "Awesome Steel Mouse" },
                    { 74, "Omnis repellat ab quo occaecati suscipit repudiandae ipsam.", "quas", "Practical Fresh Shoes" },
                    { 75, "Eius minima voluptatum assumenda mollitia earum.", "dignissimos", "Handcrafted Rubber Cheese" },
                    { 76, "Qui eos id omnis perspiciatis et.", "aut", "Small Concrete Bike" },
                    { 77, "Nostrum doloribus et sapiente optio.", "ipsum", "Fantastic Fresh Shoes" },
                    { 78, "Fuga repellendus fugit eum quo.", "ad", "Small Frozen Ball" },
                    { 79, "Dolor iusto ut.", "architecto", "Refined Plastic Keyboard" },
                    { 80, "Itaque suscipit quas praesentium labore.", "voluptatibus", "Gorgeous Granite Towels" },
                    { 81, "Sed officiis odit natus.", "sint", "Fantastic Cotton Chair" },
                    { 82, "Aut eligendi quis quos velit qui veritatis non neque.", "amet", "Ergonomic Metal Keyboard" },
                    { 83, "Voluptate odit iste est sed eligendi ut.", "tempora", "Handmade Frozen Mouse" },
                    { 84, "Mollitia voluptates tempora voluptas eius mollitia.", "ex", "Practical Plastic Pizza" },
                    { 85, "Aut et nisi quae et.", "cum", "Small Plastic Salad" },
                    { 86, "Fuga molestiae non dignissimos architecto.", "dolor", "Ergonomic Fresh Towels" },
                    { 87, "Et veritatis et vitae soluta non.", "quia", "Handcrafted Steel Hat" },
                    { 88, "Est ea itaque suscipit neque quia et eaque.", "et", "Fantastic Granite Mouse" },
                    { 89, "Voluptate et in neque quis.", "laboriosam", "Handmade Cotton Towels" },
                    { 90, "Et aliquam odit eaque eum ut praesentium labore voluptatibus.", "deserunt", "Licensed Rubber Shirt" },
                    { 91, "Dignissimos soluta iste maiores nobis et.", "atque", "Refined Frozen Pizza" },
                    { 92, "Iste maxime voluptatem perferendis optio dolores adipisci molestias.", "dolores", "Rustic Rubber Chicken" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Metadata", "Name" },
                values: new object[,]
                {
                    { 93, "Vero quam ipsa vitae dolore architecto.", "ad", "Generic Cotton Cheese" },
                    { 94, "Et dolor rerum a soluta maiores magni incidunt consequatur dolorem.", "dignissimos", "Intelligent Plastic Gloves" },
                    { 95, "Sapiente reprehenderit in non.", "ipsa", "Rustic Cotton Tuna" },
                    { 96, "Rem dolorum repudiandae.", "dolorem", "Gorgeous Frozen Tuna" },
                    { 97, "Architecto qui officia rerum.", "iusto", "Gorgeous Metal Salad" },
                    { 98, "Omnis officiis est ducimus.", "ullam", "Sleek Metal Computer" },
                    { 99, "Ea cupiditate unde sapiente dolores quaerat voluptatem quo fugiat.", "atque", "Awesome Concrete Gloves" },
                    { 100, "Sed quasi amet maiores quasi id et reprehenderit.", "at", "Small Wooden Cheese" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Buyer", "CreatedDt", "FinishedDt", "ItemId", "Price", "Seller", "Status" },
                values: new object[,]
                {
                    { 21, "Anibal Gaylord", new DateTime(2022, 10, 4, 1, 37, 27, 765, DateTimeKind.Local).AddTicks(5303), new DateTime(2022, 10, 4, 1, 45, 33, 140, DateTimeKind.Local).AddTicks(5376), 72, 200.79m, "White - Runolfsdottir", 2 },
                    { 22, "Darrel Bechtelar", new DateTime(2022, 10, 4, 17, 23, 11, 713, DateTimeKind.Local).AddTicks(8578), new DateTime(2022, 10, 3, 20, 37, 16, 117, DateTimeKind.Local).AddTicks(4856), 76, 513.77m, "Kulas LLC", 4 },
                    { 23, "Pietro Grimes", new DateTime(2022, 10, 3, 21, 21, 55, 311, DateTimeKind.Local).AddTicks(1733), new DateTime(2022, 10, 4, 3, 38, 37, 982, DateTimeKind.Local).AddTicks(6891), 70, 658.81m, "Klein Inc", 4 },
                    { 24, "Judy Ledner", new DateTime(2022, 10, 4, 4, 25, 27, 878, DateTimeKind.Local).AddTicks(6353), new DateTime(2022, 10, 4, 17, 4, 35, 78, DateTimeKind.Local).AddTicks(7096), 53, 675.98m, "Halvorson - Streich", 1 },
                    { 25, "Adrian Gusikowski", new DateTime(2022, 10, 4, 5, 1, 38, 641, DateTimeKind.Local).AddTicks(4528), new DateTime(2022, 10, 4, 4, 57, 21, 39, DateTimeKind.Local).AddTicks(9842), 60, 758.52m, "Bode, Baumbach and Brekke", 1 },
                    { 26, "Maynard Ankunding", new DateTime(2022, 10, 4, 14, 10, 57, 654, DateTimeKind.Local).AddTicks(9018), new DateTime(2022, 10, 4, 8, 47, 16, 330, DateTimeKind.Local).AddTicks(8277), 55, 617.06m, "Jerde - Keebler", 4 },
                    { 27, "Garfield Mills", new DateTime(2022, 10, 4, 16, 17, 41, 174, DateTimeKind.Local).AddTicks(247), new DateTime(2022, 10, 3, 22, 58, 40, 190, DateTimeKind.Local).AddTicks(6484), 65, 834.88m, "Greenholt, Heathcote and Reilly", 1 },
                    { 28, "Mathias Crona", new DateTime(2022, 10, 3, 22, 57, 43, 268, DateTimeKind.Local).AddTicks(5978), new DateTime(2022, 10, 3, 22, 19, 33, 214, DateTimeKind.Local).AddTicks(671), 73, 285.18m, "Bartoletti, Ernser and Cronin", 2 },
                    { 29, "Toni Muller", new DateTime(2022, 10, 4, 6, 31, 56, 235, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 10, 4, 10, 46, 43, 294, DateTimeKind.Local).AddTicks(9775), 74, 244.30m, "Donnelly, Moen and Senger", 4 },
                    { 30, "August Nienow", new DateTime(2022, 10, 4, 8, 32, 12, 853, DateTimeKind.Local).AddTicks(9656), new DateTime(2022, 10, 4, 9, 59, 17, 656, DateTimeKind.Local).AddTicks(1425), 70, 596.69m, "Balistreri and Sons", 1 },
                    { 31, "Zoie Ferry", new DateTime(2022, 10, 3, 23, 12, 28, 389, DateTimeKind.Local).AddTicks(1021), new DateTime(2022, 10, 4, 7, 39, 9, 814, DateTimeKind.Local).AddTicks(6233), 56, 34.07m, "Kessler LLC", 2 },
                    { 32, "Deborah Bechtelar", new DateTime(2022, 10, 4, 7, 40, 57, 408, DateTimeKind.Local).AddTicks(8166), new DateTime(2022, 10, 4, 13, 11, 27, 143, DateTimeKind.Local).AddTicks(6335), 76, 879.30m, "Gulgowski LLC", 4 },
                    { 33, "Domenic Wolf", new DateTime(2022, 10, 4, 11, 17, 39, 50, DateTimeKind.Local).AddTicks(5424), new DateTime(2022, 10, 4, 6, 58, 59, 987, DateTimeKind.Local).AddTicks(8560), 74, 498.97m, "Goldner, Hettinger and Mills", 2 },
                    { 34, "Greg Dickinson", new DateTime(2022, 10, 4, 1, 14, 14, 229, DateTimeKind.Local).AddTicks(9465), new DateTime(2022, 10, 4, 8, 5, 27, 414, DateTimeKind.Local).AddTicks(1385), 62, 124.59m, "Lubowitz, Breitenberg and Wolf", 1 },
                    { 35, "Dave Renner", new DateTime(2022, 10, 4, 9, 41, 53, 725, DateTimeKind.Local).AddTicks(9725), new DateTime(2022, 10, 4, 15, 29, 54, 174, DateTimeKind.Local).AddTicks(7794), 62, 916.48m, "McDermott, Leffler and Legros", 2 },
                    { 36, "Edd Erdman", new DateTime(2022, 10, 4, 15, 20, 19, 526, DateTimeKind.Local).AddTicks(4163), new DateTime(2022, 10, 3, 20, 22, 41, 460, DateTimeKind.Local).AddTicks(2780), 78, 905.99m, "Stehr - Lemke", 1 },
                    { 37, "Godfrey Rutherford", new DateTime(2022, 10, 4, 4, 55, 38, 492, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 10, 4, 4, 13, 59, 112, DateTimeKind.Local).AddTicks(908), 79, 541.24m, "Herzog, Considine and Stehr", 1 },
                    { 38, "Mekhi Beatty", new DateTime(2022, 10, 4, 11, 42, 45, 951, DateTimeKind.Local).AddTicks(2337), new DateTime(2022, 10, 4, 11, 44, 20, 238, DateTimeKind.Local).AddTicks(7034), 67, 944.06m, "Mann Inc", 2 },
                    { 39, "Chadrick Gulgowski", new DateTime(2022, 10, 4, 13, 40, 55, 255, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 10, 4, 1, 49, 37, 7, DateTimeKind.Local).AddTicks(5597), 63, 47.87m, "Armstrong Inc", 1 },
                    { 40, "Elvis Murazik", new DateTime(2022, 10, 4, 1, 33, 50, 771, DateTimeKind.Local).AddTicks(8383), new DateTime(2022, 10, 3, 23, 3, 37, 381, DateTimeKind.Local).AddTicks(2230), 66, 555.56m, "Herzog Inc", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79);
        }
    }
}
