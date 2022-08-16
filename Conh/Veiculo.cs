using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conh
{
    public class Veiculo
    {
        // declaracao de atributos
        string marca;
        string modelo;
        string placa;
        int ano;
        // metodo para atribuir valores
        public void atribuir(string ma,
            string mo, string pl, int a)
        {
            this.ano = a;
            this.marca = ma;
            this.modelo = mo;
            this.placa = pl;
        }
        public string retornar()
        {
            return "Marca =" + this.marca +
                "\nModelo =" + this.modelo +
                "\nAno de fabricaçao =" + this.ano +
                "\nPlaca =" + this.placa;
                }
    }
}
