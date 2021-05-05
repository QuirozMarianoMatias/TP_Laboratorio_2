using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {   /// <summary>
        /// constructor de ciclomotor inicializa los atributos marca chasis y color llamanda a la clase base
        /// </summary>
        /// <param name="marca">atributo del tipo emarca</param>
        /// <param name="chasis">atributo del tipo string</param>
        /// <param name="color">atributo del tipo console color</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color): base (chasis,marca,color)
        {

        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        /// <summary>
        /// este metodo llama al metodo base para mostrar los datos del ciclomotor y ademas muestra su tamanio y tipo
        /// </summary>
        /// <returns>devuelve los datos de ciclomotor en forma de string</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(string.Format("TAMAÑO : {0}", this.Tamanio));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
