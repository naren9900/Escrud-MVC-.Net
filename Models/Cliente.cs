namespace proyectoMVC.Models
{
    public class Cliente : Entity
    {
        public string Nombre { get; private set; }

        public string DocumentoIdentidad { get; private set; }

        public string Telefono { get;  private set; }

        public string Direccion { get; private set; }

        public Guid TallerId { get; private set; }

        private Cliente()
        {

        }

        private Cliente(Guid id, string nombre, string documentoIdentidad, string telefono, string direccion, Guid tallerid) : base(id)
        {
            Nombre = nombre;
            DocumentoIdentidad = documentoIdentidad;
            Telefono = telefono;
            Direccion = direccion;
            TallerId = tallerid;
        }

        public static Cliente Build(Guid id, string nombre, string documentoIdentidad, 
            string telefono, string direccion, Guid tallerid)
        {
            return new Cliente(id, nombre, documentoIdentidad, telefono, direccion, tallerid);
        }
    }
}
