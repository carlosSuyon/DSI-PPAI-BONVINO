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
            this.miGestor = new GestorImportarActBodega(this);
            this.miGestor.importarActVinosBodega();
        }

        private void PantallaImportadorActBodega_Load(object sender, EventArgs e)
        {

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
                }
                
            }
            // alert para que el adm de bomvino eliga una bodega (click en fila de grilla)
            this.solicitarSeleccionBodega();
        }

        public void solicitarSeleccionBodega()
        {
            
            MessageBox.Show("Para seleccionar una bodega haga click sobre su nombre");
        }
        public void tomarSelecciónBodega(string bodegaSeleccionada) {
            this.miGestor.tomarSelecciónBodega(bodegaSeleccionada);
        }
        public void mostrarResumenVinosImportados() { }

        private void bodegasDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            string bodegaSeleccionada =
            gdrBodegasDisponibles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            MessageBox.Show("Se selecciono la bodega: " + bodegaSeleccionada);
            tomarSelecciónBodega(bodegaSeleccionada);
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void habilitarPantalla(){
            this.Show();
        }
    }
}
