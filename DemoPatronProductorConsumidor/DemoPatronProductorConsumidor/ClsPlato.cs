using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor
{
    public class ClsPlato
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime HoraPreparacion { get; set; }

        public ClsPlato(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            HoraPreparacion = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Plato ID: {Id}, Nombre: {Nombre}, Hora: {HoraPreparacion}";
        }
    }
}

