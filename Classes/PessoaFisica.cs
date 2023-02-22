using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroClientes.Interfaces;

namespace CadastroClientes.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public int cpf { get; set; }
        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;
                return resultado;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 3.5f;
                return resultado;
            }
            else
            {
                float resultado = (rendimento / 100) * 5;
                return resultado;
            }

        }

        public bool ValidarDataNasc(string dataNasc)
        {
            if (DateTime.TryParse(dataNasc, out DateTime dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public DateTime ValidarDataNasc(DateTime dataNasc)
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;

            return date1;
        }

        // public bool ValidarDataNasc(string dataNasc)
        // {
        //     throw new NotImplementedException();
        // }

        bool IPessoaFisica.ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}