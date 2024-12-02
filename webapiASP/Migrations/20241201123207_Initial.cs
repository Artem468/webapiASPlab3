using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapiASP.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PricesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<long>(type: "bigint", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PricesId);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationProduct",
                columns: table => new
                {
                    RegistrationProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuilderLastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<long>(type: "bigint", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PricesId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationProduct", x => x.RegistrationProductId);
                    table.ForeignKey(
                        name: "FK_RegistrationProduct_Prices_PricesId",
                        column: x => x.PricesId,
                        principalTable: "Prices",
                        principalColumn: "PricesId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationProduct_PricesId",
                table: "RegistrationProduct",
                column: "PricesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationProduct");

            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}
