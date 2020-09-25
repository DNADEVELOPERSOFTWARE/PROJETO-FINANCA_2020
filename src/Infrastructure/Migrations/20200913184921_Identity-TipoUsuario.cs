using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class IdentityTipoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimsPapeis_Papeis_RoleId",
                table: "ClaimsPapeis");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Papeis_RoleId",
                table: "PerfilUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Papeis",
                table: "Papeis");

            migrationBuilder.RenameTable(
                name: "Papeis",
                newName: "TipoUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoUsuario",
                table: "TipoUsuario",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimsPapeis_TipoUsuario_RoleId",
                table: "ClaimsPapeis",
                column: "RoleId",
                principalTable: "TipoUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_TipoUsuario_RoleId",
                table: "PerfilUsuario",
                column: "RoleId",
                principalTable: "TipoUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimsPapeis_TipoUsuario_RoleId",
                table: "ClaimsPapeis");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_TipoUsuario_RoleId",
                table: "PerfilUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoUsuario",
                table: "TipoUsuario");

            migrationBuilder.RenameTable(
                name: "TipoUsuario",
                newName: "Papeis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Papeis",
                table: "Papeis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimsPapeis_Papeis_RoleId",
                table: "ClaimsPapeis",
                column: "RoleId",
                principalTable: "Papeis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Papeis_RoleId",
                table: "PerfilUsuario",
                column: "RoleId",
                principalTable: "Papeis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
