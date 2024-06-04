using PPAI.Entidades;
using System;
using System.ComponentModel.DataAnnotations;

public class Bodega()
{
    //atrbitutos
    private string nombre;
    private string descripcion;
    private DateTime  fechaUltimaActualizacion;
    private string  periodoActualizacion;
    private string  historia;
    private List<Vino> misVinos;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public DateTime FechaUltimaActualizacion { get => fechaUltimaActualizacion; set => fechaUltimaActualizacion = value; }
    public string PeriodoActualizacion { get => periodoActualizacion; set => periodoActualizacion = value; }
    public string Historia { get => historia; set => historia = value; }
    public List<Vino> MisVinos { get => misVinos; set => misVinos = value; }

    //constructor
    public Bodega(string nombre, string descripcion,DateTime fechaUltimaActualizacion ,string periodoActualizacion, string historia) : this()
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.fechaUltimaActualizacion = fechaUltimaActualizacion;
        this.periodoActualizacion = periodoActualizacion;
        this.historia = historia;
        this.misVinos = [];
        
    }

    //metodos
    public Boolean esParaActualizar(DateTime fechaActual)
    {
        Boolean x = false;
         

        if ((this.fechaUltimaActualizacion ) <= fechaActual)
        {
            x = true;
        }
        return x;
    }

    public void actualizarDatosVino(Vino vinoAActulizar, DateTime fechaActual)
    {
        foreach (Vino unVinoMio in this.misVinos)
        {
            if (unVinoMio.sosVinoParaActualizar(vinoAActulizar.getNombre()))
            {
                
                unVinoMio.setPrecio(vinoAActulizar.PrecioARS);
                unVinoMio.setNotaCata(vinoAActulizar.NotaDeCataBodega);
                unVinoMio.setImagenEtiqueta(vinoAActulizar.ImagenEtiqueta);
                unVinoMio.setFechaActulizacion(fechaActual);
                
             }
        }
    }
    public Boolean tieneVino(Vino unVino){
        foreach (Vino vinoBodega in this.misVinos) {
            return (vinoBodega.sosEsteVino(unVino));

        }
        return false;   
    }

    public void actualizarVino(Vino vinoParaActualizar) {
        foreach (Vino v in this.MisVinos)
        {
            if (v.sosVinoParaActualizar(vinoParaActualizar.Nombre))
            {
                v.PrecioARS = vinoParaActualizar.PrecioARS;
                v.NotaDeCataBodega = vinoParaActualizar.NotaDeCataBodega;
                v.ImagenEtiqueta = vinoParaActualizar.ImagenEtiqueta;
                v.FechaActualizacion = vinoParaActualizar.FechaActualizacion; 
            }
        }

    }

    public string getNombre()
    {
        return this.nombre;
    }
}