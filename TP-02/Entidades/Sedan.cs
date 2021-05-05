using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo 
        { 
            CuatroPuertas,
            CincoPuertas 
        }
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">tipo de enumerado Emarca</param>
        /// <param name="chasis">tipo string</param>
        /// <param name="color">tipo console color</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color): base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// este constructor da valor inicial a los atributos marca chasis color y al tipo
        /// </summary>
        /// <param name="marca">tipo emarca</param>
        /// <param name="chasis">tipo string</param>
        /// <param name="color">tipo console color</param>
        /// <param name="tipo">tipo etipo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo) : this (marca, chasis, color)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// este metodo llama al metodo base para mostrar los datos del sedan y ademas muestra su tamanio y tipo
        /// </summary>
        /// <returns>retorna el string con los datos de sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(string.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
