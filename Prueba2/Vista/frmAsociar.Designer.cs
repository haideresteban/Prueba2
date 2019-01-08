namespace Prueba2.Vista
{
    partial class frmAsociar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsociar));
            this.lblIden = new System.Windows.Forms.Label();
            this.txtIedentificacion = new System.Windows.Forms.TextBox();
            this.btnBuscarVehiculo = new System.Windows.Forms.Button();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIden
            // 
            this.lblIden.AutoSize = true;
            this.lblIden.Location = new System.Drawing.Point(12, 30);
            this.lblIden.Name = "lblIden";
            this.lblIden.Size = new System.Drawing.Size(129, 13);
            this.lblIden.TabIndex = 0;
            this.lblIden.Text = "Ingrese una Identificacion";
            // 
            // txtIedentificacion
            // 
            this.txtIedentificacion.Location = new System.Drawing.Point(147, 27);
            this.txtIedentificacion.Name = "txtIedentificacion";
            this.txtIedentificacion.Size = new System.Drawing.Size(214, 20);
            this.txtIedentificacion.TabIndex = 2;
            // 
            // btnBuscarVehiculo
            // 
            this.btnBuscarVehiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarVehiculo.BackgroundImage")));
            this.btnBuscarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarVehiculo.Location = new System.Drawing.Point(367, 23);
            this.btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            this.btnBuscarVehiculo.Size = new System.Drawing.Size(34, 27);
            this.btnBuscarVehiculo.TabIndex = 3;
            this.btnBuscarVehiculo.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculo.Click += new System.EventHandler(this.btnBuscarVehiculo_Click);
            // 
            // btnAsociar
            // 
            this.btnAsociar.Enabled = false;
            this.btnAsociar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociar.Location = new System.Drawing.Point(68, 104);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(117, 44);
            this.btnAsociar.TabIndex = 4;
            this.btnAsociar.Text = "Asociar";
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(233, 104);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(128, 44);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(12, 69);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(0, 16);
            this.lblConfirmar.TabIndex = 6;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(320, 151);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(0, 13);
            this.lblIdentificacion.TabIndex = 7;
            // 
            // frmAsociar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 173);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.btnBuscarVehiculo);
            this.Controls.Add(this.txtIedentificacion);
            this.Controls.Add(this.lblIden);
            this.Name = "frmAsociar";
            this.Text = "frmAsociar";
            this.Load += new System.EventHandler(this.frmAsociar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIden;
        private System.Windows.Forms.TextBox txtIedentificacion;
        private System.Windows.Forms.Button btnBuscarVehiculo;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblIdentificacion;
    }
}