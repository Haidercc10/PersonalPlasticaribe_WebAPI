using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personal_PlasticaribeWebAPI.Migrations
{
    public partial class ReplanteoRegistros_Operarios4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Operarios_Tipos_Registros_TpReg_Id",
                table: "Registros_Operarios");

            migrationBuilder.DropColumn(
                name: "RegOpe_Hora",
                table: "Registros_Operarios");

            migrationBuilder.RenameColumn(
                name: "TpReg_Id",
                table: "Registros_Operarios",
                newName: "Turno_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Registros_Operarios_TpReg_Id",
                table: "Registros_Operarios",
                newName: "IX_Registros_Operarios_Turno_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Operarios_Turnos_Turno_Id",
                table: "Registros_Operarios",
                column: "Turno_Id",
                principalTable: "Turnos",
                principalColumn: "Turno_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Operarios_Turnos_Turno_Id",
                table: "Registros_Operarios");

            migrationBuilder.RenameColumn(
                name: "Turno_Id",
                table: "Registros_Operarios",
                newName: "TpReg_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Registros_Operarios_Turno_Id",
                table: "Registros_Operarios",
                newName: "IX_Registros_Operarios_TpReg_Id");

            migrationBuilder.AddColumn<string>(
                name: "RegOpe_Hora",
                table: "Registros_Operarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Operarios_Tipos_Registros_TpReg_Id",
                table: "Registros_Operarios",
                column: "TpReg_Id",
                principalTable: "Tipos_Registros",
                principalColumn: "TpReg_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
