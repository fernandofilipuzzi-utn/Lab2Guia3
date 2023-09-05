
namespace BatallaNavalDesktop
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTableroJ1 = new System.Windows.Forms.DataGridView();
            this.dgvTableroJ2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "N.png");
            this.imageList1.Images.SetKeyName(1, "O.png");
            this.imageList1.Images.SetKeyName(2, "X.png");
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(830, 44);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 55);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Listar Historial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnListarHistorial_Click);
            // 
            // dgvTableroJ1
            // 
            this.dgvTableroJ1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableroJ1.Location = new System.Drawing.Point(12, 44);
            this.dgvTableroJ1.Name = "dgvTableroJ1";
            this.dgvTableroJ1.Size = new System.Drawing.Size(390, 481);
            this.dgvTableroJ1.TabIndex = 13;
            this.dgvTableroJ1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTableroJ1_CellMouseClick);
            // 
            // dgvTableroJ2
            // 
            this.dgvTableroJ2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableroJ2.Location = new System.Drawing.Point(418, 44);
            this.dgvTableroJ2.Name = "dgvTableroJ2";
            this.dgvTableroJ2.Size = new System.Drawing.Size(390, 481);
            this.dgvTableroJ2.TabIndex = 14;
            this.dgvTableroJ2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTableroJ2_CellMouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lancha",
            "Lancha",
            "Crucero",
            "SubMarino",
            "Buque",
            "PortaAviones"});
            this.comboBox1.Location = new System.Drawing.Point(91, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(243, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "Agregar Embarcacion";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 532);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvTableroJ2);
            this.Controls.Add(this.dgvTableroJ1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Escaleras y Serpientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTableroJ1;
        private System.Windows.Forms.DataGridView dgvTableroJ2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}

