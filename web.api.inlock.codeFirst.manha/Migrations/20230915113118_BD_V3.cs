using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.api.inlock.codeFirst.manha.Migrations
{
    /// <inheritdoc />
    public partial class BD_V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuario",
                type: "VARCHAR(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuario",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(60)",
                oldMaxLength: 60);
        }
    }
}
