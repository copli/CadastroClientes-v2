// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using CadastroClientes.Classes;

string? opcao;

Console.Clear();
Console.ResetColor();

Utils.BarraCarregamento("Inicializando");

// Console.BackgroundColor = ConsoleColor.DarkBlue;
// Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
 ------------------------------------------------------------------
 |            Seja bem vindo ao Sistema de Cadastro de            |
 |                   Pessoas Físicas e Jurídicas                  |
 ------------------------------------------------------------------
");

// Dormir/Sleep = 1 segundo / 1000 = 1 milisegundo  
Thread.Sleep(2000);
Console.Clear();


do
{
    Console.WriteLine(@$"
 ------------------------------------------------------------------
 |                 Escolha uma opção abaixo:                      |
 ------------------------------------------------------------------
 |                   1 - Pessaoa Física                           |
 |                   2 - Pessaoa Jurídica                         |
 |                                                                |
 |                   0 - Sair do Sistema                          |   
 ------------------------------------------------------------------
");
    Console.ResetColor();

    Console.WriteLine($"Digite uma das opções acima e tecle 'Enter' !");
    opcao = Console.ReadLine();
    // Console.WriteLine($" O texto digitado foi: {digitacao}");

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Pessoa Física Selecionada");
            //PESSOA FISICA +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //metodo construtor
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.nome = "Adriano Malagoli";
            novaPf.cpf = 256854745;
            novaPf.dataNasc = new DateTime(2001, 01, 01);
            novaPf.rendimento = 10000.00f; 

            novoEndPf.logradouro = "Rua Niteroi";
            novoEndPf.numero = 180;
            novoEndPf.complemento = "Senai Informatica";
            novoEndPf.endComercial = false;

            novaPf.endereco = novoEndPf;

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novoEndPf.logradouro}, {novoEndPf.numero}
            Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
            ");

            // Console.WriteLine(novaPf.nome);
            // Console.WriteLine(novaPf.cpf);
            // Console.WriteLine(novaPf.dataNasc);
            // Console.WriteLine(novaPf.endereco);
            // Console.WriteLine(novaPf.rendimento);
            // // Concatenação
            // Console.WriteLine("Nome do Funcionário: " + novaPf.nome);
            // Interpolação
            //Console.WriteLine(@$"Nome do Funcionário: {novaPf.nome} - CPF: {novaPf.cpf}");

            // Console.WriteLine(novaPf.CalcularImposto(novaPf.rendimento));

            //DateTime datNascimento = new DateTime(2004,02,26);
            //Console.WriteLine(novaPf.ValidarDataNasc(dat1));
            //DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.UtcNow;
            //DateTime date3 = DateTime.Today;
            //var dataResult = date3 - datNascimento;
            //Console.WriteLine(dataResult.TotalDays/365);

            //Console.WriteLine(novaPf.ValidarDataNasc(datNascimento));
            //Console.WriteLine(novaPf.ValidarDataNasc("26-10-2002"));

            Console.WriteLine($"Tecle 'Enter' para continuar!");
            Console.ReadLine();
            break;

        case "2":
            Console.WriteLine($"Pessoa Jurídica Selecionada");
            // PESSOA JURIDICA ----------------------------------------------------------------

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.razaoSocial = "Adriano Malagoli - ME";
            novaPj.cnpj = "31.876.411/0001-79";
            novaPj.rendimento = 200000.00f; 

            novoEndPj.logradouro = "Rua Copacabana";
            novoEndPj.numero = 354;
            novoEndPj.complemento = "Empresa Senai Informatica";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.WriteLine(@$"
            Nome da Razão Social: {novaPj.razaoSocial}
            Endereço: {novoEndPj.logradouro}, {novoEndPj.numero}
            CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
            ");


            //Console.WriteLine(novaPj.ValidarCnpj("31.876.411/0001-79"));

            //float x = novaPj.rendimento = 16600.3f;
            //Console.WriteLine(novaPj.CalcularImposto(x));
            //float impostoPagar = novaPj.CalcularImposto(10000.5f);
            //Console.WriteLine($"O imposto a pagar da PJ será de : {impostoPagar:0.00}");
            //Console.WriteLine(impostoPagar.ToString("C"));
            Console.WriteLine($"Tecle 'Enter' para continuar!");
            Console.ReadLine();
            break;

        case "0":
            //Console.WriteLine($"Saindo do Sistema");
            break;


        default:
            Console.WriteLine($"Valor não encontrado, digite um valor correto (1, 2 ou 0)");
            Thread.Sleep(4000);
            break;
    }

    Console.Clear();
} while (opcao != "0");

