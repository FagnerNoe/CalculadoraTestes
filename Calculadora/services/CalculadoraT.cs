using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.services
{
    public class CalculadoraT
    {

        private string data;
        private List<string> listaHistorico;

        public CalculadoraT(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int numero1, int numero2)
        {
            var resultado = numero1 + numero2;
            listaHistorico.Insert(0, "Resultado" + resultado + "data" + data);
            return resultado;
        }

        public int Subtrair(int numero1, int numero2)
        {
            var resultado = numero1 - numero2;
            listaHistorico.Insert(0, "Resultado" + resultado + "data" + data);
            return resultado;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            var resultado = numero1 * numero2;
            listaHistorico.Insert(0, "Resultado" + resultado + "data" + data);
            return resultado;
        }

        public int Dividir(int numero1, int numero2)
        {
            var resultado = numero1 / numero2;
            listaHistorico.Insert(0, "Resultado" + resultado + "data" + data);
            return resultado;
        }

        public List<string> Historico()
        {

            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

    }

}