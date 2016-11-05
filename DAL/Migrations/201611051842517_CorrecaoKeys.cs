namespace Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargos",
                c => new
                    {
                        IdCargo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Nome = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        IdSetor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCargo)
                .ForeignKey("dbo.Setores", t => t.IdSetor, cascadeDelete: true)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "dbo.Setores",
                c => new
                    {
                        IdSetor = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdSetor);
            
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        IdCarro = c.Int(nullable: false, identity: true),
                        Chassi = c.String(),
                        Placa = c.String(),
                        DataFabricacao = c.DateTime(nullable: false),
                        DataAquisicao = c.DateTime(nullable: false),
                        Locado = c.Boolean(nullable: false),
                        ValorDiaria = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantidadeLocacoes = c.Int(nullable: false),
                        IdModelo = c.Int(nullable: false),
                        IdMarca = c.Int(nullable: false),
                        Marca_IdMarcaCarro = c.Int(),
                        Modelo_IdModeloCarro = c.Int(),
                    })
                .PrimaryKey(t => t.IdCarro)
                .ForeignKey("dbo.Marcas", t => t.Marca_IdMarcaCarro)
                .ForeignKey("dbo.ModeloCarroes", t => t.Modelo_IdModeloCarro)
                .Index(t => t.Marca_IdMarcaCarro)
                .Index(t => t.Modelo_IdModeloCarro);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        IdMarcaCarro = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdMarcaCarro);
            
            CreateTable(
                "dbo.ModeloCarroes",
                c => new
                    {
                        IdModeloCarro = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        IdMarca = c.Int(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                        Categoria_IdCategoriaCarro = c.Int(),
                        Marca_IdMarcaCarro = c.Int(),
                    })
                .PrimaryKey(t => t.IdModeloCarro)
                .ForeignKey("dbo.Categoria", t => t.Categoria_IdCategoriaCarro)
                .ForeignKey("dbo.Marcas", t => t.Marca_IdMarcaCarro)
                .Index(t => t.Categoria_IdCategoriaCarro)
                .Index(t => t.Marca_IdMarcaCarro);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        IdCategoriaCarro = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdCategoriaCarro);
            
            CreateTable(
                "dbo.Cnhs",
                c => new
                    {
                        Cnh = c.String(nullable: false, maxLength: 128),
                        DataEmissao = c.DateTime(nullable: false),
                        Vencimento = c.DateTime(nullable: false),
                        Tipo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Cnh);
            
            CreateTable(
                "dbo.CartoesDeCredito",
                c => new
                    {
                        IdCartaoDeCredito = c.Int(nullable: false, identity: true),
                        Validade = c.DateTime(nullable: false),
                        NumeroCartao = c.String(),
                        CodigoSeguranca = c.Int(nullable: false),
                        NomeCartao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        IdCliente = c.Int(nullable: false),
                        IdOperadora = c.Int(nullable: false),
                        Cliente_Id = c.Int(),
                        Operadora_IdOperadoraCarta = c.Int(),
                    })
                .PrimaryKey(t => t.IdCartaoDeCredito)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.OperadoraCartaos", t => t.Operadora_IdOperadoraCarta)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Operadora_IdOperadoraCarta);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        Rg = c.String(),
                        Cpf = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OperadoraCartaos",
                c => new
                    {
                        IdOperadoraCarta = c.Int(nullable: false, identity: true),
                        Bandeira = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdOperadoraCarta);
            
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        IdCidade = c.Int(nullable: false, identity: true),
                        NomeCidade = c.String(),
                        Estado_IdEstado = c.Int(),
                    })
                .PrimaryKey(t => t.IdCidade)
                .ForeignKey("dbo.Estados", t => t.Estado_IdEstado)
                .Index(t => t.Estado_IdEstado);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        IdEstado = c.Int(nullable: false, identity: true),
                        Uf = c.String(),
                        Sigla = c.String(),
                        Pais_IdPais = c.Int(),
                    })
                .PrimaryKey(t => t.IdEstado)
                .ForeignKey("dbo.Paises", t => t.Pais_IdPais)
                .Index(t => t.Pais_IdPais);
            
            CreateTable(
                "dbo.Paises",
                c => new
                    {
                        IdPais = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdPais);
            
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        IdContato = c.Int(nullable: false, identity: true),
                        telefone = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        IdPessoa = c.Int(nullable: false),
                        IdTipoDeContato = c.Int(nullable: false),
                        Pessoa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdContato)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id)
                .ForeignKey("dbo.TiposDeContatos", t => t.IdTipoDeContato, cascadeDelete: true)
                .Index(t => t.IdTipoDeContato)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.TiposDeContatos",
                c => new
                    {
                        IdTipoDeContato = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoDeContato);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        IdEndereco = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(nullable: false),
                        Numero = c.String(),
                        Complemento = c.String(),
                        IdCidade = c.Int(nullable: false),
                        IdPessoa = c.Int(nullable: false),
                        Pessoa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdEndereco)
                .ForeignKey("dbo.Cidades", t => t.IdCidade, cascadeDelete: true)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id)
                .Index(t => t.IdCidade)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.Locacoes",
                c => new
                    {
                        IdLocacao = c.Int(nullable: false, identity: true),
                        IdCliente = c.Int(nullable: false),
                        IdCartao = c.Int(nullable: false),
                        IdCarro = c.Int(nullable: false),
                        Cartao_IdCartaoDeCredito = c.Int(),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdLocacao)
                .ForeignKey("dbo.Carros", t => t.IdCarro, cascadeDelete: true)
                .ForeignKey("dbo.CartoesDeCredito", t => t.Cartao_IdCartaoDeCredito)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.IdCarro)
                .Index(t => t.Cartao_IdCartaoDeCredito)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        NivelDeAcesso = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        IdFuncionario = c.Int(nullable: false),
                        Funcionario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_Id)
                .Index(t => t.Funcionario_Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Carteira_Cnh = c.String(maxLength: 128),
                        IdCliente = c.Int(nullable: false),
                        IdCarteiraDeMotorista = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Id)
                .ForeignKey("dbo.Cnhs", t => t.Carteira_Cnh)
                .Index(t => t.Id)
                .Index(t => t.Carteira_Cnh);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Usuario = c.Boolean(nullable: false),
                        IdCargo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Id)
                .ForeignKey("dbo.Cargos", t => t.IdCargo, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.IdCargo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "IdCargo", "dbo.Cargos");
            DropForeignKey("dbo.Funcionarios", "Id", "dbo.Pessoas");
            DropForeignKey("dbo.Clientes", "Carteira_Cnh", "dbo.Cnhs");
            DropForeignKey("dbo.Clientes", "Id", "dbo.Pessoas");
            DropForeignKey("dbo.Usuarios", "Funcionario_Id", "dbo.Funcionarios");
            DropForeignKey("dbo.Locacoes", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Locacoes", "Cartao_IdCartaoDeCredito", "dbo.CartoesDeCredito");
            DropForeignKey("dbo.Locacoes", "IdCarro", "dbo.Carros");
            DropForeignKey("dbo.Enderecos", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Enderecos", "IdCidade", "dbo.Cidades");
            DropForeignKey("dbo.Contatos", "IdTipoDeContato", "dbo.TiposDeContatos");
            DropForeignKey("dbo.Contatos", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Cidades", "Estado_IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Estados", "Pais_IdPais", "dbo.Paises");
            DropForeignKey("dbo.CartoesDeCredito", "Operadora_IdOperadoraCarta", "dbo.OperadoraCartaos");
            DropForeignKey("dbo.CartoesDeCredito", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Carros", "Modelo_IdModeloCarro", "dbo.ModeloCarroes");
            DropForeignKey("dbo.ModeloCarroes", "Marca_IdMarcaCarro", "dbo.Marcas");
            DropForeignKey("dbo.ModeloCarroes", "Categoria_IdCategoriaCarro", "dbo.Categoria");
            DropForeignKey("dbo.Carros", "Marca_IdMarcaCarro", "dbo.Marcas");
            DropForeignKey("dbo.Cargos", "IdSetor", "dbo.Setores");
            DropIndex("dbo.Funcionarios", new[] { "IdCargo" });
            DropIndex("dbo.Funcionarios", new[] { "Id" });
            DropIndex("dbo.Clientes", new[] { "Carteira_Cnh" });
            DropIndex("dbo.Clientes", new[] { "Id" });
            DropIndex("dbo.Usuarios", new[] { "Funcionario_Id" });
            DropIndex("dbo.Locacoes", new[] { "Cliente_Id" });
            DropIndex("dbo.Locacoes", new[] { "Cartao_IdCartaoDeCredito" });
            DropIndex("dbo.Locacoes", new[] { "IdCarro" });
            DropIndex("dbo.Enderecos", new[] { "Pessoa_Id" });
            DropIndex("dbo.Enderecos", new[] { "IdCidade" });
            DropIndex("dbo.Contatos", new[] { "Pessoa_Id" });
            DropIndex("dbo.Contatos", new[] { "IdTipoDeContato" });
            DropIndex("dbo.Estados", new[] { "Pais_IdPais" });
            DropIndex("dbo.Cidades", new[] { "Estado_IdEstado" });
            DropIndex("dbo.CartoesDeCredito", new[] { "Operadora_IdOperadoraCarta" });
            DropIndex("dbo.CartoesDeCredito", new[] { "Cliente_Id" });
            DropIndex("dbo.ModeloCarroes", new[] { "Marca_IdMarcaCarro" });
            DropIndex("dbo.ModeloCarroes", new[] { "Categoria_IdCategoriaCarro" });
            DropIndex("dbo.Carros", new[] { "Modelo_IdModeloCarro" });
            DropIndex("dbo.Carros", new[] { "Marca_IdMarcaCarro" });
            DropIndex("dbo.Cargos", new[] { "IdSetor" });
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Locacoes");
            DropTable("dbo.Enderecos");
            DropTable("dbo.TiposDeContatos");
            DropTable("dbo.Contatos");
            DropTable("dbo.Paises");
            DropTable("dbo.Estados");
            DropTable("dbo.Cidades");
            DropTable("dbo.OperadoraCartaos");
            DropTable("dbo.Pessoas");
            DropTable("dbo.CartoesDeCredito");
            DropTable("dbo.Cnhs");
            DropTable("dbo.Categoria");
            DropTable("dbo.ModeloCarroes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Carros");
            DropTable("dbo.Setores");
            DropTable("dbo.Cargos");
        }
    }
}
