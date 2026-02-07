namespace Visual
{
    partial class FrmListarEmpleado
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
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAntiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrarAnt = new System.Windows.Forms.Button();
            this.nudAntHasta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAntDesde = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrarCargo = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntDesde)).BeginInit();
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
            this.dgvEmpleados.Location = new System.Drawing.Point(30, 173);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(812, 251);
            this.dgvEmpleados.TabIndex = 0;
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
            // btnFiltrarAnt
            // 
            this.btnFiltrarAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarAnt.Location = new System.Drawing.Point(158, 88);
            this.btnFiltrarAnt.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrarAnt.Name = "btnFiltrarAnt";
            this.btnFiltrarAnt.Size = new System.Drawing.Size(154, 32);
            this.btnFiltrarAnt.TabIndex = 11;
            this.btnFiltrarAnt.Text = "Filtrar Antiguedad";
            this.btnFiltrarAnt.UseVisualStyleBackColor = true;
            this.btnFiltrarAnt.Click += new System.EventHandler(this.btnFiltrarAnt_Click);
            // 
            // nudAntHasta
            // 
            this.nudAntHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntHasta.Location = new System.Drawing.Point(345, 44);
            this.nudAntHasta.Margin = new System.Windows.Forms.Padding(4);
            this.nudAntHasta.Name = "nudAntHasta";
            this.nudAntHasta.Size = new System.Drawing.Size(75, 22);
            this.nudAntHasta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta:";
            // 
            // nudAntDesde
            // 
            this.nudAntDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntDesde.Location = new System.Drawing.Point(158, 44);
            this.nudAntDesde.Margin = new System.Windows.Forms.Padding(4);
            this.nudAntDesde.Name = "nudAntDesde";
            this.nudAntDesde.Size = new System.Drawing.Size(75, 22);
            this.nudAntDesde.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Antiguedad: Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cargos";
            // 
            // btnFiltrarCargo
            // 
            this.btnFiltrarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarCargo.Location = new System.Drawing.Point(723, 41);
            this.btnFiltrarCargo.Name = "btnFiltrarCargo";
            this.btnFiltrarCargo.Size = new System.Drawing.Size(128, 33);
            this.btnFiltrarCargo.TabIndex = 14;
            this.btnFiltrarCargo.Text = "Filtrar Cargo";
            this.btnFiltrarCargo.UseVisualStyleBackColor = true;
            this.btnFiltrarCargo.Click += new System.EventHandler(this.btnFiltrarCargo_Click);
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(532, 46);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(164, 24);
            this.cmbCargo.TabIndex = 17;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(388, 132);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(138, 28);
            this.btnMostrarTodos.TabIndex = 18;
            this.btnMostrarTodos.Text = "Mostrar Todo";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // FrmListarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 456);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.btnFiltrarCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrarAnt);
            this.Controls.Add(this.nudAntHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAntDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "FrmListarEmpleado";
            this.Text = "FrmListarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntDesde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnFiltrarAnt;
        private System.Windows.Forms.NumericUpDown nudAntHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAntDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAntiguedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrarCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}