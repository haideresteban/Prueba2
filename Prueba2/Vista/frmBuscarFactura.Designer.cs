namespace Prueba2.Vista
{
    partial class frmBuscarFactura
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
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.comboParametro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblParametro = new System.Windows.Forms.Label();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(466, 12);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(134, 20);
            this.txtIdentificacion.TabIndex = 0;
            this.txtIdentificacion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un parametro de busqueda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridFacturas
            // 
            this.gridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacturas.Location = new System.Drawing.Point(1, 68);
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.Size = new System.Drawing.Size(801, 203);
            this.gridFacturas.TabIndex = 3;
            // 
            // comboParametro
            // 
            this.comboParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParametro.FormattingEnabled = true;
            this.comboParametro.Items.AddRange(new object[] {
            "Identificacion propietario",
            "Placa vehiculo",
            "Intervalo de fechas"});
            this.comboParametro.Location = new System.Drawing.Point(17, 30);
            this.comboParametro.Name = "comboParametro";
            this.comboParametro.Size = new System.Drawing.Size(210, 21);
            this.comboParametro.TabIndex = 4;
            this.comboParametro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Image = global::Prueba2.Properties.Resources.buscar_usuario_con_corbata;
            this.btnBuscar.Location = new System.Drawing.Point(606, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro.Location = new System.Drawing.Point(299, 12);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(165, 15);
            this.lblParametro.TabIndex = 5;
            this.lblParametro.Text = "Ingrese la placa del vehiculo:";
            this.lblParametro.Visible = false;
            // 
            // dateInicio
            // 
            this.dateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicio.Location = new System.Drawing.Point(302, 34);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(146, 20);
            this.dateInicio.TabIndex = 6;
            this.dateInicio.Visible = false;
            // 
            // dateFin
            // 
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFin.Location = new System.Drawing.Point(454, 34);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(146, 20);
            this.dateFin.TabIndex = 7;
            this.dateFin.Visible = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetalle.Location = new System.Drawing.Point(692, 21);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(81, 30);
            this.btnDetalle.TabIndex = 8;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(803, 272);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.comboParametro);
            this.Controls.Add(this.gridFacturas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificacion);
            this.MaximizeBox = false;
            this.Name = "frmBuscarFactura";
            this.Text = "frmBuscarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.ComboBox comboParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Button btnDetalle;
    }
}