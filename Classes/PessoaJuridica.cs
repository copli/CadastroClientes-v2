using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroClientes.Interfaces;

namespace CadastroClientes.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public int cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                float resultado = (rendimento / 100) * 3;
                return resultado;
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 5;
                return resultado;
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                float resultado = (rendimento / 100) * 7;
                return resultado;
            }
            else
            {
                float resultado = (rendimento / 100) * 9;
                return resultado;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}