using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {

        private static string ValidarOperador(string operador)
            {
            string retorno = "+";

            if (operador == "-" || operador == "/" || operador == "*" || operador == "+")
            {
                retorno=operador;
            }

            return retorno;

            }

            public static double Operar(Numero num1, Numero num2, string operador)
        {
            string op = ValidarOperador(operador);

            double retorno=0;

            switch (op) {
                case "+":
                    retorno = num1 + num2;
                    break;

                case "-":
                    retorno = num1 - num2;
                    break;

                case "/":
                    retorno = num1 / num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;
            }

            return retorno;


        }
    }
}
