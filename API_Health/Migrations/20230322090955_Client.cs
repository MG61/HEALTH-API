using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Health.Migrations
{
    /// <inheritdoc />
    public partial class Client : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID_client = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Логин = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Пароль = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Имя = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID_client);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ID_provider = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Логин = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Пароль = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Имя = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Склад = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ID_provider);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartEmployee",
                columns: table => new
                {
                    ID_cart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Название = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Количество = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Цена = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartEmployee", x => x.ID_cart);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ID_cart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Название = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Количество = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Цена = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ID_cart);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "ShoppingCartEmployee");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");
        }
    }
}
