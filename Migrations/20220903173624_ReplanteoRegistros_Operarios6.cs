using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personal_PlasticaribeWebAPI.Migrations
{
    public partial class ReplanteoRegistros_Operarios6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegOpe_HoraEntrada",
                table: "Registros_Operarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegOpe_HoraInicioReceso",
                table: "Registros_Operarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegOpe_HoraFinReceso",
                table: "Registros_Operarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");           

            migrationBuilder.AddColumn<string>(
                name: "RegOpe_HoraSalida",
                table: "Registros_Operarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegOpe_HoraEntrada",
                table: "Registros_Operarios");

            migrationBuilder.DropColumn(
                name: "RegOpe_HoraFinReceso",
                table: "Registros_Operarios");

            migrationBuilder.DropColumn(
                name: "RegOpe_HoraInicioReceso",
                table: "Registros_Operarios");

            migrationBuilder.DropColumn(
                name: "RegOpe_HoraSalida",
                table: "Registros_Operarios");
        }
    }
}
