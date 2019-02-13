using Microsoft.EntityFrameworkCore.Migrations;

namespace Geloc.Dados.Migrations
{
    public partial class incluindoVarChar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Pessoas_PessoaId",
                table: "Contrato");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_Pessoas_PessoaId",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pessoas_PessoaId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCategoriaContrato_Contrato_ContratoId",
                table: "ItemCategoriaContrato");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Pessoas_PessoaId",
                table: "Telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCategoriaContrato",
                table: "ItemCategoriaContrato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contrato",
                table: "Contrato");

            migrationBuilder.RenameTable(
                name: "Telefone",
                newName: "Telefones");

            migrationBuilder.RenameTable(
                name: "ItemCategoriaContrato",
                newName: "ItensCategoriaContrato");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Email",
                newName: "Emails");

            migrationBuilder.RenameTable(
                name: "Contrato",
                newName: "Contratos");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefones",
                newName: "IX_Telefones_PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemCategoriaContrato_ContratoId",
                table: "ItensCategoriaContrato",
                newName: "IX_ItensCategoriaContrato_ContratoId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_PessoaId",
                table: "Enderecos",
                newName: "IX_Enderecos_PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Email_PessoaId",
                table: "Emails",
                newName: "IX_Emails_PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Contrato_PessoaId",
                table: "Contratos",
                newName: "IX_Contratos_PessoaId");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Pessoas",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pessoas",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Pessoas",
                type: "varchar(14)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Pessoas",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoTelefone",
                table: "Telefones",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Operadora",
                table: "Telefones",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Telefones",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Telefones",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "valorTotal",
                table: "ItensCategoriaContrato",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "descontoItem",
                table: "ItensCategoriaContrato",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "acrescimoItem",
                table: "ItensCategoriaContrato",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalAPagar",
                table: "ItensCategoriaContrato",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPacote",
                table: "ItensCategoriaContrato",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "NomePacote",
                table: "ItensCategoriaContrato",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedidaPacote",
                table: "ItensCategoriaContrato",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoCategoria",
                table: "ItensCategoriaContrato",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Uf",
                table: "Enderecos",
                type: "varchar(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "Enderecos",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Municipio",
                table: "Enderecos",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Enderecos",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Enderecos",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Enderecos",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "Emails",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefonesSelecionados",
                table: "Contratos",
                type: "varchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPago",
                table: "Contratos",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDeve",
                table: "Contratos",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAPagar",
                table: "Contratos",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Contratos",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "TotalEmMetros",
                table: "Contratos",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Situacao",
                table: "Contratos",
                type: "varchar",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Contratos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Desconto",
                table: "Contratos",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Acrescimo",
                table: "Contratos",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "TelefoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensCategoriaContrato",
                table: "ItensCategoriaContrato",
                column: "ItemCategoriaContratoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos",
                column: "ContratoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Pessoas_PessoaId",
                table: "Contratos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Pessoas_PessoaId",
                table: "Emails",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensCategoriaContrato_Contratos_ContratoId",
                table: "ItensCategoriaContrato",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "ContratoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Pessoas_PessoaId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Pessoas_PessoaId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_PessoaId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensCategoriaContrato_Contratos_ContratoId",
                table: "ItensCategoriaContrato");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Pessoas_PessoaId",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensCategoriaContrato",
                table: "ItensCategoriaContrato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos");

            migrationBuilder.RenameTable(
                name: "Telefones",
                newName: "Telefone");

            migrationBuilder.RenameTable(
                name: "ItensCategoriaContrato",
                newName: "ItemCategoriaContrato");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "Email");

            migrationBuilder.RenameTable(
                name: "Contratos",
                newName: "Contrato");

            migrationBuilder.RenameIndex(
                name: "IX_Telefones_PessoaId",
                table: "Telefone",
                newName: "IX_Telefone_PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensCategoriaContrato_ContratoId",
                table: "ItemCategoriaContrato",
                newName: "IX_ItemCategoriaContrato_ContratoId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_PessoaId",
                table: "Endereco",
                newName: "IX_Endereco_PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Emails_PessoaId",
                table: "Email",
                newName: "IX_Email_PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Contratos_PessoaId",
                table: "Contrato",
                newName: "IX_Contrato_PessoaId");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Pessoas",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Pessoas",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Pessoas",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Pessoas",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoTelefone",
                table: "Telefone",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Operadora",
                table: "Telefone",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Telefone",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Telefone",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "valorTotal",
                table: "ItemCategoriaContrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "descontoItem",
                table: "ItemCategoriaContrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "acrescimoItem",
                table: "ItemCategoriaContrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalAPagar",
                table: "ItemCategoriaContrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPacote",
                table: "ItemCategoriaContrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "NomePacote",
                table: "ItemCategoriaContrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedidaPacote",
                table: "ItemCategoriaContrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoCategoria",
                table: "ItemCategoriaContrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Uf",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)");

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Municipio",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "endereco",
                table: "Email",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "telefonesSelecionados",
                table: "Contrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPago",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDeve",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAPagar",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "TotalEmMetros",
                table: "Contrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Situacao",
                table: "Contrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Contrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Desconto",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Acrescimo",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone",
                column: "TelefoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCategoriaContrato",
                table: "ItemCategoriaContrato",
                column: "ItemCategoriaContratoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contrato",
                table: "Contrato",
                column: "ContratoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Pessoas_PessoaId",
                table: "Contrato",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Pessoas_PessoaId",
                table: "Email",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pessoas_PessoaId",
                table: "Endereco",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCategoriaContrato_Contrato_ContratoId",
                table: "ItemCategoriaContrato",
                column: "ContratoId",
                principalTable: "Contrato",
                principalColumn: "ContratoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Pessoas_PessoaId",
                table: "Telefone",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
