namespace PrograWeb16
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboDiasdelasemana = new System.Windows.Forms.ComboBox();
            this.cboMesdelaño = new System.Windows.Forms.ComboBox();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.CON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diasdelasemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesdelAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btnconsultar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes de Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dias de la semana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellido Paterno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Location = new System.Drawing.Point(204, 23);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(200, 22);
            this.txtNoControl.TabIndex = 7;
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(204, 88);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(200, 22);
            this.txtApePaterno.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(204, 117);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(200, 22);
            this.txtApeMaterno.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(204, 157);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cboDiasdelasemana
            // 
            this.cboDiasdelasemana.FormattingEnabled = true;
            this.cboDiasdelasemana.Items.AddRange(new object[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"});
            this.cboDiasdelasemana.Location = new System.Drawing.Point(204, 199);
            this.cboDiasdelasemana.Name = "cboDiasdelasemana";
            this.cboDiasdelasemana.Size = new System.Drawing.Size(200, 24);
            this.cboDiasdelasemana.TabIndex = 12;
            // 
            // cboMesdelaño
            // 
            this.cboMesdelaño.FormattingEnabled = true;
            this.cboMesdelaño.Items.AddRange(new object[] {
            "enero",
            "febrero",
            "marzo",
            "abril",
            "mayo",
            "junio",
            "julio",
            "agosto",
            "septiembre",
            "octubre",
            "noviembre",
            "diciembre"});
            this.cboMesdelaño.Location = new System.Drawing.Point(204, 287);
            this.cboMesdelaño.Name = "cboMesdelaño";
            this.cboMesdelaño.Size = new System.Drawing.Size(200, 24);
            this.cboMesdelaño.TabIndex = 13;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CON,
            this.No_Control,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.FechaIngreso,
            this.Diasdelasemana,
            this.MesdelAño});
            this.dgvAgregar.Location = new System.Drawing.Point(12, 317);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.RowHeadersWidth = 51;
            this.dgvAgregar.RowTemplate.Height = 24;
            this.dgvAgregar.Size = new System.Drawing.Size(787, 150);
            this.dgvAgregar.TabIndex = 14;
            this.dgvAgregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregar_CellContentClick);
            // 
            // CON
            // 
            this.CON.HeaderText = "CON";
            this.CON.MinimumWidth = 6;
            this.CON.Name = "CON";
            this.CON.Width = 125;
            // 
            // No_Control
            // 
            this.No_Control.HeaderText = "No.Control";
            this.No_Control.MinimumWidth = 6;
            this.No_Control.Name = "No_Control";
            this.No_Control.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.MinimumWidth = 6;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Width = 125;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellidos Materno";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Width = 125;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.MinimumWidth = 6;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 125;
            // 
            // Diasdelasemana
            // 
            this.Diasdelasemana.HeaderText = "Dias de la semana";
            this.Diasdelasemana.MinimumWidth = 6;
            this.Diasdelasemana.Name = "Diasdelasemana";
            this.Diasdelasemana.Width = 125;
            // 
            // MesdelAño
            // 
            this.MesdelAño.HeaderText = "Mes del Año";
            this.MesdelAño.MinimumWidth = 6;
            this.MesdelAño.Name = "MesdelAño";
            this.MesdelAño.Width = 125;
            // 
            // Btnconsultar
            // 
            this.Btnconsultar.Location = new System.Drawing.Point(759, 472);
            this.Btnconsultar.Name = "Btnconsultar";
            this.Btnconsultar.Size = new System.Drawing.Size(149, 23);
            this.Btnconsultar.TabIndex = 15;
            this.Btnconsultar.Text = "Consulta";
            this.Btnconsultar.Click += new System.EventHandler(this.Btnconsultar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 169);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btnconsultar);
            this.Controls.Add(this.dgvAgregar);
            this.Controls.Add(this.cboMesdelaño);
            this.Controls.Add(this.cboDiasdelasemana);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboDiasdelasemana;
        private System.Windows.Forms.ComboBox cboMesdelaño;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CON;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diasdelasemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesdelAño;
        private System.Windows.Forms.Button Btnconsultar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}