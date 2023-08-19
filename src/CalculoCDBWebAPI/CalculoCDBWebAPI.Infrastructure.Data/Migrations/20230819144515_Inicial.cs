using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalculoCDBWebAPI.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taxas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ValorPercentual = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Taxas",
                columns: new[] { "Id", "Descricao", "ValorPercentual" },
                values: new object[,]
                {
                    { 1, "TB", 108.0 },
                    { 2, "CDI", 0.90000000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Taxas");
        }
    }
}
