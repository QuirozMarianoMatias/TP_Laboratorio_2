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
      
        public Numero ()
        {
            this.numero = 0;
        }

        public Numero (string numero)
        {

            this.SetNumero = numero;
        }

        public Numero(double numero)
        {
            this.numero = numero;
            
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
            
        }

        private double ValidarNumero (string numero)
        {
            Double numeroValido;

            if (double.TryParse(numero,out numeroValido))
            {
                return numeroValido;
            }

            return 0;
        }

        
        
        

        private bool EsBinario (string binario)
        {
            
            foreach (char Caracter in binario)
            {
                if (Caracter != '0' && Caracter != '1')
                {
                    return false;

                }
            }

          

            return true;
        }


        public static  double operator + (Numero num1,Numero num2)
        {
            double resultado;

            resultado = num1.numero + num2.numero;

        

            return resultado;
            
        }

        public static double operator - (Numero num1, Numero num2)
        {
            double resultado;

            resultado = num1.numero - num2.numero;

            return resultado;

        }

        public static double operator *(Numero num1, Numero num2)
        {
            double resultado;

            resultado = num1.numero * num2.numero;

            return resultado;

        }

        public static double operator /(Numero num1, Numero num2)
        {
            double resultado;


            if (num2.numero != 0)
            {
                resultado = num1.numero / num2.numero;
            }

            else
            {
                resultado = double.MinValue;
            }



            return resultado;

        }
    }
}
