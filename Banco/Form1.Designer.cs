namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumeroCuenta = new System.Windows.Forms.TextBox();
            this.textBoxTitularCuenta = new System.Windows.Forms.TextBox();
            this.textBoxSaldoCuenta = new System.Windows.Forms.TextBox();
            this.textBoxInteresCuenta = new System.Windows.Forms.TextBox();
            this.textBoxCuotaCuenta = new System.Windows.Forms.TextBox();
            this.comboBoxCuentas = new System.Windows.Forms.ComboBox();
            this.botonAniadir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta seleccionada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interés:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cuota mantenimiento:";
            // 
            // textBoxNumeroCuenta
            // 
            this.textBoxNumeroCuenta.Enabled = false;
            this.textBoxNumeroCuenta.Location = new System.Drawing.Point(182, 95);
            this.textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            this.textBoxNumeroCuenta.Size = new System.Drawing.Size(156, 20);
            this.textBoxNumeroCuenta.TabIndex = 1;
            // 
            // textBoxTitularCuenta
            // 
            this.textBoxTitularCuenta.Enabled = false;
            this.textBoxTitularCuenta.Location = new System.Drawing.Point(182, 129);
            this.textBoxTitularCuenta.Name = "textBoxTitularCuenta";
            this.textBoxTitularCuenta.Size = new System.Drawing.Size(156, 20);
            this.textBoxTitularCuenta.TabIndex = 2;
            // 
            // textBoxSaldoCuenta
            // 
            this.textBoxSaldoCuenta.Enabled = false;
            this.textBoxSaldoCuenta.Location = new System.Drawing.Point(182, 165);
            this.textBoxSaldoCuenta.Name = "textBoxSaldoCuenta";
            this.textBoxSaldoCuenta.Size = new System.Drawing.Size(156, 20);
            this.textBoxSaldoCuenta.TabIndex = 3;
            // 
            // textBoxInteresCuenta
            // 
            this.textBoxInteresCuenta.Enabled = false;
            this.textBoxInteresCuenta.Location = new System.Drawing.Point(182, 200);
            this.textBoxInteresCuenta.Name = "textBoxInteresCuenta";
            this.textBoxInteresCuenta.Size = new System.Drawing.Size(156, 20);
            this.textBoxInteresCuenta.TabIndex = 4;
            // 
            // textBoxCuotaCuenta
            // 
            this.textBoxCuotaCuenta.Enabled = false;
            this.textBoxCuotaCuenta.Location = new System.Drawing.Point(182, 235);
            this.textBoxCuotaCuenta.Name = "textBoxCuotaCuenta";
            this.textBoxCuotaCuenta.Size = new System.Drawing.Size(156, 20);
            this.textBoxCuotaCuenta.TabIndex = 5;
            // 
            // comboBoxCuentas
            // 
            this.comboBoxCuentas.FormattingEnabled = true;
            this.comboBoxCuentas.Location = new System.Drawing.Point(182, 33);
            this.comboBoxCuentas.Name = "comboBoxCuentas";
            this.comboBoxCuentas.Size = new System.Drawing.Size(156, 21);
            this.comboBoxCuentas.TabIndex = 0;
            this.comboBoxCuentas.SelectedIndexChanged += new System.EventHandler(this.comboBoxCuentas_SelectedIndexChanged);
            // 
            // botonAniadir
            // 
            this.botonAniadir.Location = new System.Drawing.Point(372, 268);
            this.botonAniadir.Name = "botonAniadir";
            this.botonAniadir.Size = new System.Drawing.Size(115, 60);
            this.botonAniadir.TabIndex = 7;
            this.botonAniadir.Text = "Nueva cuenta";
            this.botonAniadir.UseVisualStyleBackColor = true;
            this.botonAniadir.Click += new System.EventHandler(this.botonAniadir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco.Properties.Resources.banco;
            this.pictureBox1.Location = new System.Drawing.Point(372, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 106);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(372, 268);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(115, 60);
            this.botonGuardar.TabIndex = 6;
            this.botonGuardar.Text = "Guardar cuenta";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Visible = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 340);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonAniadir);
            this.Controls.Add(this.comboBoxCuentas);
            this.Controls.Add(this.textBoxCuotaCuenta);
            this.Controls.Add(this.textBoxInteresCuenta);
            this.Controls.Add(this.textBoxSaldoCuenta);
            this.Controls.Add(this.textBoxTitularCuenta);
            this.Controls.Add(this.textBoxNumeroCuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Banco";
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
        private System.Windows.Forms.TextBox textBoxNumeroCuenta;
        private System.Windows.Forms.TextBox textBoxTitularCuenta;
        private System.Windows.Forms.TextBox textBoxSaldoCuenta;
        private System.Windows.Forms.TextBox textBoxInteresCuenta;
        private System.Windows.Forms.TextBox textBoxCuotaCuenta;
        private System.Windows.Forms.ComboBox comboBoxCuentas;
        private System.Windows.Forms.Button botonAniadir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonGuardar;
    }
}

