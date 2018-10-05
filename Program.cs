using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TreinamentoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListaDeArquivos = Directory.EnumerateFiles(AppContext.BaseDirectory).Where(file => file.EndsWith("txt"));
            Console.WriteLine("Escolha uma música:\n");
            for (int i = 0; i < ListaDeArquivos.Count(); i++)
            {
                Console.WriteLine($"{i + 1} - {Path.GetFileNameWithoutExtension(ListaDeArquivos.ElementAt(i))}");
            }
            var escolha = int.Parse(Console.ReadKey().KeyChar.ToString());

            var texto = File.ReadAllText(ListaDeArquivos.ElementAt(escolha));
            Console.WriteLine("\n");
            Console.WriteLine(texto);
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
