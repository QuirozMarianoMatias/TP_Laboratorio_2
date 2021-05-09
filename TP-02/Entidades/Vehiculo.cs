using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        /// <summary>
        /// contructor de vehiculo que iniciliza los atributos marca chasis y color
        /// </summary>
        /// <param name="chasis">atributo del tipo string</param>
        /// <param name="marca">atributo del tipo emarca</param>
        /// <param name="color">atributo del tipo console color</param>
        public Vehiculo (string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;

        }

        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
       protected abstract ETamanio Tamanio
       { 
            
            get;

            
       }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// sobrecarga explicita para convertir un vehiculo y devolver un string
        /// </summary>
        /// <param name="p">retorna los datos del vehiculo en forma de string</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("CHASIS: {0}\r\n", p.chasis));
            sb.Append(string.Format("MARCA : {0}\r\n", p.marca.ToString()));
            sb.Append(string.Format("COLOR : {0}\r\n", p.color.ToString()));
            sb.Append("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">vehiculo1 a comparar</param>
        /// <param name="v2">vehiculo2 a comparar</param>
        /// <returns>retorna un true si son iguales y false si son falsos</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">vehiculo1 a comparar</param>
        /// <param name="v2">vehiculo2 a comparar</param>
        /// <returns>retorna true si son distintos y false si son iguales</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }
}
