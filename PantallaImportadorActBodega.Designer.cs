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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            gdrBodegasDisponibles = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            label2 = new Label();
            gdrVinosBodega = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            FechaActulizacion = new DataGridViewTextBoxColumn();
            Añada = new DataGridViewTextBoxColumn();
            PrecioARS = new DataGridViewTextBoxColumn();
            label4 = new Label();
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
            gdrBodegasDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gdrBodegasDisponibles.BackgroundColor = SystemColors.ActiveCaption;
            gdrBodegasDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdrBodegasDisponibles.Columns.AddRange(new DataGridViewColumn[] { Nombre });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gdrBodegasDisponibles.DefaultCellStyle = dataGridViewCellStyle1;
            gdrBodegasDisponibles.Location = new Point(12, 115);
            gdrBodegasDisponibles.MaximumSize = new Size(300, 300);
            gdrBodegasDisponibles.MultiSelect = false;
            gdrBodegasDisponibles.Name = "gdrBodegasDisponibles";
            gdrBodegasDisponibles.RowHeadersWidth = 62;
            gdrBodegasDisponibles.ScrollBars = ScrollBars.Vertical;
            gdrBodegasDisponibles.Size = new Size(300, 175);
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
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(35, 72);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 2;
            label2.Text = "Bodegas con actualizacion";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // gdrVinosBodega
            // 
            gdrVinosBodega.AllowUserToAddRows = false;
            gdrVinosBodega.AllowUserToDeleteRows = false;
            gdrVinosBodega.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gdrVinosBodega.BackgroundColor = SystemColors.ActiveCaption;
            gdrVinosBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdrVinosBodega.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, FechaActulizacion, Añada, PrecioARS });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gdrVinosBodega.DefaultCellStyle = dataGridViewCellStyle2;
            gdrVinosBodega.Location = new Point(430, 115);
            gdrVinosBodega.MinimumSize = new Size(539, 108);
            gdrVinosBodega.MultiSelect = false;
            gdrVinosBodega.Name = "gdrVinosBodega";
            gdrVinosBodega.RowHeadersWidth = 62;
            gdrVinosBodega.ScrollBars = ScrollBars.Vertical;
            gdrVinosBodega.Size = new Size(539, 175);
            gdrVinosBodega.TabIndex = 4;
            gdrVinosBodega.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 200;
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
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(430, 72);
            label4.Name = "label4";
            label4.Size = new Size(218, 15);
            label4.TabIndex = 5;
            label4.Text = "Resumen Vinos de bodega seleccionada";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseMnemonic = false;
            label4.Click += label4_Click;
            // 
            // PantallaImportadorActBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(981, 449);
            Controls.Add(label4);
            Controls.Add(gdrVinosBodega);
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
            PerformLayout();
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
        private Label label4;
    }
}