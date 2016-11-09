using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Model;
namespace TestesUnitarios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var paisCtl = new PaisCtl();
            var p1 = new Pais()
            {
                Nome = "Argentina"
            };
            var p2 = new Pais()
            {
                Nome = "Alemanha"
            };

            paisCtl.Adicionar(p1);
            paisCtl.Adicionar(p2);
            paisCtl.SalvarAlteracoes();

            foreach (var pais in paisCtl.Listar())
            {
                Console.WriteLine(pais.Nome);
            }

            Console.ReadLine();
        }
    }
}
