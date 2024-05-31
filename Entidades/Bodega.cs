using PPAI.Entidades;
using System;
using System.ComponentModel.DataAnnotations;

public class Bodega()
{
    //atrbitutos
    private string nombre;
    private string descripcion;
    //verificar tipo de dato
    private DateTime  fechaUltimaActualizacion;
    private string  periodoActualizacion;
    private string  historia;
    private List<Vino> misVinos;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public DateTime FechaUltimaActualizacion { get => fechaUltimaActualizacion; set => fechaUltimaActualizacion = value; }
    public string PeriodoActualizacion { get => periodoActualizacion; set => periodoActualizacion = value; }
    public string Historia { get => historia; set => historia = value; }

    //constructor
    public Bodega(string nombre, string descripcion,DateTime fechaUltimaActualizacion ,string periodoActualizacion, string historia) : this()
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.fechaUltimaActualizacion = fechaUltimaActualizacion;
        this.periodoActualizacion = periodoActualizacion;
        this.historia = historia;
        
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
                //faltan los gets de clase vino
                /*
                unVinoMio.setPrecio(vinoAActulizar.precio);
                unVinoMio.setNotaCata(vinoAActulizar.notaCata);
                unVinoMio.setImagenEtiqueta(vinoAActulizar.imagenEtiqueta);
                unVinoMio.setFechaActulizacion(fechaActual);
                */
             }
        }
    }
    public Boolean tieneVino(Vino unVino){
        foreach (Vino vinoBodega in misVinos) {
            return (vinoBodega.sosEsteVino(unVino));

        }
        return false;   
    }

    public void actualizarVino() { }

    public string getNombre()
    {
        return this.nombre;
    }
}