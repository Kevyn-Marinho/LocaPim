using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;
namespace TestesUnitarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais pais = new Pais()
            {
                Nome = "Brasil"
            };
            Estado estado = new Estado()
            {
                Pais = pais,
                Sigla = "SP",
                Uf = "São Paulo"
            };

            var paisDao = new PaisDao();
            paisDao.Adicionar(pais);

            var estadoDao = new EstadoDao();
            estadoDao.Adicionar(estado);
            estadoDao.SaveChanges();
            paisDao.Listar();
            estadoDao.Listar();
            
            

            Console.ReadLine();
        }
    }
}
