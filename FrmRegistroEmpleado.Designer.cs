namespace Visual
{
    partial class FrmRegistroEmpleado
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(148, 99);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(164, 22);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(148, 237);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(164, 22);
            this.txtSueldo.TabIndex = 8;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(148, 55);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(164, 22);
            this.txtCedula.TabIndex = 9;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(148, 143);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(164, 22);
            this.txtCorreo.TabIndex = 12;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(377, 77);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(266, 22);
            this.dtpFechaIngreso.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(377, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(56, 292);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ReadOnly = true;
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContenido.Size = new System.Drawing.Size(652, 146);
            this.txtContenido.TabIndex = 15;
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(148, 191);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(164, 24);
            this.cmbCargo.TabIndex = 16;
            // 
            // FrmRegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombres);
            this.Name = "FrmRegistroEmpleado";
            this.Text = "Registro de empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.ComboBox cmbCargo;
    }
}