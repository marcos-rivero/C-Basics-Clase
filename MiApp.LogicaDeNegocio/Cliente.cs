namespace MiApp.LogicaDeNegocio
{
    public class Cliente : EntidadBase
    {
        public Cliente() { }
        public Cliente(int clienteId) {
            ClienteID = clienteId;
        }
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
        private string _apellido;
        public string Apellido { 
            get { return _apellido; } 
            set { _apellido = value; }
        }
        public string Nombre { get; set; }
        
        public int ClienteID { get; private set; }

        public string DireccionDeMail { get; set; }
        public Direccion Direccion { get; set; }
        public static int ContadorDeInstancias { get; set; }
        public string NombreCompleto { 
            get
            {
                if (!string.IsNullOrWhiteSpace(Nombre))
                {
                    if (!string.IsNullOrWhiteSpace(Apellido)){
                        return Apellido + ", " + Nombre;
                    }
                    return Nombre;
                }
                return Apellido;
            }
        }
        public override bool Validar()
        {
            bool esValido = true;
            if(string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(DireccionDeMail)){
                esValido = false;
            }
            return esValido;
        }
        public override string ToString()
        {
            return NombreCompleto;
        }


    }
}
