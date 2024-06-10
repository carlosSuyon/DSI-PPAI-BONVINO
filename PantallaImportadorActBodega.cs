using PPAI.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public partial class PantallaImportadorActBodega : Form
    {

        private GestorImportarActBodega miGestor = new GestorImportarActBodega();
        public PantallaImportadorActBodega()
        {
            InitializeComponent();
            //instacia un gestor 
            this.miGestor = new GestorImportarActBodega(this);

        }


        public void habilitarPantalla()
        {
            this.Show();
            this.miGestor.importarActVinosBodega();
        }

        public void mostrarBodegas(List<Bodega> bodegas)
        {

            if ((bodegas.Count == 0))
            {
                MessageBox.Show("No hay bodegas con actualizaciones disponibles.");
            }
            else
            {

                foreach (Bodega b in bodegas)
                {
                    if (b.MisVinos.Count() > 0)
                    {
                        DataGridViewRow fila = new DataGridViewRow();

                        DataGridViewCell nombreBodega = new DataGridViewTextBoxCell();
                        nombreBodega.Value = b.getNombre();

                        fila.Cells.Add(nombreBodega);
                        gdrBodegasDisponibles.Rows.Add(fila);
                        // Establecer el modo de selección en FullRowSelect para seleccionar filas completas
                        gdrBodegasDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Desactivar la edición de celdas
                        gdrBodegasDisponibles.ReadOnly = true;
                    }

                }

            }
            // alert para que el adm de bomvino eliga una bodega (click en fila de grilla)
            this.solicitarSeleccionBodega();
        }

        public void solicitarSeleccionBodega()
        {

            MessageBox.Show("Para seleccionar una bodega haga click sobre su nombre");
        }
        public void tomarSelecciónBodega(string bodegaSeleccionada)
        {
            this.miGestor.tomarSelecciónBodega(bodegaSeleccionada);
        }
        private void bodegasDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una fila (en lugar de en un encabezado de columna u otra área del control)
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = gdrBodegasDisponibles.Rows[e.RowIndex];

                // Obtener los valores de las celdas de la fila seleccionada
                string nombreBodega = filaSeleccionada.Cells["Nombre"].Value.ToString(); // Reemplaza "Nombre" por el nombre de la columna que contiene el nombre de la bodega u otro identificador único

                // Mostrar el nombre de la bodega seleccionada
                MessageBox.Show("Se seleccionó la bodega: " + nombreBodega);

                // Llamar a la función para tomar la selección de la bodega
                this.tomarSelecciónBodega(nombreBodega);
                // Deshabilitar la grilla para que no sea manipulable
                gdrBodegasDisponibles.ReadOnly = true;
            }

        }

        public void mostrarResumenVinosImportados(Bodega bSeleccionada)
        {
            gdrVinosBodega.Visible = true;
            label4.Visible = true;
            if (bSeleccionada.MisVinos.Count == 0)
            {
                MessageBox.Show("No hay resumen para la bodega :" + bSeleccionada.Nombre);
            }
            else
            {
                foreach (var objeto in bSeleccionada.MisVinos)
                {

                    DataGridViewRow fila = new DataGridViewRow();

                    DataGridViewCell nombreVino = new DataGridViewTextBoxCell();
                    nombreVino.Value = objeto.getNombre();

                    DataGridViewCell FechaActulizacion = new DataGridViewTextBoxCell();
                    FechaActulizacion.Value = objeto.FechaActualizacion.ToShortDateString();

                    DataGridViewCell añadaVino = new DataGridViewTextBoxCell();
                    añadaVino.Value = objeto.Añada;

                    DataGridViewCell precioVino = new DataGridViewTextBoxCell();
                    precioVino.Value = objeto.PrecioARS;


                    fila.Cells.Add(nombreVino);
                    fila.Cells.Add(FechaActulizacion);
                    fila.Cells.Add(añadaVino);
                    fila.Cells.Add(precioVino);

                    gdrVinosBodega.Rows.Add(fila);
                    // Establecer el modo de selección en FullRowSelect para seleccionar filas completas
                    gdrVinosBodega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Desactivar la edición de celdas
                    gdrVinosBodega.ReadOnly = true;


                }
                gdrBodegasDisponibles.Enabled = false;
                //this.miGestor.buscarSeguidoresDeBodega();
            }

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PantallaImportadorActBodega_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
