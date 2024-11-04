namespace Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string NombreCompleto { get { return $"{Apellido} {Nombre}"; } }

        public Persona() { }
        public Persona(string nombre, string apellido, string dni, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
        }
    }
}

