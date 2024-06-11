namespace PPAI
{
    partial class FormAdmBonvino
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIAVB = new Button();
            label1 = new Label();
            btnRegistrarVarietal = new Button();
            btnRegistrarBodega = new Button();
            SuspendLayout();
            // 
            // btnIAVB
            // 
            btnIAVB.Font = new Font("Segoe UI", 12F);
            btnIAVB.Location = new Point(376, 134);
            btnIAVB.Name = "btnIAVB";
            btnIAVB.Size = new Size(595, 54);
            btnIAVB.TabIndex = 0;
            btnIAVB.Text = "Importar Actualizacion de Vinos de Bodegas";
            btnIAVB.UseVisualStyleBackColor = true;
            btnIAVB.Click += btnIAVB_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 39);
            label1.Name = "label1";
            label1.Size = new Size(595, 60);
            label1.TabIndex = 1;
            label1.Text = "Menu Administrador de Vinos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // btnRegistrarVarietal
            // 
            btnRegistrarVarietal.Font = new Font("Segoe UI", 12F);
            btnRegistrarVarietal.Location = new Point(376, 233);
            btnRegistrarVarietal.Name = "btnRegistrarVarietal";
            btnRegistrarVarietal.Size = new Size(595, 54);
            btnRegistrarVarietal.TabIndex = 2;
            btnRegistrarVarietal.Text = "Registrar Varietal";
            btnRegistrarVarietal.UseVisualStyleBackColor = true;
            btnRegistrarVarietal.Click += button1_Click;
            // 
            // btnRegistrarBodega
            // 
            btnRegistrarBodega.Font = new Font("Segoe UI", 12F);
            btnRegistrarBodega.Location = new Point(376, 341);
            btnRegistrarBodega.Name = "btnRegistrarBodega";
            btnRegistrarBodega.Size = new Size(595, 54);
            btnRegistrarBodega.TabIndex = 3;
            btnRegistrarBodega.Text = "Registrar Bodega";
            btnRegistrarBodega.UseVisualStyleBackColor = true;
            btnRegistrarBodega.Click += btnRegistrarBodega_Click;
            // 
            // FormAdmBonvino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(btnRegistrarBodega);
            Controls.Add(btnRegistrarVarietal);
            Controls.Add(label1);
            Controls.Add(btnIAVB);
            Name = "FormAdmBonvino";
            Text = "AdmBonvino";
            WindowState = FormWindowState.Maximized;
            Load += FormAdmBonvino_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnIAVB;
        private Label label1;
        private Button btnRegistrarVarietal;
        private Button btnRegistrarBodega;
    }
}
