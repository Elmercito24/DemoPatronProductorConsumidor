using RestauranteProductorConsumidor;

namespace DemoPatronProductorConsumidor
{
    public class ClsCocinero
    {

        private ClsZonaDePlatos<ClsPlato> _zonaDePlatos;

        //Constructor
        public ClsCocinero(ClsZonaDePlatos<ClsPlato> zonaDePlatos)
        {
            _zonaDePlatos = zonaDePlatos;
        }

        //Constructor
        public void PrepararPlato(ClsPlato plato)
        {
            _zonaDePlatos.Agregar(plato);
            Thread.Sleep(2000); // Simular tiempo de preparación
        }
    }
}
