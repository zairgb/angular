using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBTrajeta.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrajetaCredito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTrajeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaExpiracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cvv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrajetaCredito", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrajetaCredito");
        }
    }
}
