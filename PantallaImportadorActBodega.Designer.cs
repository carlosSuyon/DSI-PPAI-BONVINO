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
            label3 = new Label();
            gdrVinosBodega = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            FechaActulizacion = new DataGridViewTextBoxColumn();
            Añada = new DataGridViewTextBoxColumn();
            PrecioARS = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gdrBodegasDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gdrVinosBodega).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(524, 42);
            label1.TabIndex = 0;
            label1.Text = "CU 5 - Importar actualización de vinos de bodega";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // gdrBodegasDisponibles
            // 
            gdrBodegasDisponibles.AllowUserToAddRows = false;
            gdrBodegasDisponibles.Anchor = AnchorStyles.None;
            gdrBodegasDisponibles.BackgroundColor = SystemColors.ActiveCaption;
            gdrBodegasDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdrBodegasDisponibles.Columns.AddRange(new DataGridViewColumn[] { Nombre });
            gdrBodegasDisponibles.Location = new Point(12, 115);
            gdrBodegasDisponibles.MultiSelect = false;
            gdrBodegasDisponibles.Name = "gdrBodegasDisponibles";
            gdrBodegasDisponibles.RowHeadersWidth = 62;
            gdrBodegasDisponibles.ScrollBars = ScrollBars.None;
            gdrBodegasDisponibles.Size = new Size(278, 215);
            gdrBodegasDisponibles.TabIndex = 1;
            gdrBodegasDisponibles.CellContentClick += bodegasDisponibles_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Resizable = DataGridViewTriState.False;
            Nombre.Width = 300;
            // 
            // label2
            // 
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(278, 38);
            label2.TabIndex = 2;
            label2.Text = "Bodegas con actualizacion";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(443, 60);
            label3.Name = "label3";
            label3.Size = new Size(463, 38);
            label3.TabIndex = 3;
            label3.Text = "Resumen vinos de Bodega:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // gdrVinosBodega
            // 
            gdrVinosBodega.AllowUserToAddRows = false;
            gdrVinosBodega.AllowUserToDeleteRows = false;
            gdrVinosBodega.Anchor = AnchorStyles.None;
            gdrVinosBodega.BackgroundColor = SystemColors.ActiveCaption;
            gdrVinosBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdrVinosBodega.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, FechaActulizacion, Añada, PrecioARS });
            gdrVinosBodega.Location = new Point(430, 115);
            gdrVinosBodega.MultiSelect = false;
            gdrVinosBodega.Name = "gdrVinosBodega";
            gdrVinosBodega.RowHeadersWidth = 62;
            gdrVinosBodega.ScrollBars = ScrollBars.None;
            gdrVinosBodega.Size = new Size(512, 215);
            gdrVinosBodega.TabIndex = 4;
            gdrVinosBodega.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 175;
            // 
            // FechaActulizacion
            // 
            FechaActulizacion.HeaderText = "FechaActualizacion";
            FechaActulizacion.Name = "FechaActulizacion";
            FechaActulizacion.Width = 125;
            // 
            // Añada
            // 
            Añada.HeaderText = "Añada";
            Añada.Name = "Añada";
            Añada.Width = 75;
            // 
            // PrecioARS
            // 
            PrecioARS.HeaderText = "PrecioARS";
            PrecioARS.Name = "PrecioARS";
            PrecioARS.Width = 75;
            // 
            // PantallaImportadorActBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 449);
            Controls.Add(gdrVinosBodega);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gdrBodegasDisponibles);
            Controls.Add(label1);
            Name = "PantallaImportadorActBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaImportadorActBodega";
            Load += PantallaImportadorActBodega_Load;
            ((System.ComponentModel.ISupportInitialize)gdrBodegasDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)gdrVinosBodega).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView gdrBodegasDisponibles;
        private Label label2;
        private DataGridViewTextBoxColumn Nombre;
        private Label label3;
        private DataGridView gdrVinosBodega;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn FechaActulizacion;
        private DataGridViewTextBoxColumn Añada;
        private DataGridViewTextBoxColumn PrecioARS;
    }
}