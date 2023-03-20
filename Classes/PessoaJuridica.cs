using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CadastroClientes.Interfaces;

namespace CadastroClientes.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }
        public string Caminho { get; private set; } = "Database/PessoaJurica.csv";


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
        // fonte: https://www.4devs.com.br/
        // 18  CARACTERES - 31.876.411/0001-79
        // 14 CARACTERES - 27379542000173
        {
            bool retornoCnpjValido14 = Regex.IsMatch(cnpj, @"^(\d{14})$");

            if (retornoCnpjValido14)
            {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                }

            }


            bool retornoCnpjValido18 = Regex.IsMatch(cnpj, @"^(\d{18}|\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

            if (retornoCnpjValido18)
            {
                string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001")
                {
                    return true;
                }
            }

            return false;

        }

        public void Inserir(PessoaJuridica pj)
        {

            Utils.VerificarPastaArquivo(Caminho);
            string[] pjString = { $"{pj.razaoSocial} , {pj.cnpj}, {pj.razaoSocial}" };

            File.AppendAllLines(Caminho, pjString);

        }

        public List<PessoaJuridica> LerArquivo()
        {

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(Caminho);


            foreach (var cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }

    }
}