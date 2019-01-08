namespace Prueba2.Vista
{
    partial class frmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contaioner = new System.Windows.Forms.SplitContainer();
            this.btnBuscarVehiculo = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentifiacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTramite = new System.Windows.Forms.ComboBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.gridTramites = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contaioner)).BeginInit();
            this.contaioner.Panel1.SuspendLayout();
            this.contaioner.Panel2.SuspendLayout();
            this.contaioner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTramites)).BeginInit();
            this.SuspendLayout();
            // 
            // contaioner
            // 
            this.contaioner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contaioner.Location = new System.Drawing.Point(0, 0);
            this.contaioner.Name = "contaioner";
            this.contaioner.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contaioner.Panel1
            // 
            this.contaioner.Panel1.Controls.Add(this.btnBuscarVehiculo);
            this.contaioner.Panel1.Controls.Add(this.txtPlaca);
            this.contaioner.Panel1.Controls.Add(this.label2);
            this.contaioner.Panel1.Controls.Add(this.txtIdentifiacion);
            this.contaioner.Panel1.Controls.Add(this.label1);
            // 
            // contaioner.Panel2
            // 
            this.contaioner.Panel2.Controls.Add(this.lblTotal);
            this.contaioner.Panel2.Controls.Add(this.label6);
            this.contaioner.Panel2.Controls.Add(this.label5);
            this.contaioner.Panel2.Controls.Add(this.cbTramite);
            this.contaioner.Panel2.Controls.Add(this.btnFacturar);
            this.contaioner.Panel2.Controls.Add(this.gridTramites);
            this.contaioner.Panel2.Controls.Add(this.label4);
            this.contaioner.Panel2.Controls.Add(this.dtFecha);
            this.contaioner.Panel2.Controls.Add(this.label3);
            this.contaioner.Panel2.Controls.Add(this.txtNumeroFactura);
            this.contaioner.Panel2.Enabled = false;
            this.contaioner.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.contaioner_Panel2_Paint);
            this.contaioner.Size = new System.Drawing.Size(723, 349);
            this.contaioner.SplitterDistance = 78;
            this.contaioner.TabIndex = 0;
            // 
            // btnBuscarVehiculo
            // 
            this.btnBuscarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVehiculo.Location = new System.Drawing.Point(556, 42);
            this.btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            this.btnBuscarVehiculo.Size = new System.Drawing.Size(146, 30);
            this.btnBuscarVehiculo.TabIndex = 4;
            this.btnBuscarVehiculo.Text = "Buscar datos";
            this.btnBuscarVehiculo.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculo.Click += new System.EventHandler(this.btnBuscarVehiculo_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(510, 16);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(192, 20);
            this.txtPlaca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese placa";
            // 
            // txtIdentifiacion
            // 
            this.txtIdentifiacion.Location = new System.Drawing.Point(166, 17);
            this.txtIdentifiacion.Name = "txtIdentifiacion";
            this.txtIdentifiacion.Size = new System.Drawing.Size(203, 20);
            this.txtIdentifiacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese identifiacion";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(79, 204);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tramite:";
            // 
            // cbTramite
            // 
            this.cbTramite.DisplayMember = "descripcion";
            this.cbTramite.FormattingEnabled = true;
            this.cbTramite.Location = new System.Drawing.Point(431, 15);
            this.cbTramite.Name = "cbTramite";
            this.cbTramite.Size = new System.Drawing.Size(246, 21);
            this.cbTramite.TabIndex = 17;
            this.cbTramite.ValueMember = "id";
            this.cbTramite.SelectedIndexChanged += new System.EventHandler(this.cbTramite_SelectedIndexChanged);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(556, 202);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(146, 30);
            this.btnFacturar.TabIndex = 5;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // gridTramites
            // 
            this.gridTramites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTramites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTramites.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridTramites.Location = new System.Drawing.Point(0, 74);
            this.gridTramites.Name = "gridTramites";
            this.gridTramites.Size = new System.Drawing.Size(723, 104);
            this.gridTramites.TabIndex = 7;
            this.gridTramites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTramites_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(95, 44);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 2;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nº Factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Enabled = false;
            this.txtNumeroFactura.Location = new System.Drawing.Point(95, 15);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroFactura.TabIndex = 0;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(723, 349);
            this.Controls.Add(this.contaioner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturacion";
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.contaioner.Panel1.ResumeLayout(false);
            this.contaioner.Panel1.PerformLayout();
            this.contaioner.Panel2.ResumeLayout(false);
            this.contaioner.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaioner)).EndInit();
            this.contaioner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTramites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer contaioner;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentifiacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.DataGridView gridTramites;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTramite;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
    }
}