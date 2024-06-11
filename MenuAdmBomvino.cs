namespace PPAI
{
    public partial class FormAdmBonvino : Form
    {
        public FormAdmBonvino()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En la proxima entrega (?");
        }


        private void btnIAVB_Click(object sender, EventArgs e)
        {
            this.importarActVinosBodega(sender, e);
        }

        // importarActVinosBodega()
        private void importarActVinosBodega(object sender, EventArgs e)
        {
            PantallaImportadorActBodega pantalla = new PantallaImportadorActBodega();
            pantalla.habilitarPantalla();
            this.Hide();
        }


        private void btnRegistrarBodega_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En la proxima entrega (?");
        }

        private void FormAdmBonvino_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
