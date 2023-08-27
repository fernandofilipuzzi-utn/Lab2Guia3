
namespace BuscaMinasDesktop
{
    partial class FormDatos
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFilas = new System.Windows.Forms.NumericUpDown();
            this.nudColumnas = new System.Windows.Forms.NumericUpDown();
            this.nudMinas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(113, 9);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(212, 20);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(229, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(38, 178);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // nudFilas
            // 
            this.nudFilas.Location = new System.Drawing.Point(104, 22);
            this.nudFilas.Name = "nudFilas";
            this.nudFilas.Size = new System.Drawing.Size(63, 20);
            this.nudFilas.TabIndex = 4;
            // 
            // nudColumnas
            // 
            this.nudColumnas.Location = new System.Drawing.Point(104, 48);
            this.nudColumnas.Name = "nudColumnas";
            this.nudColumnas.Size = new System.Drawing.Size(63, 20);
            this.nudColumnas.TabIndex = 5;
            // 
            // nudMinas
            // 
            this.nudMinas.Location = new System.Drawing.Point(104, 74);
            this.nudMinas.Name = "nudMinas";
            this.nudMinas.Size = new System.Drawing.Size(63, 20);
            this.nudMinas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minas";
            // 
            // cbNivel
            // 
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Nivel 1",
            "Nivel 2",
            "Nivel 3",
            "Personalizar"});
            this.cbNivel.Location = new System.Drawing.Point(113, 43);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(212, 21);
            this.cbNivel.TabIndex = 10;
            this.cbNivel.SelectedIndexChanged += new System.EventHandler(this.cbNivel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nivel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMinas);
            this.groupBox1.Controls.Add(this.nudFilas);
            this.groupBox1.Controls.Add(this.nudColumnas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(113, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 102);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel Personalizado";
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 206);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNombre);
            this.Name = "FormDatos";
            this.Text = "Juego Nuevo";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nudFilas;
        public System.Windows.Forms.NumericUpDown nudColumnas;
        public System.Windows.Forms.NumericUpDown nudMinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbNivel;
    }
}