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
            Thread.Sleep(2000); //Thread sleep indica que se va ejecutar dentro de dos segundos
        }
    }
}
