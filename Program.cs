// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using CadastroClientes.Classes;


// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine(novaPf.dataNasc);
// Console.WriteLine(novaPf.endereco);
// Console.WriteLine(novaPf.rendimento);

// Concatenação
// Console.WriteLine("Nome do Cliente: " + novaPf.nome);

// Interpolação
// Console.WriteLine($"Nome do Cliente: {novaPf.nome} - CPF: {novaPf.cpf}");


//Float impostoPagar = novaPj.CalcularImposto(10000.5f);
//Console.WriteLine($"O imposto a pagar será de: {impostoPagar:0.00}");

// Método construtor
PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Adriano";
novaPf.cpf = 01234567890;
novaPf.dataNasc = new DateTime(2001, 01, 01);

novaPf.rendimento = 12000.00f;

Endereco novoEndPf = new Endereco();

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "Senai Informática";
novoEndPf.endComercial = true;

novaPf.endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novoEndPf.logradouro}, {novoEndPf.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");


DateTime datNascimento = new DateTime(1969,09,12);
Console.WriteLine(novaPf.ValidarDataNasc("12/09/1969"));