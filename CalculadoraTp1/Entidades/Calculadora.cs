using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// se encarga de validar que se trate de un operador valido (+,-,*,/) caso contrario retorna +
        /// </summary>
        /// <param name="operador">operador a vilidar del tipo char</param>
        /// <returns>retorna el operador validado si no se pudo realizar retorna +</returns>
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
        /// <summary>
        /// Operar se encarga de realizar una operacion entre dos objetos
        /// </summary>
        /// <param name="num1">objeto de la clase Numero</param>
        /// <param name="num2">objeto de la clase Numero</param>
        /// <param name="operador">string operador</param>
        /// <returns>retorna el resultado de la operacion</returns>
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
