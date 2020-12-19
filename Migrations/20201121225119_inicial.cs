using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DAutores",
                columns: table => new
                {
                    autorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeautor = table.Column<string>(nullable: true),
                    pais = table.Column<string>(nullable: true),
                    lingua = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAutores", x => x.autorId);
                });

            migrationBuilder.CreateTable(
                name: "DEditoras",
                columns: table => new
                {
                    editoraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeEditora = table.Column<string>(nullable: true),
                    telefone = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    morada = table.Column<string>(nullable: true),
                    numeroPorta = table.Column<int>(nullable: false),
                    fracao = table.Column<string>(nullable: true),
                    codigoPostal = table.Column<int>(nullable: false),
                    webSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEditoras", x => x.editoraId);
                });

            migrationBuilder.CreateTable(
                name: "DUsuarios",
                columns: table => new
                {
                    usuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeUsuario = table.Column<string>(nullable: true),
                    telefone = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    morada = table.Column<string>(nullable: true),
                    numeroPorta = table.Column<int>(nullable: false),
                    fracao = table.Column<string>(nullable: true),
                    codigoPostal = table.Column<int>(nullable: false),
                    dataNascimento = table.Column<DateTime>(nullable: true),
                    bilheteIdentidade = table.Column<int>(nullable: false),
                    contribuinte = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DUsuarios", x => x.usuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    localidadeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Local = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.localidadeId);
                });

            migrationBuilder.CreateTable(
                name: "DLivros",
                columns: table => new
                {
                    livroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(nullable: true),
                    ano = table.Column<int>(nullable: false),
                    genero = table.Column<string>(nullable: true),
                    preco = table.Column<decimal>(nullable: false),
                    quantidade = table.Column<int>(nullable: false),
                    editoraId = table.Column<int>(nullable: true),
                    usuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLivros", x => x.livroId);
                    table.ForeignKey(
                        name: "FK_DLivros_DEditoras_editoraId",
                        column: x => x.editoraId,
                        principalTable: "DEditoras",
                        principalColumn: "editoraId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DLivros_DUsuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "DUsuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Autorias",
                columns: table => new
                {
                    autoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    livroId = table.Column<int>(nullable: false),
                    autorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorias", x => x.autoriaId);
                    table.ForeignKey(
                        name: "FK_Autorias_DAutores_autorId",
                        column: x => x.autorId,
                        principalTable: "DAutores",
                        principalColumn: "autorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Autorias_DLivros_livroId",
                        column: x => x.livroId,
                        principalTable: "DLivros",
                        principalColumn: "livroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DRequisicoes",
                columns: table => new
                {
                    requisicaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataRequisicao = table.Column<DateTime>(nullable: false),
                    dataDevolucao = table.Column<DateTime>(nullable: false),
                    livroId = table.Column<int>(nullable: false),
                    localidadeId = table.Column<int>(nullable: false),
                    usuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DRequisicoes", x => x.requisicaoId);
                    table.ForeignKey(
                        name: "FK_DRequisicoes_DLivros_livroId",
                        column: x => x.livroId,
                        principalTable: "DLivros",
                        principalColumn: "livroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DRequisicoes_Localidades_localidadeId",
                        column: x => x.localidadeId,
                        principalTable: "Localidades",
                        principalColumn: "localidadeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DRequisicoes_DUsuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "DUsuarios",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DAutores",
                columns: new[] { "autorId", "lingua", "nomeautor", "pais" },
                values: new object[,]
                {
                    { 1, "português", "Jose Saramago", "Portugal" },
                    { 2, "português", "Fernando Pessoa", "Portugal" },
                    { 3, "português", "Eça de Queirós", "Portugal" },
                    { 4, "português", "Miguel Torga", "Portugal" }
                });

            migrationBuilder.InsertData(
                table: "DEditoras",
                columns: new[] { "editoraId", "codigoPostal", "email", "fracao", "morada", "nomeEditora", "numeroPorta", "telefone", "webSite" },
                values: new object[,]
                {
                    { 1, 4099023, "porto@porto.com.pt", "na", "Rua da Restauração", "Porto", 365, 226088322, "www.portoeditora.pt" },
                    { 2, 1500499, "bertrand@editoa.com.pt", "na", "Rua Professor Jorge Silva Horta", "Bertrand Editora", 1, 217626000, "www.bertrandeditora.pt" },
                    { 3, 42610038, "leya@editora.com.pt", "na", "Rua Cidade de Córdova", "Leya", 2, 214272200, "www.leya.com" }
                });

            migrationBuilder.InsertData(
                table: "DUsuarios",
                columns: new[] { "usuarioId", "bilheteIdentidade", "codigoPostal", "contribuinte", "dataNascimento", "email", "fracao", "morada", "nomeUsuario", "numeroPorta", "telefone" },
                values: new object[,]
                {
                    { 1, 6666666, 2825420, 294260250, null, "aecmar@hotmail.com", "anexo a", "Rua Vitimas da Guerra", "Alexandre Couto", 30, 222222222 },
                    { 2, 7777777, 1234567, 289076145, null, "jg@hotmail.com", "na", "Rua Lisboa", "João Golçalves", 40, 333333333 },
                    { 3, 8888888, 7654321, 876956456, null, "apjose@hotmail.com", "2E", "Rua Almirante reis", "Pedro Jose", 3, 444444444 }
                });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "localidadeId", "Local" },
                values: new object[,]
                {
                    { 1, "Lisboa" },
                    { 2, "Porto" }
                });

            migrationBuilder.InsertData(
                table: "DLivros",
                columns: new[] { "livroId", "ano", "editoraId", "genero", "preco", "quantidade", "titulo", "usuarioId" },
                values: new object[,]
                {
                    { 1, 1995, 1, "Romance", 17m, 100, "Ensaio sobre a Cegueira", null },
                    { 4, 1940, 1, "Poesia", 10m, 150, "Bichos", null },
                    { 2, 1946, 2, "Poesia", 18m, 150, "Poemas Completos de Alberto Caeiro", null },
                    { 3, 1878, 3, "Romance", 8m, 150, "O Primo Basílio", null }
                });

            migrationBuilder.InsertData(
                table: "Autorias",
                columns: new[] { "autoriaId", "autorId", "livroId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 4, 4, 4 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "DRequisicoes",
                columns: new[] { "requisicaoId", "dataDevolucao", "dataRequisicao", "livroId", "localidadeId", "usuarioId" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, null },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autorias_autorId",
                table: "Autorias",
                column: "autorId");

            migrationBuilder.CreateIndex(
                name: "IX_Autorias_livroId",
                table: "Autorias",
                column: "livroId");

            migrationBuilder.CreateIndex(
                name: "IX_DLivros_editoraId",
                table: "DLivros",
                column: "editoraId");

            migrationBuilder.CreateIndex(
                name: "IX_DLivros_usuarioId",
                table: "DLivros",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DRequisicoes_livroId",
                table: "DRequisicoes",
                column: "livroId");

            migrationBuilder.CreateIndex(
                name: "IX_DRequisicoes_localidadeId",
                table: "DRequisicoes",
                column: "localidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_DRequisicoes_usuarioId",
                table: "DRequisicoes",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autorias");

            migrationBuilder.DropTable(
                name: "DRequisicoes");

            migrationBuilder.DropTable(
                name: "DAutores");

            migrationBuilder.DropTable(
                name: "DLivros");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "DEditoras");

            migrationBuilder.DropTable(
                name: "DUsuarios");
        }
    }
}
