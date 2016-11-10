using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace Dao
{
    class EnderecoDao : IDao<Endereco>
    {
        private EntidadesContext contexto;

        public EnderecoDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(Endereco endereco)
        {
            try
            {
                contexto.Enderecos.Add(endereco);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void SaveChanges()
        {
            try
            {
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Endereco endereco)
        {
            try
            {
                contexto.Enderecos.Remove(endereco);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Endereco> Listar()
        {
            try
            {
                return contexto.Enderecos.ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void FecharConexao()
        {
            contexto.Dispose();
        }    
    }
}
