using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop1.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderProductToppings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderProductToppings");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderProducts");
        }
    }
}
