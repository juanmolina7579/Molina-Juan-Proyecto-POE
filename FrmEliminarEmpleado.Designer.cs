namespace Visual
{
    partial class FrmEliminarEmpleado
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAntiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colCedula,
            this.colNombres,
            this.colCorreo,
            this.colCargo,
            this.colFecha,
            this.colSueldo,
            this.colAntiguedad});
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 57);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(793, 203);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(352, 283);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 49);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.Width = 125;
            // 
            // colCedula
            // 
            this.colCedula.HeaderText = "Cedula";
            this.colCedula.MinimumWidth = 6;
            this.colCedula.Name = "colCedula";
            this.colCedula.Width = 125;
            // 
            // colNombres
            // 
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.MinimumWidth = 6;
            this.colNombres.Name = "colNombres";
            this.colNombres.Width = 125;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Width = 125;
            // 
            // colCargo
            // 
            this.colCargo.HeaderText = "Cargo";
            this.colCargo.MinimumWidth = 6;
            this.colCargo.Name = "colCargo";
            this.colCargo.Width = 125;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha Ingreso";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 125;
            // 
            // colSueldo
            // 
            this.colSueldo.HeaderText = "Sueldo";
            this.colSueldo.MinimumWidth = 6;
            this.colSueldo.Name = "colSueldo";
            this.colSueldo.Width = 125;
            // 
            // colAntiguedad
            // 
            this.colAntiguedad.HeaderText = "Antiguedad";
            this.colAntiguedad.MinimumWidth = 6;
            this.colAntiguedad.Name = "colAntiguedad";
            this.colAntiguedad.Width = 125;
            // 
            // FrmEliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 405);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "FrmEliminarEmpleado";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAntiguedad;
    }
}