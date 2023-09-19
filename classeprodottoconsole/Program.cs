using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace classeprodottoconsole

{
    internal class Program
    { 
      static void Main(string[] args)
        {
            Console.Write("Inserire il nome del prodotto: ");
            string nome = Console.ReadLine();

            Console.Write("Inserire il prezzo del prodotto: ");
            double prezzo = double.Parse(Console.ReadLine());

            Prodotto p =new Prodotto(nome,prezzo);
            Prodotto prod = new Prodotto();

            nome = "null";
            prezzo = 0;

            Console.WriteLine("\nVariabile nome: " + nome);
            Console.WriteLine("\nVariabile prezzo: " + prezzo);

            Console.WriteLine("\nPrezzo attributo: " + p.gPrezzo());
            Console.WriteLine("\nNome attributo: " + p.gNome());
        }
    }
}