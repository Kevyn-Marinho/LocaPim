using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;
namespace Business
{
    public class LocacaoCtl
    {
        public void RealizaLocacao(Locacao locacao)
        {
            bool maior = this.VerificaIdade(locacao.Cliente);
            bool carteiraDefinitiva = this.VerificaCarteira(locacao.Cliente.Carteira);

            if (maior && carteiraDefinitiva && !locacao.Carro.Locado)
            {
                LocacaoDao dao = new LocacaoDao(locacao);
                try
                {
                    dao.RealizaLocacao();
                } catch(Exception ex)
                {
                    throw new Exception("Não foi possível realizar sua locação, por favor tente novamente mais tarde!\n" + 
                    "Error Message:" + ex.Message);
                }
            }

        }

        private bool VerificaIdade(Cliente cliente) 
        {
            var anoNascimento = cliente.DataNascimento.Year;
            var mesNascimento = cliente.DataNascimento.Month;
            var diaNascimento = cliente.DataNascimento.Day;
            var anoAtual = DateTime.Now.Year;
            var mesAtual = DateTime.Now.Month;
            var diaAtual = DateTime.Now.Day;

            if ((anoAtual - anoNascimento) > 21)
            {
                return true;
            }
            else if ((anoAtual - anoNascimento) == 21)
            {
                if (mesNascimento < mesAtual)
                {
                return true;
                }
                else
                {
                    if (mesNascimento == mesAtual)
                    {
                        if (diaAtual <= diaNascimento)
                        {
                            return true;
                        }
                    }
                }
                
            }
            return false;
        }

        private bool VerificaCarteira(CarteiraDeMotorista carteira)
        {
            var anoEmissao = carteira.DataEmissao.Year;
            var mesEmissao = carteira.DataEmissao.Month;
            var diaEmissao = carteira.DataEmissao.Day;
            var anoAtual = DateTime.Now.Year;
            var mesAtual = DateTime.Now.Month;
            var diaAtual = DateTime.Now.Day;

            if ((anoAtual - anoEmissao) > 2)
            {
                return true;
            }
            else if ((anoAtual - anoEmissao) == 2)
            {
                if (mesEmissao < mesAtual)
                {
                    return true;
                }
                else
                {
                    if (mesEmissao == mesAtual)
                    {
                        if (diaAtual <= diaEmissao)
                        {
                            return true;
                        }
                    }
                }

            }


            return false;
        }
    }
}
