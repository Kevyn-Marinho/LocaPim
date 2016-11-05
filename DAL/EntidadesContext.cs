using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model;
using System.Configuration;
namespace Dao
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<CartaoDeCredito> CartoesDeCredito { get; set; }
        public DbSet<CarteiraDeMotorista> CarteirasDeMotorista { get; set; }
        public DbSet<CategoriaCarro> Categorias { get; set; }
        public DbSet<Cidade> Cidades{ get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<ModeloCarro> Modelo { get; set; }
        public DbSet<OperadoraCartao> OperadorasDeCredito { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Setor> Setores{ get; set; }
        public DbSet<TipoDeContato> TiposDeContatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        public EntidadesContext()
            : base( @"Data Source=BUZZ\SQLEXPRESS;Initial Catalog=LocaPim;Integrated Security=True")
        {
            Database.Connection.ConnectionString = @"Data Source=BUZZ\SQLEXPRESS;Initial Catalog=LocaPim;Integrated Security=True";
        }
    }
}
