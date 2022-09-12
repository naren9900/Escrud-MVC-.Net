namespace proyectoMVC.Models
{
    public class Taller  : Entity
    {
        public string NombreTienda { get;  private set; }

        public string Direccion { get; private set; }

        public string Telefono { get; private set; }

        public int Empleado { get; private set; }

        public List<Cliente> Clientes { get; private set; }

        private Taller()
        {

        } 

        private Taller(Guid id, string nombreTienda, string direccion,
            string telefono, int empleado) : base(id)
        {
            NombreTienda = nombreTienda;
            Direccion = direccion;
            Telefono = telefono;
            Empleado = empleado;
            
        }

        public static Taller Build(Guid id, string nombreTienda, string direccion,
            string telefono, int empleado)
        {
            return new Taller(id, nombreTienda, direccion, telefono, empleado);
        }
    }
}
