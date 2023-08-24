using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.LogicaDeNegocio.Comun
{
    public static class ServicioDeLogging
    {
        public static void EscribirEnUnArchivo(List<Object> listaDeObjetos)
        {
            //public static void EscribirEnUnArchivo(List<ILoggable> listaDeObjetos)
            {
                foreach (var objeto in listaDeObjetos)
                {
                    Console.WriteLine(objeto.ToString());
                }
            }
        }
    }
}
