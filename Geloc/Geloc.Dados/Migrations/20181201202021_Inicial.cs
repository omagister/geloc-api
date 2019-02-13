using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Geloc.Dados.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(maxLength: 10, nullable: false),
                    CNPJ = table.Column<string>(maxLength: 20, nullable: true),
                    CPF = table.Column<string>(maxLength: 14, nullable: true),
                    Sexo = table.Column<string>(maxLength: 10, nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    OutrosNoLocal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    ContratoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(nullable: false),
                    Adicional = table.Column<int>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: true),
                    DataRetorno = table.Column<DateTime>(nullable: true),
                    DataPagamento = table.Column<DateTime>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Desconto = table.Column<decimal>(nullable: false),
                    Acrescimo = table.Column<decimal>(nullable: false),
                    ValorAPagar = table.Column<decimal>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false),
                    ValorDeve = table.Column<decimal>(nullable: false),
                    Pago = table.Column<int>(nullable: false),
                    Situacao = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    EnderecoId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false),
                    telefonesSelecionados = table.Column<string>(nullable: true),
                    Renovado = table.Column<int>(nullable: false),
                    TotalEmMetros = table.Column<string>(nullable: true),
                    RetornouEm = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.ContratoId);
                    table.ForeignKey(
                        name: "FK_Contrato_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    endereco = table.Column<string>(nullable: true),
                    Ativo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_Email_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Ativo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false),
                    Referencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    TelefoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoTelefone = table.Column<string>(nullable: true),
                    Operadora = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Ativo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.TelefoneId);
                    table.ForeignKey(
                        name: "FK_Telefone_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategoriaContrato",
                columns: table => new
                {
                    ItemCategoriaContratoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaEquipamentoId = table.Column<int>(nullable: false),
                    PacoteAluguelId = table.Column<int>(nullable: false),
                    ContratoId = table.Column<int>(nullable: false),
                    UnidadesPorPacote = table.Column<int>(nullable: false),
                    QuantidadePacotes = table.Column<int>(nullable: false),
                    MedidaPacote = table.Column<string>(nullable: true),
                    quantidadeAlugada = table.Column<int>(nullable: false),
                    valorTotal = table.Column<decimal>(nullable: false),
                    descontoItem = table.Column<decimal>(nullable: false),
                    acrescimoItem = table.Column<decimal>(nullable: false),
                    ValorTotalAPagar = table.Column<decimal>(nullable: false),
                    DescricaoCategoria = table.Column<string>(nullable: true),
                    NomePacote = table.Column<string>(nullable: true),
                    ValorPacote = table.Column<decimal>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: true),
                    DataRetorno = table.Column<DateTime>(nullable: true),
                    RetornouEm = table.Column<DateTime>(nullable: true),
                    EnderecoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategoriaContrato", x => x.ItemCategoriaContratoId);
                    table.ForeignKey(
                        name: "FK_ItemCategoriaContrato_Contrato_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contrato",
                        principalColumn: "ContratoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_PessoaId",
                table: "Contrato",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Email_PessoaId",
                table: "Email",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PessoaId",
                table: "Endereco",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategoriaContrato_ContratoId",
                table: "ItemCategoriaContrato",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "ItemCategoriaContrato");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
