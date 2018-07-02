using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {

        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }


        public Numero()
        {

        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if (double.TryParse(strNumero, out double auxiliarRetorno))
            {
                retorno = auxiliarRetorno;
            }

            return retorno;
        }

        public string BinarioDecimal(string binario)
        {
            double numero = 0;
            double aux;
            int j = 0, contador = 0;

            do
            {
                for (int i = binario.Length; i > 0; i--)
                {
                    if (binario[i - 1] == '0' || binario[i - 1] == '1')
                    {
                        if (binario[i - 1] == '1')
                        {
                            aux = Math.Pow(2, j);
                            numero += aux;
                        }
                        j++;
                    }
                 else
                    {
                      contador++;
                      j++;
                    }
                }


                if (contador != 0)
                {
                    numero = -1;
                }




            } while (j < binario.Length);

            return numero.ToString();
        }

        public string DecimalBinario(double numero)
        {
            string resultado = "";
            int numeroaux = (int)numero;

            if (numeroaux < 0)
            {
                numeroaux = numeroaux * -1;
            }

            while (numeroaux > 0)
            {
                resultado = (numeroaux % 2).ToString() + resultado;
                numeroaux = numeroaux / 2;
            }
            return resultado.ToString();
        }

        public string DecimalBinario(string numero)
        {
            string resultado = "";

            if (double.TryParse(numero, out double aux))
            {
                resultado = this.DecimalBinario(aux);
            }

            return resultado;
        }

       
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

      
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

       
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }




    }
}
