using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Health.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
