using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(char operador)
        {
            string operadorValidado;
           
                switch (operador)
                {
                    case '-':
                        operadorValidado = operador.ToString();
                        break;
                    case '*':
                        operadorValidado = operador.ToString();
                        break;
                    case '/':
                        operadorValidado = operador.ToString();
                        break;
                    default:
                        operadorValidado = "+";
                        break;

                }
            
            return operadorValidado;
        }

        public static double Operar(Numero num1 , Numero num2 , string operador)
        {
            double resultado;
            char auxOperador;

           if( char.TryParse(operador, out auxOperador))
            {
              operador = Calculadora.ValidarOperador(auxOperador);
            }

            else
            {
                operador = "+";
            }
                
            
            

            switch(operador)
            {
                case "+":
                resultado = num1 + num2;
                break;

                case "-":
                resultado = num1 - num2;
                break;

                case "/":
                resultado = num1 / num2;
                break;

                default:
                resultado = num1 * num2;
                break;

            }
           

            
            return resultado;
        } 

    }
}
