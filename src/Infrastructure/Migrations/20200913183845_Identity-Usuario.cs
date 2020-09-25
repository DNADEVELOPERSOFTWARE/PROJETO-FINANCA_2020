using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class IdentityUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimUsuarios_UsuarioIDentity_UserId",
                table: "ClaimUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_LoginsUsuario_UsuarioIDentity_UserId",
                table: "LoginsUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PapeisUsuario_Papeis_RoleId",
                table: "PapeisUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PapeisUsuario_UsuarioIDentity_UserId",
                table: "PapeisUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TokensUsuario_UsuarioIDentity_UserId",
                table: "TokensUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioIDentity",
                table: "UsuarioIDentity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PapeisUsuario",
                table: "PapeisUsuario");

            migrationBuilder.RenameTable(
                name: "UsuarioIDentity",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "PapeisUsuario",
                newName: "PerfilUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_PapeisUsuario_RoleId",
                table: "PerfilUsuario",
                newName: "IX_PerfilUsuario_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfilUsuario",
                table: "PerfilUsuario",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimUsuarios_Usuario_UserId",
                table: "ClaimUsuarios",
                column: "UserId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginsUsuario_Usuario_UserId",
                table: "LoginsUsuario",
                column: "UserId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Papeis_RoleId",
                table: "PerfilUsuario",
                column: "RoleId",
                principalTable: "Papeis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Usuario_UserId",
                table: "PerfilUsuario",
                column: "UserId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokensUsuario_Usuario_UserId",
                table: "TokensUsuario",
                column: "UserId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClaimUsuarios_Usuario_UserId",
                table: "ClaimUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_LoginsUsuario_Usuario_UserId",
                table: "LoginsUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Papeis_RoleId",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Usuario_UserId",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_TokensUsuario_Usuario_UserId",
                table: "TokensUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfilUsuario",
                table: "PerfilUsuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "UsuarioIDentity");

            migrationBuilder.RenameTable(
                name: "PerfilUsuario",
                newName: "PapeisUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_PerfilUsuario_RoleId",
                table: "PapeisUsuario",
                newName: "IX_PapeisUsuario_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioIDentity",
                table: "UsuarioIDentity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PapeisUsuario",
                table: "PapeisUsuario",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClaimUsuarios_UsuarioIDentity_UserId",
                table: "ClaimUsuarios",
                column: "UserId",
                principalTable: "UsuarioIDentity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginsUsuario_UsuarioIDentity_UserId",
                table: "LoginsUsuario",
                column: "UserId",
                principalTable: "UsuarioIDentity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PapeisUsuario_Papeis_RoleId",
                table: "PapeisUsuario",
                column: "RoleId",
                principalTable: "Papeis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PapeisUsuario_UsuarioIDentity_UserId",
                table: "PapeisUsuario",
                column: "UserId",
                principalTable: "UsuarioIDentity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TokensUsuario_UsuarioIDentity_UserId",
                table: "TokensUsuario",
                column: "UserId",
                principalTable: "UsuarioIDentity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
