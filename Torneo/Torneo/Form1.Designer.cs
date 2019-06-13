namespace Torneo
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearequipo = new System.Windows.Forms.Button();
            this.btnCrearjugador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomJugador = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnMostrarequipo = new System.Windows.Forms.Button();
            this.btnMostrarjugadores = new System.Windows.Forms.Button();
            this.txtNumJugador = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.txtNumEquipo = new System.Windows.Forms.TextBox();
            this.btnBorrarjugador = new System.Windows.Forms.Button();
            this.btnBorrarequipo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(114, 20);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNomEquipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de equipo";
            // 
            // btnCrearequipo
            // 
            this.btnCrearequipo.Location = new System.Drawing.Point(114, 76);
            this.btnCrearequipo.Name = "btnCrearequipo";
            this.btnCrearequipo.Size = new System.Drawing.Size(100, 25);
            this.btnCrearequipo.TabIndex = 4;
            this.btnCrearequipo.Text = "Crear equipo";
            this.btnCrearequipo.UseVisualStyleBackColor = true;
            this.btnCrearequipo.Click += new System.EventHandler(this.btnCrearequipo_Click);
            // 
            // btnCrearjugador
            // 
            this.btnCrearjugador.Location = new System.Drawing.Point(114, 159);
            this.btnCrearjugador.Name = "btnCrearjugador";
            this.btnCrearjugador.Size = new System.Drawing.Size(100, 25);
            this.btnCrearjugador.TabIndex = 7;
            this.btnCrearjugador.Text = "Crear jugador";
            this.btnCrearjugador.UseVisualStyleBackColor = true;
            this.btnCrearjugador.Click += new System.EventHandler(this.btnCrearjugador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de jugador";
            // 
            // txtNomJugador
            // 
            this.txtNomJugador.Location = new System.Drawing.Point(114, 107);
            this.txtNomJugador.Name = "txtNomJugador";
            this.txtNomJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNomJugador.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(247, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 160);
            this.listBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(171, 254);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Equipos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Visitante";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(129, 281);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 13;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnMostrarequipo
            // 
            this.btnMostrarequipo.Location = new System.Drawing.Point(264, 178);
            this.btnMostrarequipo.Name = "btnMostrarequipo";
            this.btnMostrarequipo.Size = new System.Drawing.Size(117, 23);
            this.btnMostrarequipo.TabIndex = 14;
            this.btnMostrarequipo.Text = "Mostrar equipos";
            this.btnMostrarequipo.UseVisualStyleBackColor = true;
            this.btnMostrarequipo.Click += new System.EventHandler(this.btnMostrarequipo_Click);
            // 
            // btnMostrarjugadores
            // 
            this.btnMostrarjugadores.Location = new System.Drawing.Point(387, 178);
            this.btnMostrarjugadores.Name = "btnMostrarjugadores";
            this.btnMostrarjugadores.Size = new System.Drawing.Size(102, 23);
            this.btnMostrarjugadores.TabIndex = 15;
            this.btnMostrarjugadores.Text = "Mostrar jugdores";
            this.btnMostrarjugadores.UseVisualStyleBackColor = true;
            this.btnMostrarjugadores.Click += new System.EventHandler(this.btnMostrarjugadores_Click);
            // 
            // txtNumJugador
            // 
            this.txtNumJugador.Location = new System.Drawing.Point(114, 133);
            this.txtNumJugador.Name = "txtNumJugador";
            this.txtNumJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNumJugador.TabIndex = 16;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(62, 136);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 17;
            this.Numero.Text = "Numero";
            // 
            // txtNumEquipo
            // 
            this.txtNumEquipo.Location = new System.Drawing.Point(114, 50);
            this.txtNumEquipo.Name = "txtNumEquipo";
            this.txtNumEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNumEquipo.TabIndex = 18;
            // 
            // btnBorrarjugador
            // 
            this.btnBorrarjugador.Location = new System.Drawing.Point(414, 252);
            this.btnBorrarjugador.Name = "btnBorrarjugador";
            this.btnBorrarjugador.Size = new System.Drawing.Size(95, 23);
            this.btnBorrarjugador.TabIndex = 19;
            this.btnBorrarjugador.Text = "Borrar jugador";
            this.btnBorrarjugador.UseVisualStyleBackColor = true;
            this.btnBorrarjugador.Click += new System.EventHandler(this.btnBorrarjugador_Click);
            // 
            // btnBorrarequipo
            // 
            this.btnBorrarequipo.Location = new System.Drawing.Point(414, 281);
            this.btnBorrarequipo.Name = "btnBorrarequipo";
            this.btnBorrarequipo.Size = new System.Drawing.Size(95, 23);
            this.btnBorrarequipo.TabIndex = 20;
            this.btnBorrarequipo.Text = "Borrar equipo";
            this.btnBorrarequipo.UseVisualStyleBackColor = true;
            this.btnBorrarequipo.Click += new System.EventHandler(this.btnBorrarequipo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Numero";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(306, 281);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 22;
            this.btn.Text = "Reporte";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 379);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBorrarequipo);
            this.Controls.Add(this.btnBorrarjugador);
            this.Controls.Add(this.txtNumEquipo);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.txtNumJugador);
            this.Controls.Add(this.btnMostrarjugadores);
            this.Controls.Add(this.btnMostrarequipo);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCrearjugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomJugador);
            this.Controls.Add(this.btnCrearequipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearequipo;
        private System.Windows.Forms.Button btnCrearjugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomJugador;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnMostrarequipo;
        private System.Windows.Forms.Button btnMostrarjugadores;
        private System.Windows.Forms.TextBox txtNumJugador;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox txtNumEquipo;
        private System.Windows.Forms.Button btnBorrarjugador;
        private System.Windows.Forms.Button btnBorrarequipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

