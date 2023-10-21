using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistency.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sueldobase = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formapago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formapago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valorunit = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumo", x => x.Id);
                    table.UniqueConstraint("AK_insumo_nombre", x => x.nombre);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "talla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talla", x => x.Id);
                    table.UniqueConstraint("AK_talla_descripcion", x => x.descripcion);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoestado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoestado", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipopersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipopersona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoproteccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoproteccion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_departamento_pais_PaisFk",
                        column: x => x.PaisFk,
                        principalTable: "pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoEstadoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estado_tipoestado_TipoEstadoIdFk",
                        column: x => x.TipoEstadoIdFk,
                        principalTable: "tipoestado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "userRol",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRol", x => new { x.UserId, x.RolId });
                    table.ForeignKey(
                        name: "FK_userRol_rol_RolId",
                        column: x => x.RolId,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRol_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepartamentoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipio_departamento_DepartamentoIdFk",
                        column: x => x.DepartamentoIdFk,
                        principalTable: "departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "prenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    prenda = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valorunitcop = table.Column<double>(type: "double", nullable: false),
                    valorunitusd = table.Column<double>(type: "double", nullable: false),
                    TipoProteccionIdFk = table.Column<int>(type: "int", nullable: false),
                    GeneroIdFk = table.Column<int>(type: "int", nullable: false),
                    EstadoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prenda", x => x.Id);
                    table.UniqueConstraint("AK_prenda_prenda", x => x.prenda);
                    table.ForeignKey(
                        name: "FK_prenda_estado_EstadoIdFk",
                        column: x => x.EstadoIdFk,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prenda_genero_GeneroIdFk",
                        column: x => x.GeneroIdFk,
                        principalTable: "genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prenda_tipoproteccion_TipoProteccionIdFk",
                        column: x => x.TipoProteccionIdFk,
                        principalTable: "tipoproteccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_cliente = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fecharegistro = table.Column<DateTime>(type: "datetime", nullable: false),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false),
                    TipoPersonaIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                    table.UniqueConstraint("AK_cliente_id_cliente", x => x.id_cliente);
                    table.ForeignKey(
                        name: "FK_cliente_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cliente_tipopersona_TipoPersonaIdFk",
                        column: x => x.TipoPersonaIdFk,
                        principalTable: "tipopersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idempleado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaingreso = table.Column<DateTime>(type: "datetime", nullable: false),
                    CargoIdFk = table.Column<int>(type: "int", nullable: false),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.Id);
                    table.UniqueConstraint("AK_empleado_idempleado", x => x.idempleado);
                    table.ForeignKey(
                        name: "FK_empleado_cargo_CargoIdFk",
                        column: x => x.CargoIdFk,
                        principalTable: "cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleado_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nit = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    razonsocial = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    representantelegal = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechacreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.UniqueConstraint("AK_empresa_nit", x => x.nit);
                    table.ForeignKey(
                        name: "FK_empresa_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nitproveedor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false),
                    TipoPersonaIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.Id);
                    table.UniqueConstraint("AK_proveedor_nitproveedor", x => x.nitproveedor);
                    table.ForeignKey(
                        name: "FK_proveedor_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedor_tipopersona_TipoPersonaIdFk",
                        column: x => x.TipoPersonaIdFk,
                        principalTable: "tipopersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumoprenda",
                columns: table => new
                {
                    PrendaIdFk = table.Column<int>(type: "int", nullable: false),
                    InsumoIdFk = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    PrendaId = table.Column<int>(type: "int", nullable: true),
                    InsumoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumoprenda", x => new { x.PrendaIdFk, x.InsumoIdFk });
                    table.ForeignKey(
                        name: "FK_insumoprenda_insumo_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "insumo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_insumoprenda_prenda_PrendaId",
                        column: x => x.PrendaId,
                        principalTable: "prenda",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codinv = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valorventacop = table.Column<double>(type: "double", nullable: false),
                    valorventausd = table.Column<double>(type: "double", nullable: false),
                    PrendaIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario", x => x.Id);
                    table.UniqueConstraint("AK_inventario_codinv", x => x.codinv);
                    table.ForeignKey(
                        name: "FK_inventario_prenda_PrendaIdFk",
                        column: x => x.PrendaIdFk,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    EmpleadoIdFk = table.Column<int>(type: "int", nullable: false),
                    ClienteIdFk = table.Column<int>(type: "int", nullable: false),
                    EstadoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orden_cliente_ClienteIdFk",
                        column: x => x.ClienteIdFk,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orden_empleado_EmpleadoIdFk",
                        column: x => x.EmpleadoIdFk,
                        principalTable: "empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orden_estado_EstadoIdFk",
                        column: x => x.EstadoIdFk,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    EmpleadoIdFk = table.Column<int>(type: "int", nullable: false),
                    ClienteIdFk = table.Column<int>(type: "int", nullable: false),
                    FormaPagoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_venta_cliente_ClienteIdFk",
                        column: x => x.ClienteIdFk,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_empleado_EmpleadoIdFk",
                        column: x => x.EmpleadoIdFk,
                        principalTable: "empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_formapago_FormaPagoIdFk",
                        column: x => x.FormaPagoIdFk,
                        principalTable: "formapago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumoproveedor",
                columns: table => new
                {
                    InsumoIdFk = table.Column<int>(type: "int", nullable: false),
                    ProveedorIdFk = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    InsumoId = table.Column<int>(type: "int", nullable: true),
                    ProvedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumoproveedor", x => new { x.InsumoIdFk, x.ProveedorIdFk });
                    table.ForeignKey(
                        name: "FK_insumoproveedor_insumo_InsumoId",
                        column: x => x.InsumoId,
                        principalTable: "insumo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_insumoproveedor_proveedor_ProvedorId",
                        column: x => x.ProvedorId,
                        principalTable: "proveedor",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventariotalla",
                columns: table => new
                {
                    InventarioIdFk = table.Column<int>(type: "int", nullable: false),
                    TallaIdFk = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    InventarioId = table.Column<int>(type: "int", nullable: true),
                    TallaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventariotalla", x => new { x.InventarioIdFk, x.TallaIdFk });
                    table.ForeignKey(
                        name: "FK_inventariotalla_inventario_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "inventario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_inventariotalla_talla_TallaId",
                        column: x => x.TallaId,
                        principalTable: "talla",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detalleorden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cantidadproducir = table.Column<int>(type: "int", nullable: false),
                    cantidadproducida = table.Column<int>(type: "int", nullable: false),
                    OrdenIdFk = table.Column<int>(type: "int", nullable: false),
                    PrendaIdFk = table.Column<int>(type: "int", nullable: false),
                    ColorIdFk = table.Column<int>(type: "int", nullable: false),
                    EstadoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleorden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleorden_color_ColorIdFk",
                        column: x => x.ColorIdFk,
                        principalTable: "color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleorden_estado_EstadoIdFk",
                        column: x => x.EstadoIdFk,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleorden_orden_OrdenIdFk",
                        column: x => x.OrdenIdFk,
                        principalTable: "orden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleorden_prenda_PrendaIdFk",
                        column: x => x.PrendaIdFk,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detalleventa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    valorunitario = table.Column<double>(type: "double", nullable: false),
                    VentaIdFk = table.Column<int>(type: "int", nullable: false),
                    InventarioIdFk = table.Column<int>(type: "int", nullable: false),
                    TallaIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleventa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleventa_inventario_InventarioIdFk",
                        column: x => x.InventarioIdFk,
                        principalTable: "inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleventa_talla_TallaIdFk",
                        column: x => x.TallaIdFk,
                        principalTable: "talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleventa_venta_VentaIdFk",
                        column: x => x.VentaIdFk,
                        principalTable: "venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_MunicipioIdFk",
                table: "cliente",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_TipoPersonaIdFk",
                table: "cliente",
                column: "TipoPersonaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_PaisFk",
                table: "departamento",
                column: "PaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleorden_ColorIdFk",
                table: "detalleorden",
                column: "ColorIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleorden_EstadoIdFk",
                table: "detalleorden",
                column: "EstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleorden_OrdenIdFk",
                table: "detalleorden",
                column: "OrdenIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleorden_PrendaIdFk",
                table: "detalleorden",
                column: "PrendaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleventa_InventarioIdFk",
                table: "detalleventa",
                column: "InventarioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleventa_TallaIdFk",
                table: "detalleventa",
                column: "TallaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleventa_VentaIdFk",
                table: "detalleventa",
                column: "VentaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_CargoIdFk",
                table: "empleado",
                column: "CargoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_MunicipioIdFk",
                table: "empleado",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_MunicipioIdFk",
                table: "empresa",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_estado_TipoEstadoIdFk",
                table: "estado",
                column: "TipoEstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_insumoprenda_InsumoId",
                table: "insumoprenda",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_insumoprenda_PrendaId",
                table: "insumoprenda",
                column: "PrendaId");

            migrationBuilder.CreateIndex(
                name: "IX_insumoproveedor_InsumoId",
                table: "insumoproveedor",
                column: "InsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_insumoproveedor_ProvedorId",
                table: "insumoproveedor",
                column: "ProvedorId");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_PrendaIdFk",
                table: "inventario",
                column: "PrendaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_inventariotalla_InventarioId",
                table: "inventariotalla",
                column: "InventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_inventariotalla_TallaId",
                table: "inventariotalla",
                column: "TallaId");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_DepartamentoIdFk",
                table: "municipio",
                column: "DepartamentoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_ClienteIdFk",
                table: "orden",
                column: "ClienteIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_EmpleadoIdFk",
                table: "orden",
                column: "EmpleadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_EstadoIdFk",
                table: "orden",
                column: "EstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_EstadoIdFk",
                table: "prenda",
                column: "EstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_GeneroIdFk",
                table: "prenda",
                column: "GeneroIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_TipoProteccionIdFk",
                table: "prenda",
                column: "TipoProteccionIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_MunicipioIdFk",
                table: "proveedor",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_TipoPersonaIdFk",
                table: "proveedor",
                column: "TipoPersonaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_userRol_RolId",
                table: "userRol",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_venta_ClienteIdFk",
                table: "venta",
                column: "ClienteIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_EmpleadoIdFk",
                table: "venta",
                column: "EmpleadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_FormaPagoIdFk",
                table: "venta",
                column: "FormaPagoIdFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleorden");

            migrationBuilder.DropTable(
                name: "detalleventa");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "insumoprenda");

            migrationBuilder.DropTable(
                name: "insumoproveedor");

            migrationBuilder.DropTable(
                name: "inventariotalla");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "userRol");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "orden");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "insumo");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "talla");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "formapago");

            migrationBuilder.DropTable(
                name: "prenda");

            migrationBuilder.DropTable(
                name: "tipopersona");

            migrationBuilder.DropTable(
                name: "cargo");

            migrationBuilder.DropTable(
                name: "municipio");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "tipoproteccion");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "tipoestado");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
