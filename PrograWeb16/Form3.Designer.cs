namespace PrograWeb16
{
    partial class Form3
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
            this.labelNoControl = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelIdCarrera = new System.Windows.Forms.Label();
            this.labelApePaterno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMaterno = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.CmbCarreras = new System.Windows.Forms.ComboBox();
            this.CmbMaterias = new System.Windows.Forms.ComboBox();
            this.dgVDatosAl = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnCambios = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVDatosAl)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNoControl
            // 
            this.labelNoControl.AutoSize = true;
            this.labelNoControl.Location = new System.Drawing.Point(12, 23);
            this.labelNoControl.Name = "labelNoControl";
            this.labelNoControl.Size = new System.Drawing.Size(75, 17);
            this.labelNoControl.TabIndex = 0;
            this.labelNoControl.Text = "No.Control";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 51);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelIdCarrera
            // 
            this.labelIdCarrera.AutoSize = true;
            this.labelIdCarrera.Location = new System.Drawing.Point(12, 221);
            this.labelIdCarrera.Name = "labelIdCarrera";
            this.labelIdCarrera.Size = new System.Drawing.Size(67, 17);
            this.labelIdCarrera.TabIndex = 2;
            this.labelIdCarrera.Text = "IdCarrera";
            // 
            // labelApePaterno
            // 
            this.labelApePaterno.AutoSize = true;
            this.labelApePaterno.Location = new System.Drawing.Point(12, 90);
            this.labelApePaterno.Name = "labelApePaterno";
            this.labelApePaterno.Size = new System.Drawing.Size(112, 17);
            this.labelApePaterno.TabIndex = 3;
            this.labelApePaterno.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 4;
            // 
            // labelMaterno
            // 
            this.labelMaterno.AutoSize = true;
            this.labelMaterno.Location = new System.Drawing.Point(12, 137);
            this.labelMaterno.Name = "labelMaterno";
            this.labelMaterno.Size = new System.Drawing.Size(114, 17);
            this.labelMaterno.TabIndex = 6;
            this.labelMaterno.Text = "Apellido Materno";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(12, 255);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(55, 17);
            this.labelMateria.TabIndex = 7;
            this.labelMateria.Text = "Materia";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Location = new System.Drawing.Point(204, 23);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(145, 22);
            this.txtNoControl.TabIndex = 8;
            this.txtNoControl.TextChanged += new System.EventHandler(this.txtNoControl_TextChanged);
            this.txtNoControl.Leave += new System.EventHandler(this.txtNoControl_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(204, 132);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(262, 22);
            this.txtApeMaterno.TabIndex = 11;
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(204, 85);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(262, 22);
            this.txtApePaterno.TabIndex = 12;
            // 
            // CmbCarreras
            // 
            this.CmbCarreras.FormattingEnabled = true;
            this.CmbCarreras.Location = new System.Drawing.Point(174, 218);
            this.CmbCarreras.Name = "CmbCarreras";
            this.CmbCarreras.Size = new System.Drawing.Size(502, 24);
            this.CmbCarreras.TabIndex = 14;
            this.CmbCarreras.SelectedIndexChanged += new System.EventHandler(this.CmbCarreras_SelectedIndexChanged);
            // 
            // CmbMaterias
            // 
            this.CmbMaterias.FormattingEnabled = true;
            this.CmbMaterias.Location = new System.Drawing.Point(174, 255);
            this.CmbMaterias.Name = "CmbMaterias";
            this.CmbMaterias.Size = new System.Drawing.Size(502, 24);
            this.CmbMaterias.TabIndex = 15;
            // 
            // dgVDatosAl
            // 
            this.dgVDatosAl.ColumnHeadersHeight = 29;
            this.dgVDatosAl.Location = new System.Drawing.Point(-3, 328);
            this.dgVDatosAl.Name = "dgVDatosAl";
            this.dgVDatosAl.RowHeadersWidth = 51;
            this.dgVDatosAl.RowTemplate.Height = 24;
            this.dgVDatosAl.Size = new System.Drawing.Size(866, 150);
            this.dgVDatosAl.TabIndex = 16;
            this.dgVDatosAl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVDatosAl_CellDoubleClick);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(391, 484);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(762, 484);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCambios
            // 
            this.btnCambios.Location = new System.Drawing.Point(670, 484);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(75, 23);
            this.btnCambios.TabIndex = 19;
            this.btnCambios.Text = "Cambios";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.Location = new System.Drawing.Point(578, 484);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(75, 23);
            this.btnBajas.TabIndex = 20;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.Location = new System.Drawing.Point(485, 484);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(75, 23);
            this.btnAltas.TabIndex = 21;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 551);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgVDatosAl);
            this.Controls.Add(this.CmbMaterias);
            this.Controls.Add(this.CmbCarreras);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelApePaterno);
            this.Controls.Add(this.labelIdCarrera);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNoControl);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVDatosAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoControl;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelIdCarrera;
        private System.Windows.Forms.Label labelApePaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMaterno;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.ComboBox CmbCarreras;
        private System.Windows.Forms.ComboBox CmbMaterias;
        private System.Windows.Forms.DataGridView dgVDatosAl;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnAltas;
    }
}