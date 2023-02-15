// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using CadastroClientes.Classes;


// novaPf.nome = "Adriano";
// novaPf.cpf = 01234567890;
// novaPf.dataNasc = new DateTime(2001, 01, 01);
// novaPf.endereco = "Rua Niteroi, 1532";
// novaPf.rendimento = 12000.00f;

// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine(novaPf.dataNasc);
// Console.WriteLine(novaPf.endereco);
// Console.WriteLine(novaPf.rendimento);

// Concatenação
// Console.WriteLine("Nome do Cliente: " + novaPf.nome);

// Interpolação
// Console.WriteLine($"Nome do Cliente: {novaPf.nome} - CPF: {novaPf.cpf}");

CalcularImposto(rendimento);
void CalcularImposto()
{
    throw new NotImplementedException();
    if (rendimento <= 3000)
{
float resultado = rendimento * 0,03f;
return resultado;
}
 else if (rendimento > 3000 && rendimento <= 6000)
{
float resultado = rendimento * 0,05f;
return resultado;
}
 else if (rendimento > 6000 && rendimento <= 10000)
{
float resultado = rendimento * 0,07f;
return resultado;
}
 else
{
float resultado = rendimento * 0,09f;
return resultado;
}

}

Float impostoPagar = novaPj.CalcularImposto(10000.5f);
Console.WriteLine($"O imposto a pagar será de: {impostoPagar:0.00}");

// Método construtor
// PessoaFisica novaPf = new PessoaFisica();