namespace DemoPatronProductorConsumidor
{
    partial class Form1
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
            panel1 = new Panel();
            BtnRegistrar = new Button();
            TxtCorreoElectronico = new TextBox();
            label2 = new Label();
            TxtNombres = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            BtnProcesar = new Button();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(TxtCorreoElectronico);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtNombres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 205);
            panel1.TabIndex = 0;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            BtnRegistrar.Location = new Point(520, 146);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(116, 39);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // TxtCorreoElectronico
            // 
            TxtCorreoElectronico.Location = new Point(22, 105);
            TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            TxtCorreoElectronico.Size = new Size(485, 27);
            TxtCorreoElectronico.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Correo electronico:";
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(22, 35);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(485, 27);
            TxtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombres: ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(BtnProcesar);
            panel2.Controls.Add(dgvUsuarios);
            panel2.Location = new Point(21, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 265);
            panel2.TabIndex = 5;
            // 
            // BtnProcesar
            // 
            BtnProcesar.BackColor = Color.FromArgb(128, 255, 128);
            BtnProcesar.Location = new Point(523, 214);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(104, 39);
            BtnProcesar.TabIndex = 5;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = false;
            BtnProcesar.Click += BtnProcesar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            dgvUsuarios.Location = new Point(3, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(504, 253);
            dgvUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostración patrón Productor - Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtNombres;
        private Label label1;
        private Button BtnRegistrar;
        private TextBox TxtCorreoElectronico;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private Button BtnProcesar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
    }
}
