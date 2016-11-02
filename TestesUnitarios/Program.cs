using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios
{
    class Program
    {
        static void Main(string[] args)
        {
            SetorTest setorTest = new SetorTest();
            setorTest.Adicionar();
            //setorTest.Editar();
            //setorTest.Excluir();
            setorTest.Listar();

            //CargoTest cargoTest = new CargoTest();
            //cargoTest.Adicionar();
            //cargoTest.Editar();
            //cargoTest.Listar();


            //FuncionarioTest funcionarioTest = new FuncionarioTest();
            //funcionarioTest.Adiciona();
            //funcionarioTest.Listar();
            //Console.ReadKey();
            //funcionarioTest.Alterar();
            //funcionarioTest.Listar();
            
            Console.ReadLine();
        }
    }
}
