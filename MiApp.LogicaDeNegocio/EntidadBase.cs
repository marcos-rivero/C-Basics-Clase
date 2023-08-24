using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.LogicaDeNegocio
{
    public abstract class EntidadBase
    {
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validar();
        public abstract bool Validar();
        public EstadoDeLaEntidad EstadoDeLaEntidad { get; set; }

    }

    public enum EstadoDeLaEntidad
    {
        Activo,
        Borrado
    }
}
