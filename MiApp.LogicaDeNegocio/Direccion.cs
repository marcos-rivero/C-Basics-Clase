using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.LogicaDeNegocio
{
    public class Direccion
    {
        public Direccion() { }
        public Direccion(int direccionId)
        {
            DireccionId = direccionId;
        }
        public int DireccionId { get; set; }
        public int TipoDeDireccion { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidad { get; set; }
        public bool Validar()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(CodigoPostal)) { isValid = false; }
            return isValid;
        }
        public override string ToString()
        {
            return CodigoPostal;
        }

    }
}
