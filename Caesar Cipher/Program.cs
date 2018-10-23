using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream arqBase = new FileStream("base.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arqBase);

            FileStream arqEncr = new FileStream("baseE.txt", FileMode.Create);
            StreamWriter escrever = new StreamWriter(arqEncr);

            string letraBase;
            char letraBase2, aux2;
            int aux1;

            Console.WriteLine("Chave:");
            int chave = int.Parse(Console.ReadLine());

            do
            {

                letraBase = ler.ReadLine();

                if (letraBase != null)
                {
                    foreach (char letra in letraBase)
                    {
                        letraBase2 = letra;
                        aux1 = Convert.ToInt32(letraBase2);
                        aux1 += chave;
                        aux1 = Convert.ToChar(aux1);
                        aux2 = Convert.ToChar(aux1);
                        letraBase2 = aux2;
                        escrever.Write(aux2);
                    }
                    escrever.WriteLine("\n");
                }

            } while (letraBase != null);

            ler.Close();
            escrever.Close();

        }
    }
}
