using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {   /// <summary>
        /// constructor de suv inicializa los atributos marca chasis y color llamanda a la clase base
        /// </summary>
        /// <param name="marca">atributo del tipo emarca</param>
        /// <param name="chasis">atributo del tipo string</param>
        /// <param name="color">atributo del tipo console color</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color): base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        /// <summary>
        /// muestra los datos del tipo suv llama a la clase base para mostrar sus datos y ademas muestra el tamanio
        /// </summary>
        /// <returns>devuelve los datos de suv en forma de tipo string</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(string.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
