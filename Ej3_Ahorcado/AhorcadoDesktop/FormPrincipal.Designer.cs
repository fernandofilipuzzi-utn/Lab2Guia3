
namespace AhorcadoDesktop
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
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.tbLetra = new System.Windows.Forms.TextBox();
            this.lbIntentos = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
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
            this.btnNuevo.Location = new System.Drawing.Point(395, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 50);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Location = new System.Drawing.Point(395, 134);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(104, 55);
            this.btnVerHistorial.TabIndex = 12;
            this.btnVerHistorial.Text = "Ver Historial";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbPalabra
            // 
            this.tbPalabra.Enabled = false;
            this.tbPalabra.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPalabra.Location = new System.Drawing.Point(39, 25);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(325, 31);
            this.tbPalabra.TabIndex = 13;
            // 
            // tbLetra
            // 
            this.tbLetra.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLetra.Location = new System.Drawing.Point(322, 97);
            this.tbLetra.Name = "tbLetra";
            this.tbLetra.Size = new System.Drawing.Size(29, 31);
            this.tbLetra.TabIndex = 14;
            // 
            // lbIntentos
            // 
            this.lbIntentos.AutoSize = true;
            this.lbIntentos.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbIntentos.Location = new System.Drawing.Point(35, 100);
            this.lbIntentos.Name = "lbIntentos";
            this.lbIntentos.Size = new System.Drawing.Size(88, 23);
            this.lbIntentos.TabIndex = 15;
            this.lbIntentos.Text = "lbIntentos";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(395, 78);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(104, 50);
            this.btnJugar.TabIndex = 16;
            this.btnJugar.Text = "Adivinar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 201);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lbIntentos);
            this.Controls.Add(this.tbLetra);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "AhorcadoiDesktop";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.TextBox tbLetra;
        private System.Windows.Forms.Label lbIntentos;
        private System.Windows.Forms.Button btnJugar;
    }
}

