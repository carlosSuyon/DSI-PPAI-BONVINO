using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Interfaces
{
    public partial class NotificacionPush : Form
    {
        private RichTextBox richTextBox1;
        public NotificacionPush(List<string> mensajes)
        {
            InitializeComponent();

            // Inicializar y configurar richTextBox1
            richTextBox1 = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                Font = new Font("Arial", 12), // Cambia el tamaño y la fuente según desees
                ScrollBars = RichTextBoxScrollBars.Vertical // Para manejar listas largas
            };
            this.Controls.Add(richTextBox1);
            // Agregar los mensajes al RichTextBox
            foreach (var mensaje in mensajes)
            {
                richTextBox1.AppendText(mensaje + Environment.NewLine);
            }
        }

        public static void Mostrar(List<string> mensajes,string nombre)
        {
            using (NotificacionPush form = new NotificacionPush(mensajes))
            {
                form.Text ="Notificacion Push para : " + nombre;
                form.ShowDialog(); // Muestra la notificacion en un formulario
            }
        }

    }
}
