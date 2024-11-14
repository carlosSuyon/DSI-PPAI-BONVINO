using PPAI.Entidades;

public class Bodega()
{
    //atrbitutos
    private string nombre;
    private string descripcion;
    private DateTime fechaUltimaActualizacion;
    private int periodoActualizacion;
    private string historia;
    private List<Vino> misVinos;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public DateTime FechaUltimaActualizacion { get => fechaUltimaActualizacion; set => fechaUltimaActualizacion = value; }
    public int PeriodoActualizacion { get => periodoActualizacion; set => periodoActualizacion = value; }
    public string Historia { get => historia; set => historia = value; }
    public List<Vino> MisVinos { get => misVinos; set => misVinos = value; }

    //constructor
    public Bodega(string nombre, string descripcion, DateTime fechaUltimaActualizacion, int periodoActualizacion, string historia) : this()
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.fechaUltimaActualizacion = fechaUltimaActualizacion;
        this.periodoActualizacion = periodoActualizacion;
        this.historia = historia;
        this.MisVinos = new List<Vino>();

    }

    //metodos
    public Boolean esParaActualizar(DateTime fechaActual)
    {
        Boolean x = false;
        int diasDesdeUltimaActualizacion = (fechaActual - this.FechaUltimaActualizacion).Days;
        int diasPeriodoActualizacion = this.PeriodoActualizacion * 30; // Aproximación de 30 días por mes

        if (diasDesdeUltimaActualizacion >= diasPeriodoActualizacion)
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
    public Boolean tieneVino(string nombreVino)
    {
        //si el nombreVino del vino importado coincide con el nombre de algun vino de la coleccion de vinos de la bodega
        foreach (Vino vinoDeBodega in this.misVinos)
        {
            if (vinoDeBodega.esDeBodega(nombreVino))
            {
                return true;
            }
        }
        return false;
    }

    public void actualizarVino(string nombre, int precio, string nota, string img, DateTime fecha)
    {
        foreach (Vino v in this.MisVinos)
        {
            if (v.sosVinoParaActualizar(nombre))
            {
                v.PrecioARS = precio;
                v.NotaDeCataBodega = nota;
                v.ImagenEtiqueta = img;
                v.FechaActualizacion = fecha;
            }
        }

    }

    public string getNombre()
    {
        return this.nombre;
    }
    public void setFechaUltimaActualizacion(DateTime fecha)
    {
        this.FechaUltimaActualizacion = fecha;
    }
}