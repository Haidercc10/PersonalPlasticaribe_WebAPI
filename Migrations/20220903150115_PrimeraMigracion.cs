using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personal_PlasticaribeWebAPI.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Area_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Area_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Area_Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Estado_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Estado_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Estado_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Identificaciones",
                columns: table => new
                {
                    TipoIdent_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    TipoIdent_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoIdent_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Identificaciones", x => x.TipoIdent_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Usuarios",
                columns: table => new
                {
                    TipoUsu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoUsu_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoUsu_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Usuarios", x => x.TipoUsu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    Turno_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turno_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Turno_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.Turno_Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usu_Id = table.Column<long>(type: "bigint", nullable: false),
                    Usu_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usu_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoIdent_Id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Area_Id = table.Column<int>(type: "int", nullable: false),
                    TipoUsu_Id = table.Column<int>(type: "int", nullable: false),
                    Estado_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Usu_Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Areas_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "Areas",
                        principalColumn: "Area_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Estados_Estado_Id",
                        column: x => x.Estado_Id,
                        principalTable: "Estados",
                        principalColumn: "Estado_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Tipos_Identificaciones_TipoIdent_Id",
                        column: x => x.TipoIdent_Id,
                        principalTable: "Tipos_Identificaciones",
                        principalColumn: "TipoIdent_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Tipos_Usuarios_TipoUsu_Id",
                        column: x => x.TipoUsu_Id,
                        principalTable: "Tipos_Usuarios",
                        principalColumn: "TipoUsu_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Registros",
                columns: table => new
                {
                    TpReg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TpReg_Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    TpReg_Descripcion = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    TpReg_Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Turno_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Registros", x => x.TpReg_Id);
                    table.ForeignKey(
                        name: "FK_Tipos_Registros_Turnos_Turno_Id",
                        column: x => x.Turno_Id,
                        principalTable: "Turnos",
                        principalColumn: "Turno_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registros_Operarios",
                columns: table => new
                {
                    RegOpe_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usu_Id = table.Column<long>(type: "bigint", nullable: false),
                    TpReg_Id = table.Column<int>(type: "int", nullable: false),
                    RegOpe_Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    RegOpe_Hora = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros_Operarios", x => x.RegOpe_Id);
                    table.ForeignKey(
                        name: "FK_Registros_Operarios_Tipos_Registros_TpReg_Id",
                        column: x => x.TpReg_Id,
                        principalTable: "Tipos_Registros",
                        principalColumn: "TpReg_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registros_Operarios_Usuarios_Usu_Id",
                        column: x => x.Usu_Id,
                        principalTable: "Usuarios",
                        principalColumn: "Usu_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registros_Operarios_TpReg_Id",
                table: "Registros_Operarios",
                column: "TpReg_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_Operarios_Usu_Id",
                table: "Registros_Operarios",
                column: "Usu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_Registros_Turno_Id",
                table: "Tipos_Registros",
                column: "Turno_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Area_Id",
                table: "Usuarios",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Estado_Id",
                table: "Usuarios",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoIdent_Id",
                table: "Usuarios",
                column: "TipoIdent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsu_Id",
                table: "Usuarios",
                column: "TipoUsu_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros_Operarios");

            migrationBuilder.DropTable(
                name: "Tipos_Registros");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Tipos_Identificaciones");

            migrationBuilder.DropTable(
                name: "Tipos_Usuarios");
        }
    }
}
