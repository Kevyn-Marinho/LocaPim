using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace Controller
{
    public class CarroController
    {
        private Carro carro;
        public CarroController(Carro carro)
        {
            this.carro = carro;

            if (this.carro.Marca == null)
            {
                this.carro.Marca = new MarcaCarro();
            }
            
            if (this.carro.Modelo == null)
            {
                this.carro.Modelo = new ModeloCarro();
            }

        }
        public CarroController()
        {
            new CarroController(new Carro());
        }

        public string Adiciona() 
        {
            if (this.carro.Chassi == null)
                return "Número do chassi não informado.";

            if (this.carro.Placa == null)
                return "Placa não informada.";
        
            CarroDAO dao = new CarroDAO(this.carro);

            try
            {
                dao.Incluir();
                return "Adicionado Com Sucesso!!";
            }catch(Exception e){
                throw new Exception("Tivemos um problema ao realizar seu cadastro, tente novamente mais tarde.");
            }
            
        }

        public IList<Carro> ListaFrota()
        {
            IList<Carro> frota;
            try
            {
                frota = new CarroDAO().Listar();
                return frota;
                
            }catch(Exception ex)
            {
                return new List<Carro>();
            }

        }



    }
}
