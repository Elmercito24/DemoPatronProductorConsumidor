namespace DemoPatronProductorConsumidor
{
    public class Usuario // Clase pública
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaCreacion { get; set; }


        //Ctor y tab
        public Usuario(int id, string nombre, string correo)
        {
            Id = id;
            Nombre = nombre;
            CorreoElectronico = correo;
            FechaCreacion = DateTime.Now;
        }

        public override string ToString()
        //Queremos que retorne estos valores
        {
            return $"Id:{Id},Nombre:{Nombre},Correo:{CorreoElectronico},Fecha de creación:{FechaCreacion}";
        }
    }
}
