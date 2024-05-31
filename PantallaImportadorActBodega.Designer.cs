namespace PPAI
{
    partial class PantallaImportadorActBodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gdrBodegasDisponibles = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdrBodegasDisponibles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(471, 53);
            label1.TabIndex = 0;
            label1.Text = "CU 5 - Importar actualización de vinos de bodega";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // gdrBodegasDisponibles
            // 
            gdrBodegasDisponibles.AllowUserToAddRows = false;
            gdrBodegasDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdrBodegasDisponibles.Columns.AddRange(new DataGridViewColumn[] { Nombre });
            gdrBodegasDisponibles.Location = new Point(21, 117);
            gdrBodegasDisponibles.Name = "gdrBodegasDisponibles";
            gdrBodegasDisponibles.ReadOnly = true;
            gdrBodegasDisponibles.RowHeadersWidth = 62;
            gdrBodegasDisponibles.Size = new Size(256, 161);
            gdrBodegasDisponibles.TabIndex = 1;
            gdrBodegasDisponibles.CellContentClick += bodegasDisponibles_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            Nombre.Width = 300;
            // 
            // label2
            // 
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(277, 38);
            label2.TabIndex = 2;
            label2.Text = "Bodegas ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // PantallaImportadorActBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(label2);
            Controls.Add(gdrBodegasDisponibles);
            Controls.Add(label1);
            Name = "PantallaImportadorActBodega";
            Text = "PantallaImportadorActBodega";
            Load += PantallaImportadorActBodega_Load;
            ((System.ComponentModel.ISupportInitialize)gdrBodegasDisponibles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView gdrBodegasDisponibles;
        private Label label2;
        private DataGridViewTextBoxColumn Nombre;
    }
}