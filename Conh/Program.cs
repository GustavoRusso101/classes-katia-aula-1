using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAÇAO DO OBJETO
            Veiculo golf = new Veiculo();
            Console.Write("Digite a marca: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite a placa: ");
            string placa = Console.ReadLine();
            Console.Write("Digite o ano de fabricaçao: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            //objeto chamado metodo atribuir
            golf.atribuir(marca,modelo,placa,ano);
            Console.WriteLine(golf.retornar());
            Console.ReadKey();
        }
    }
}
