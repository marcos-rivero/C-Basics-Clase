using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.LogicaDeNegocio.Repositorios
{
    public class ClienteRepositorio
    {
        public bool Guardar() { return true; }
        public Cliente Retornar()
        {
            return new Cliente();
        }
    }
}
