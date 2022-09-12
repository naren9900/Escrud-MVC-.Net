namespace proyectoMVC.Models
{
    public  class Vehiculo : Entity
    {
        public string Placa { get; private set;}

        public string Modelo { get; private set;}

        public string Marca { get; private set;}

        public string Color { get; private set;}

        public string Tipo { get; private set;}

        public Guid TallerId { get; private set;}


        private Vehiculo()
        {

        }

        private Vehiculo(Guid id, string placa, string modelo, 
            string marca, string color, string tipo, Guid tallerId) : base(id)
        {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Tipo = tipo;
            TallerId = tallerId;
            
        }

        public static Vehiculo Build(Guid id, string placa, string modelo,
            string marca, string color, string tipo, Guid tallerId)
        {
            return new Vehiculo(id, placa, modelo, marca, color, tipo, tallerId);
        }


    }
}
