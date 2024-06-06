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
            if (bodegas.Count == 0)
            {
                MessageBox.Show("No hay bodegas con actualizaciones disponibles.");
            }
            else
            {

                foreach (var objeto in bodegas)
                {

                    DataGridViewRow fila = new DataGridViewRow();

                    DataGridViewCell nombreBodega = new DataGridViewTextBoxCell();
                    nombreBodega.Value = objeto.getNombre();

                    fila.Cells.Add(nombreBodega);
                    gdrBodegasDisponibles.Rows.Add(fila);
                    // Establecer el modo de selección en FullRowSelect para seleccionar filas completas
                    gdrBodegasDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Desactivar la edición de celdas
                    gdrBodegasDisponibles.ReadOnly = true;
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
            //
            string bodegaSeleccionada =
            gdrBodegasDisponibles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            MessageBox.Show("Se selecciono la bodega: " + bodegaSeleccionada);
            tomarSelecciónBodega(bodegaSeleccionada);

        }

        public void mostrarResumenVinosImportados(Bodega bSeleccionada)
        {
            gdrVinosBodega.Visible = true;
            label3.Visible  = true;
            if (bSeleccionada.MisVinos.Count == 0)
            {
                MessageBox.Show("No hay resumen para la bodega" + bSeleccionada.Nombre);
            }
            else
            {
                foreach (var objeto in bSeleccionada.MisVinos)
                {

                    DataGridViewRow fila = new DataGridViewRow();

                    DataGridViewCell nombreVino = new DataGridViewTextBoxCell();
                    nombreVino.Value = objeto.getNombre();

                    DataGridViewCell FechaActulizacion = new DataGridViewTextBoxCell();
                    FechaActulizacion.Value = objeto.FechaActualizacion;

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
                this.miGestor.buscarSeguidoresDeBodega();
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
    }
}
