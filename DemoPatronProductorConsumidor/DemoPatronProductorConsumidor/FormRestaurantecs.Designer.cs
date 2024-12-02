namespace DemoPatronProductorConsumidor
{
    partial class FormRestaurantecs
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
            panel1 = new Panel();
            BtnSalir = new Button();
            btnServir = new Button();
            btnPreparar = new Button();
            TxtNombrePlato = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvPlatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(btnServir);
            panel1.Controls.Add(btnPreparar);
            panel1.Controls.Add(TxtNombrePlato);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 166);
            panel1.TabIndex = 0;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(128, 255, 128);
            BtnSalir.Location = new Point(341, 92);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(116, 39);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click_1;
            // 
            // btnServir
            // 
            btnServir.BackColor = Color.FromArgb(128, 255, 128);
            btnServir.Location = new Point(190, 92);
            btnServir.Name = "btnServir";
            btnServir.Size = new Size(116, 39);
            btnServir.TabIndex = 5;
            btnServir.Text = "Servir";
            btnServir.UseVisualStyleBackColor = false;
            btnServir.Click += btnServir_Click_1;
            // 
            // btnPreparar
            // 
            btnPreparar.BackColor = Color.FromArgb(128, 255, 128);
            btnPreparar.Location = new Point(26, 92);
            btnPreparar.Name = "btnPreparar";
            btnPreparar.Size = new Size(116, 39);
            btnPreparar.TabIndex = 6;
            btnPreparar.Text = "Preparar";
            btnPreparar.UseVisualStyleBackColor = false;
            btnPreparar.Click += btnPreparar_Click;
            // 
            // TxtNombrePlato
            // 
            TxtNombrePlato.Location = new Point(7, 32);
            TxtNombrePlato.Name = "TxtNombrePlato";
            TxtNombrePlato.Size = new Size(485, 27);
            TxtNombrePlato.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del plato:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPlatos);
            panel2.Location = new Point(11, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 233);
            panel2.TabIndex = 1;
            // 
            // dgvPlatos
            // 
            dgvPlatos.AllowUserToAddRows = false;
            dgvPlatos.AllowUserToDeleteRows = false;
            dgvPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Fecha });
            dgvPlatos.Location = new Point(8, 0);
            dgvPlatos.Name = "dgvPlatos";
            dgvPlatos.ReadOnly = true;
            dgvPlatos.RowHeadersWidth = 51;
            dgvPlatos.Size = new Size(488, 230);
            dgvPlatos.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 150;
            // 
            // FormRestaurantecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormRestaurantecs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRestaurantecs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtNombrePlato;
        private Label label1;
        private Button btnServir;
        private Button btnPreparar;
        private Panel panel2;
        private DataGridView dgvPlatos;
        private Button BtnSalir;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha;
    }
}