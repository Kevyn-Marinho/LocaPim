using System.Data.Entity;
using System.Linq;
using System.Net;
using System;
using Dao;
using Model;

namespace Business
{
    public class TiposDeContatosController
    {
        private EntidadesContext contexto = new EntidadesContext();


        // GET: TiposDeContatos/Details/5
        public TipoDeContato Details(int id)
        {
            TipoDeContato tipoDeContato = contexto.TiposDeContatos.Find(id);
            if (tipoDeContato == null)
            {
                throw new Exception("Contato não encontrado");
            }
            return tipoDeContato;            
        }

        public void Create(TipoDeContato tipoDeContato)
        {
            contexto.TiposDeContatos.Add(tipoDeContato);
            contexto.SaveChanges();
        }

        public void Edit(int id, TipoDeContato novoContato)
        {
            TipoDeContato velhoContato = new Dao.TipoDeContatoDao(contexto).BuscaPorId(id);

            if (velhoContato == null)
            {
                throw new Exception("Tipo de contato não encontrado");
            }
            
        }

        public void Delete(int id)
        {
            TipoDeContato tipoDeContato = contexto.TiposDeContatos.Find(id);
            contexto.TiposDeContatos.Remove(tipoDeContato);
            contexto.SaveChanges();
        }


    }
}
