using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string textoBarra)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{textoBarra}");
            for (var contador = 0; contador < 3; contador++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }
            Console.ResetColor();
            Thread.Sleep(500);
            Console.Clear();
        }

        public static void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                using (File.Create(caminho)){}
            }

        }
    }
}