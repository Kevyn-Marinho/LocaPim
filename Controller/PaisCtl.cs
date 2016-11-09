using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;
using System.Data.Entity;

namespace Business
{
    public class PaisCtl
    {
        private EntidadesContext contexto;
        public PaisCtl()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adicionar(Pais pais)
        {
            if (String.IsNullOrEmpty(pais.Nome))
                throw new Exception("Por favor insira o nome do país referente.");

            var dao = new PaisDao(contexto);
            dao.Adicionar(pais);

        }

        public void SalvarAlteracoes()
        {
            new PaisDao(contexto).SaveChanges();
        }

        public void Excluir(Pais pais)
        {
            new PaisDao(contexto).Excluir(pais);
        }

        public IList<Pais> Listar()
        {
            return new PaisDao(contexto).Listar();
        }
        public Pais BuscaPorId(int id)
        {
            return new PaisDao(contexto).BuscaPorId(id);
        }
    }
}
