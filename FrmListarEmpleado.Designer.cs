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
            this.nudAntHasta = new System.Windows.Forms.NumericUpDown();
            this.nudAntDesde = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAntiguedad = new System.Windows.Forms.RadioButton();
            this.rbCargo = new System.Windows.Forms.RadioButton();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntDesde)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // nudAntHasta
            // 
            this.nudAntHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntHasta.Location = new System.Drawing.Point(342, 69);
            this.nudAntHasta.Margin = new System.Windows.Forms.Padding(4);
            this.nudAntHasta.Name = "nudAntHasta";
            this.nudAntHasta.Size = new System.Drawing.Size(75, 22);
            this.nudAntHasta.TabIndex = 10;
            this.nudAntHasta.Visible = false;
            // 
            // nudAntDesde
            // 
            this.nudAntDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntDesde.Location = new System.Drawing.Point(197, 69);
            this.nudAntDesde.Margin = new System.Windows.Forms.Padding(4);
            this.nudAntDesde.Name = "nudAntDesde";
            this.nudAntDesde.Size = new System.Drawing.Size(75, 22);
            this.nudAntDesde.TabIndex = 8;
            this.nudAntDesde.Visible = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(476, 72);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(128, 33);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrarClick);
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(162, 26);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(164, 24);
            this.cmbCargo.TabIndex = 17;
            this.cmbCargo.Visible = false;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(476, 127);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(128, 28);
            this.btnMostrarTodos.TabIndex = 18;
            this.btnMostrarTodos.Text = "Mostrar Todo";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAntiguedad);
            this.groupBox1.Controls.Add(this.rbCargo);
            this.groupBox1.Controls.Add(this.lblDesde);
            this.groupBox1.Controls.Add(this.cmbCargo);
            this.groupBox1.Controls.Add(this.nudAntDesde);
            this.groupBox1.Controls.Add(this.lblHasta);
            this.groupBox1.Controls.Add(this.nudAntHasta);
            this.groupBox1.Location = new System.Drawing.Point(30, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 109);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de filtrado";
            // 
            // rbAntiguedad
            // 
            this.rbAntiguedad.AutoSize = true;
            this.rbAntiguedad.Location = new System.Drawing.Point(9, 67);
            this.rbAntiguedad.Name = "rbAntiguedad";
            this.rbAntiguedad.Size = new System.Drawing.Size(121, 20);
            this.rbAntiguedad.TabIndex = 1;
            this.rbAntiguedad.TabStop = true;
            this.rbAntiguedad.Text = "Por Antiguedad";
            this.rbAntiguedad.UseVisualStyleBackColor = true;
            this.rbAntiguedad.Click += new System.EventHandler(this.rbAntiguedad_CheckedChanged);
            // 
            // rbCargo
            // 
            this.rbCargo.AutoSize = true;
            this.rbCargo.Location = new System.Drawing.Point(9, 26);
            this.rbCargo.Name = "rbCargo";
            this.rbCargo.Size = new System.Drawing.Size(89, 20);
            this.rbCargo.TabIndex = 0;
            this.rbCargo.TabStop = true;
            this.rbCargo.Text = "Por Cargo";
            this.rbCargo.UseVisualStyleBackColor = true;
            this.rbCargo.Click += new System.EventHandler(this.rbCargo_CheckedChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(137, 71);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde";
            this.lblDesde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(280, 73);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Visible = false;
            // 
            // FrmListarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "FrmListarEmpleado";
            this.Text = "FrmListarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntDesde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.NumericUpDown nudAntHasta;
        private System.Windows.Forms.NumericUpDown nudAntDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAntiguedad;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAntiguedad;
        private System.Windows.Forms.RadioButton rbCargo;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
    }
}