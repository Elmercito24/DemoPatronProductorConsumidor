using RestauranteProductorConsumidor;

namespace DemoPatronProductorConsumidor
{
    public class ClsMesero
    {
        private ClsZonaDePlatos<ClsPlato> _zonaDePlatos;

        public ClsMesero(ClsZonaDePlatos<ClsPlato> zonaDePlatos)
        {
            _zonaDePlatos = zonaDePlatos;
        }

        public ClsPlato ServirPlato()
        {
            ClsPlato plato = _zonaDePlatos.Extraer();
            Thread.Sleep(1000); // Simular tiempo de servicio
            return plato;
        }
    }
}
