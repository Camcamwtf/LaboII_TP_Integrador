using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public enum ESistema
        {
            Decimal, Binario
        }

        public ESistema Sistema { get { return this.sistema; } }
        
        public string Valor 
        {
            get
            {
                string valor = "";
                switch (sistema)
                {
                    case ESistema.Decimal:
                        valor = valorNumerico.ToString(); 
                        break;
                    case ESistema.Binario:
                        valor = DecimalABinario(valorNumerico.ToString());
                        break;
                }
                return valor;
            }
        }

        public Numeracion(double valor, ESistema sistema)
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }

        public Numeracion(string valor, ESistema sistema) => InicializarValores(valor, sistema);

        public static double BinarioADecimal(string valor)
        {
            double valorDecimal = 0;
            int longitudBinario = valor.Length;

            for (int i = (longitudBinario - 1); i >= 0; i--)
            {
                if (valor[i] == '1')
                {
                    valorDecimal += Math.Pow(2, (longitudBinario - 1) - i);
                }
            }
            return valorDecimal;
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this.Valor;
            }
            else
            {
                return this.Valor;
            }
        }

        public static string DecimalABinario(int valor)
        {
            List<int> doubleList = new();
            string valorBinario = "";
            int valorConvertido = Math.Abs(valor);

            if (valorConvertido == '0')
            {
                return "0";
            }

            for (int i = 0; valorConvertido >= 1; i++)
            {
                doubleList.Add(valorConvertido % 2);
                valorConvertido /= 2;
            }

            foreach (var numero in doubleList)
            {
                valorBinario = numero.ToString() + valorBinario;
            }

            if (string.IsNullOrEmpty(valorBinario))
            {
                return "Número inválido";
            }
            else
            {
                return valorBinario;
            }
        }

        public static string DecimalABinario(string valor)
        {
            string valorBinario = DecimalABinario(Convert.ToInt32(valor));
            return valorBinario;
        }

        private static bool EsBinario(string valor)
        {
            bool esBinario = valor.All(c => c == 0 || c == 1);
            return esBinario;
        }

        public void InicializarValores(string valor, ESistema sistema)
        {
            this.sistema = sistema;

            if (EsBinario(valor) && sistema == ESistema.Binario)
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if (!double.TryParse(valor, out this.valorNumerico))
            {
                this.valorNumerico = double.MinValue;
            }
        }

        public static bool operator != (ESistema sistema, Numeracion numeracion) => numeracion.Sistema == sistema;

        public static bool operator != (Numeracion n1, Numeracion n2) => n1.Sistema == n2.Sistema;

        public static Numeracion operator - (Numeracion n1, Numeracion n2)
        {
            double valor = 0;
            if (n1 == n2)
            {
                valor = double.Parse(n1.ConvertirA(n1.Sistema)) - double.Parse(n2.ConvertirA(n2.Sistema));
            }

            return new Numeracion(valor, n1.Sistema);
        }

        public static Numeracion operator * (Numeracion n1, Numeracion n2)
        {
            double valor = 0;
            if (n1 == n2)
            {
                valor = double.Parse(n1.ConvertirA(n1.Sistema)) * double.Parse(n2.ConvertirA(n2.Sistema));
            }

            return new Numeracion(valor, n1.Sistema);
        }

        public static Numeracion operator / (Numeracion n1, Numeracion n2)
        {
            double valor = 0;
            if (n1 == n2)
            {
                valor = double.Parse(n1.ConvertirA(n1.Sistema)) / double.Parse(n2.ConvertirA(n2.Sistema));
            }

            return new Numeracion(valor, n1.Sistema);
        }

        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            double valor = 0;
            if (n1 == n2)
            {
                valor = double.Parse(n1.ConvertirA(n1.Sistema)) + double.Parse(n2.ConvertirA(n2.Sistema));
            }

            return new Numeracion(valor, n1.Sistema);
        }

        public static bool operator == (ESistema sistema, Numeracion numeracion) => numeracion.Sistema == sistema;

        public static bool operator == (Numeracion n1, Numeracion n2) => n1.Sistema == n2.Sistema;
    }
}