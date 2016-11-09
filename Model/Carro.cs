using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Carros")]
    public class Carro
    {
        [Key]
        public int IdCarro { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public bool Locado { get; set; }
        public decimal ValorDiaria { get; set; }
        public int QuantidadeLocacoes { get; set; }
        public virtual ModeloCarro Modelo { get; set; }
        public int IdModelo { get; set; }    
        public virtual Marca Marca { get; set; }
        public int IdMarca { get; set; }

    }
}
