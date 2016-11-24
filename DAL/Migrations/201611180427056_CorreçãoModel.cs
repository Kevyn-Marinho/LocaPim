namespace Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorreçãoModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carros", "Marca_IdMarcaCarro", "dbo.Marcas");
            DropForeignKey("dbo.Carros", "Modelo_IdModeloCarro", "dbo.ModeloCarroes");
            DropForeignKey("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta", "dbo.OperadoraCartaos");
            DropForeignKey("dbo.Contatos", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Enderecos", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Locacoes", "Cartao_IdCartaoDeCredito", "dbo.CartoesDeCredito");
            DropIndex("dbo.Carros", new[] { "Marca_IdMarcaCarro" });
            DropIndex("dbo.Carros", new[] { "Modelo_IdModeloCarro" });
            DropIndex("dbo.CartoesDeCredito", new[] { "Cliente_Id" });
            DropIndex("dbo.CartoesDeCredito", new[] { "Operadora_IdOperadoraCarta" });
            DropIndex("dbo.Contatos", new[] { "Pessoa_Id" });
            DropIndex("dbo.Enderecos", new[] { "Pessoa_Id" });
            DropIndex("dbo.Locacoes", new[] { "Cartao_IdCartaoDeCredito" });
            DropIndex("dbo.Locacoes", new[] { "Cliente_Id" });
            RenameColumn(table: "dbo.Carros", name: "Modelo_IdModeloCarro", newName: "IdModeloCarro");
            RenameColumn(table: "dbo.Locacoes", name: "Cartao_IdCartaoDeCredito", newName: "IdCartaoDeCredito");
            RenameColumn(table: "dbo.Locacoes", name: "Cliente_Id", newName: "Id");
            AddColumn("dbo.CartoesDeCredito", "IdOperadoraCartao", c => c.Int(nullable: false));
            AddColumn("dbo.Contatos", "contato", c => c.String(nullable: false));
            AlterColumn("dbo.Carros", "Placa", c => c.String(nullable: false));
            AlterColumn("dbo.Carros", "Marca_IdMarcaCarro", c => c.Int(nullable: false));
            AlterColumn("dbo.Carros", "IdModeloCarro", c => c.Int(nullable: false));
            AlterColumn("dbo.CartoesDeCredito", "NumeroCartao", c => c.String(nullable: false));
            AlterColumn("dbo.CartoesDeCredito", "NomeCartao", c => c.String(nullable: false));
            AlterColumn("dbo.CartoesDeCredito", "Cliente_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Pessoas", "Sobrenome", c => c.String(nullable: false));
            AlterColumn("dbo.Pessoas", "Rg", c => c.String(nullable: false));
            AlterColumn("dbo.Pessoas", "Cpf", c => c.String(nullable: false));
            AlterColumn("dbo.Contatos", "Pessoa_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Enderecos", "Pessoa_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacoes", "IdCartaoDeCredito", c => c.Int(nullable: false));
            AlterColumn("dbo.Locacoes", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Carros", "IdModeloCarro");
            CreateIndex("dbo.Carros", "Marca_IdMarcaCarro");
            CreateIndex("dbo.CartoesDeCredito", "Cliente_Id");
            CreateIndex("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta");
            CreateIndex("dbo.Contatos", "Pessoa_Id");
            CreateIndex("dbo.Enderecos", "Pessoa_Id");
            CreateIndex("dbo.Locacoes", "Id");
            CreateIndex("dbo.Locacoes", "IdCartaoDeCredito");
            AddForeignKey("dbo.Carros", "Marca_IdMarcaCarro", "dbo.Marcas", "IdMarcaCarro", cascadeDelete: true);
            AddForeignKey("dbo.Carros", "IdModeloCarro", "dbo.ModeloCarroes", "IdModeloCarro", cascadeDelete: true);
            AddForeignKey("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta", "dbo.OperadoraCartaos", "IdOperadoraCarta", cascadeDelete: true);
            AddForeignKey("dbo.Contatos", "Pessoa_Id", "dbo.Pessoas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Enderecos", "Pessoa_Id", "dbo.Pessoas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Locacoes", "IdCartaoDeCredito", "dbo.CartoesDeCredito", "IdCartaoDeCredito", cascadeDelete: true);
            DropColumn("dbo.Carros", "IdModelo");
            DropColumn("dbo.CartoesDeCredito", "IdOperadora");
            DropColumn("dbo.Contatos", "telefone");
            DropColumn("dbo.Locacoes", "IdCliente");
            DropColumn("dbo.Locacoes", "IdCartao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locacoes", "IdCartao", c => c.Int(nullable: false));
            AddColumn("dbo.Locacoes", "IdCliente", c => c.Int(nullable: false));
            AddColumn("dbo.Contatos", "telefone", c => c.String());
            AddColumn("dbo.CartoesDeCredito", "IdOperadora", c => c.Int(nullable: false));
            AddColumn("dbo.Carros", "IdModelo", c => c.Int(nullable: false));
            DropForeignKey("dbo.Locacoes", "IdCartaoDeCredito", "dbo.CartoesDeCredito");
            DropForeignKey("dbo.Enderecos", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Contatos", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta", "dbo.OperadoraCartaos");
            DropForeignKey("dbo.Carros", "IdModeloCarro", "dbo.ModeloCarroes");
            DropForeignKey("dbo.Carros", "Marca_IdMarcaCarro", "dbo.Marcas");
            DropIndex("dbo.Locacoes", new[] { "IdCartaoDeCredito" });
            DropIndex("dbo.Locacoes", new[] { "Id" });
            DropIndex("dbo.Enderecos", new[] { "Pessoa_Id" });
            DropIndex("dbo.Contatos", new[] { "Pessoa_Id" });
            DropIndex("dbo.CartoesDeCredito", new[] { "Operadora_IdOperadoraCarta" });
            DropIndex("dbo.CartoesDeCredito", new[] { "Cliente_Id" });
            DropIndex("dbo.Carros", new[] { "Marca_IdMarcaCarro" });
            DropIndex("dbo.Carros", new[] { "IdModeloCarro" });
            AlterColumn("dbo.Locacoes", "Id", c => c.Int());
            AlterColumn("dbo.Locacoes", "IdCartaoDeCredito", c => c.Int());
            AlterColumn("dbo.Enderecos", "Pessoa_Id", c => c.Int());
            AlterColumn("dbo.Contatos", "Pessoa_Id", c => c.Int());
            AlterColumn("dbo.Pessoas", "Cpf", c => c.String());
            AlterColumn("dbo.Pessoas", "Rg", c => c.String());
            AlterColumn("dbo.Pessoas", "Sobrenome", c => c.String());
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
            AlterColumn("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta", c => c.Int());
            AlterColumn("dbo.CartoesDeCredito", "Cliente_Id", c => c.Int());
            AlterColumn("dbo.CartoesDeCredito", "NomeCartao", c => c.String());
            AlterColumn("dbo.CartoesDeCredito", "NumeroCartao", c => c.String());
            AlterColumn("dbo.Carros", "IdModeloCarro", c => c.Int());
            AlterColumn("dbo.Carros", "Marca_IdMarcaCarro", c => c.Int());
            AlterColumn("dbo.Carros", "Placa", c => c.String());
            DropColumn("dbo.Contatos", "contato");
            DropColumn("dbo.CartoesDeCredito", "IdOperadoraCartao");
            RenameColumn(table: "dbo.Locacoes", name: "Id", newName: "Cliente_Id");
            RenameColumn(table: "dbo.Locacoes", name: "IdCartaoDeCredito", newName: "Cartao_IdCartaoDeCredito");
            RenameColumn(table: "dbo.Carros", name: "IdModeloCarro", newName: "Modelo_IdModeloCarro");
            CreateIndex("dbo.Locacoes", "Cliente_Id");
            CreateIndex("dbo.Locacoes", "Cartao_IdCartaoDeCredito");
            CreateIndex("dbo.Enderecos", "Pessoa_Id");
            CreateIndex("dbo.Contatos", "Pessoa_Id");
            CreateIndex("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta");
            CreateIndex("dbo.CartoesDeCredito", "Cliente_Id");
            CreateIndex("dbo.Carros", "Modelo_IdModeloCarro");
            CreateIndex("dbo.Carros", "Marca_IdMarcaCarro");
            AddForeignKey("dbo.Locacoes", "Cartao_IdCartaoDeCredito", "dbo.CartoesDeCredito", "IdCartaoDeCredito");
            AddForeignKey("dbo.Enderecos", "Pessoa_Id", "dbo.Pessoas", "Id");
            AddForeignKey("dbo.Contatos", "Pessoa_Id", "dbo.Pessoas", "Id");
            AddForeignKey("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta", "dbo.OperadoraCartaos", "IdOperadoraCarta");
            AddForeignKey("dbo.Carros", "Modelo_IdModeloCarro", "dbo.ModeloCarroes", "IdModeloCarro");
            AddForeignKey("dbo.Carros", "Marca_IdMarcaCarro", "dbo.Marcas", "IdMarcaCarro");
        }
    }
}
