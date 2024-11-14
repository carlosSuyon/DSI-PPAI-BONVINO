namespace PPAI.Interfaces
{
    public interface ISujetoNovedadesVinos
    {

        public void notificar();
        public void quitar(IObservadorNovedadesBodegas observadorNovedadesBodegas);
        public void suscribir(IObservadorNovedadesBodegas observadorNovedadesBodegas);


    }
}
