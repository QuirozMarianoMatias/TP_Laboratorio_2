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

        /// <summary>
        /// valida que el string recibido sea un numero caso contrario retorna 0
        /// </summary>
        /// <param name="numero">recibe por parademos un tipo string</param>
        /// <returns>retorna el numero validado si no se pudo validar retorna 0</returns>
        private double ValidarNumero (string numero)
        {
            Double numeroValido;

            if (double.TryParse(numero,out numeroValido))
            {
                return numeroValido;
            }

            return 0;
        }

        
        
        
        /// <summary>
        /// es binario valida que el string recibido solo contenga 0 y 1
        /// </summary>
        /// <param name="binario">el tipo string con el que se trabajara para validar</param>
        /// <returns>retorna true si solo contiene 0 y 1 de lo contrario retorna false</returns>
        private bool EsBinario (string binario)
        {
            
            
            foreach (char Caracter in binario.ToCharArray())
            {
                if (Caracter != '0' && Caracter != '1')
                {
                    return false;

                }
            }

          

            return true;
        }

        /// <summary>
        /// se encarga de convertir un binario a decimal si no puede devuelve valor invalido
        /// </summary>
        /// <param name="binario">el string con el que se trabajara para convertirlo</param>
        /// <returns>devuelve el decimal convertido (en tipo string) o valor invalido si no se pudo convertir</returns>
        public string BinarioDecimal (string binario)
        {
            string decimals="Valor invalido";
            double resultado = 0;
            if (EsBinario(binario) && !(string.IsNullOrEmpty(binario)))
            {
                 
                 int potencia = binario.Length - 1;

                 foreach (char num in binario.ToCharArray())
                 {
                        if (num == '1')
                        {
                        resultado += (Math.Pow(2, potencia));
                        }
                        potencia--;
                  }

                decimals = resultado.ToString();
                
            }
           
        
            return decimals;
        }
        /// <summary>
        /// convierte un numero en un binario 
        /// </summary>
        /// <param name="numero">el numero a convertir</param>
        /// <returns>devuelve el numero decimal convertido a binario</returns>
        public string DecimalBinario(double numero)
        {
            string resultado = "";
            numero = Math.Abs(numero);

            do
            {

                resultado = ((int)numero % 2).ToString() + resultado;
                numero = (int)numero / 2;



            } while (numero > 1);

            if (numero == 0)
            {
                resultado = "0" + resultado;


            }

            else
            {
                resultado = "1" + resultado;
            }




            return resultado;

        }

        /// <summary>
        /// se encarga de convertir un decimal a binario de no ser posible retorna valor invalido
        /// </summary>
        /// <param name="numero">recibe un tipo string que es lo que intentara validar</param>
        /// <returns>retorna el binario si se pudo convertir caso contrario retorna valor invalido</returns>
        public string DecimalBinario(string numero)
        {
            string binario ;
            double num;
           if(double.TryParse(numero,out num))
            {
               
               binario = DecimalBinario(num);
            }
           else
            {
                binario = "Valor invalido";
            }

           
            return binario;

        }





        /// <summary>
        /// sobrecarga del operador + se encarga de sumar los atributos numero de dos objetos de la clase Numero
        /// </summary>
        /// <param name="num1">objeto de la clase Numero</param>
        /// <param name="num2">objeto de la clase Numero</param>
        /// <returns>retorna el resultado de la suma entre los atributos de los objetos</returns>
        public static  double operator + (Numero num1,Numero num2)
        {
            double resultado;

            resultado = num1.numero + num2.numero;

        

            return resultado;
            
        }
        /// <summary>
        /// sobrecarga del operador - se encarga de restar los atributos numero de dos objetos de la clase Numero
        /// </summary>
        /// <param name="num1">objeto de la clase Numero</param>
        /// <param name="num2">objeto de la clase Numero</param>
        /// <returns>retorna el resultado de la resta entre los atributos de los objetos</returns>
        public static double operator - (Numero num1, Numero num2)
        {
            double resultado;

            resultado = num1.numero - num2.numero;

            return resultado;

        }
        /// <summary>
        /// sobrecarga del operador * se encarga de multiplicar los atributos numero de dos objetos de la clase Numero
        /// </summary>
        /// <param name="num1">objeto de la clase Numero</param>
        /// <param name="num2">objeto de la clase Numero</param>
        /// <returns>retorna el resultado de la multiplicacion entre los atributos de los objetos</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            double resultado;

            resultado = num1.numero * num2.numero;

            return resultado;

        }
        /// <summary>
        /// sobrecarga del operador / se encarga de dividir los atributos numero de dos objetos de la clase Numero y valida la dision por 0
        /// </summary>
        /// <param name="num1">objeto de la clase Numero</param>
        /// <param name="num2">objeto de la clase Numero</param>
        /// <returns>retorna el resultado de la division entre los atributos de los objetos y si no se pudo realizar retorna el minvalue de un double</returns>
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