Utils.BarraCarregamento("Finalizando");

//Console.Clear();


// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine(novaPf.dataNasc);
// Console.WriteLine(novaPf.endereco);
// Console.WriteLine(novaPf.rendimento);

// Concatenação
// Console.WriteLine("Nome do Cliente: " + novaPf.nome);

// Interpolação
// Console.WriteLine($"Nome do Cliente: {novaPf.nome} - CPF: {novaPf.cpf}");

//PESSOA FISICA +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Método construtor
// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.nome = "Adriano";
// novaPf.cpf = 01234567890;
// novaPf.dataNasc = new DateTime(1969, 09, 12);
// novaPf.rendimento = 10000.00f;

// novoEndPf.logradouro = "Rua Niteroi";
// novoEndPf.numero = 180;
// novoEndPf.complemento = "Senai Informática";
// novoEndPf.endComercial = true;

// novaPf.endereco = novoEndPf;

// Console.WriteLine(@$"

// Nome: {novaPf.nome}
// Endereço: {novoEndPf.logradouro}, {novoEndPf.numero}
// Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
// ");


// DateTime datNascimento = new DateTime(1969,09,12);
// Console.WriteLine(novaPf.ValidarDataNasc(dat1));
// DateTime date1 = DateTime.Now;
// DateTime date2 = DateTime.UtcNow;
// DateTime date3 = DateTime.Today;
// var dataResult = date3 - datNascimento;
// Console.WriteLine(dataResult.TotalDays/365);

// Console.WriteLine(novaPf.ValidarDataNasc(datNascimento));

// Console.WriteLine(novaPf.ValidarDataNasc("12/09/1969"));

// float impostoPagar = novaPf.CalcularImposto(10000.5f);
// Console.WriteLine($"O imposto a pagar será de: {impostoPagar:0.00}");

// PESSOA JURIDICA ----------------------------------------------------------------

// PessoaJuridica novaPj = new PessoaJuridica();
// Endereco novoEndPj = new Endereco();

// novaPj.razaoSocial = "Adriano Malagoli - ME";
// novaPj.cnpj = "31.876.411/0001-79";
// novaPj.rendimento = 200000.00f; 

// novoEndPj.logradouro = "Rua Copacabana";
// novoEndPj.numero = 354;
// novoEndPj.complemento = "Empresa Senai Informatica";
// novoEndPj.endComercial = true;

// novaPj.endereco = novoEndPj;

// Console.WriteLine(@$"

// Nome da Razão Social: {novaPj.razaoSocial}
// Endereço: {novoEndPj.logradouro}, {novoEndPj.numero}
// CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
// ");


//Console.WriteLine(novaPj.ValidarCnpj("31.876.411/0001-79"));

//float x = novaPj.rendimento = 16600.3f;
//Console.WriteLine(novaPj.CalcularImposto(x));
//float impostoPagar = novaPj.CalcularImposto(10000.5f);
//Console.WriteLine($"O imposto a pagar da PJ será de : {impostoPagar:0.00}");
//Console.WriteLine(impostoPagar.ToString("C"));


// PessoaJuridica novaPj = new PessoaJuridica();
// float x = novaPj.rendimento = 16600.3f;
// Console.WriteLine(novaPj.CalcularImposto(x));

// float impostoPagar = novaPj.CalcularImposto(10000.5f);
// Console.WriteLine($"O imposto a pagar da PJ será de : {impostoPagar:0.00}");
// Console.WriteLine(impostoPagar.ToString("C"));
