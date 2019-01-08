namespace Prueba2.Vista
{
    partial class frmAsociarVehiculoxPropie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsociarVehiculoxPropie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnBuscarVehiculo = new System.Windows.Forms.Button();
            this.gridPropietarioPorPlaca = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblprueba = new System.Windows.Forms.Label();
            this.gridVehiculo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPropietarioPorPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la placa del vehiculo: ";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(230, 30);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(133, 20);
            this.txtPlaca.TabIndex = 1;
            // 
            // btnBuscarVehiculo
            // 
            this.btnBuscarVehiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarVehiculo.BackgroundImage")));
            this.btnBuscarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarVehiculo.Location = new System.Drawing.Point(369, 26);
            this.btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            this.btnBuscarVehiculo.Size = new System.Drawing.Size(34, 27);
            this.btnBuscarVehiculo.TabIndex = 2;
            this.btnBuscarVehiculo.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculo.Click += new System.EventHandler(this.btnBUscarVehiculo_Click);
            // 
            // gridPropietarioPorPlaca
            // 
            this.gridPropietarioPorPlaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPropietarioPorPlaca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPropietarioPorPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPropietarioPorPlaca.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPropietarioPorPlaca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPropietarioPorPlaca.Enabled = false;
            this.gridPropietarioPorPlaca.EnableHeadersVisualStyles = false;
            this.gridPropietarioPorPlaca.Location = new System.Drawing.Point(0, 229);
            this.gridPropietarioPorPlaca.Name = "gridPropietarioPorPlaca";
            this.gridPropietarioPorPlaca.Size = new System.Drawing.Size(654, 110);
            this.gridPropietarioPorPlaca.TabIndex = 3;
            this.gridPropietarioPorPlaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPropietarioPorPlaca_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(359, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 47);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Propietario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(495, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.Location = new System.Drawing.Point(402, 9);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(10, 13);
            this.lblprueba.TabIndex = 6;
            this.lblprueba.Text = " ";
            // 
            // gridVehiculo
            // 
            this.gridVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVehiculo.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridVehiculo.EnableHeadersVisualStyles = false;
            this.gridVehiculo.Location = new System.Drawing.Point(-1, 64);
            this.gridVehiculo.Name = "gridVehiculo";
            this.gridVehiculo.Size = new System.Drawing.Size(655, 70);
            this.gridVehiculo.TabIndex = 7;
            this.gridVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVehiculo_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "DATOS PROPIETARIOS";
            // 
            // frmAsociarVehiculoxPropie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(654, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridVehiculo);
            this.Controls.Add(this.lblprueba);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridPropietarioPorPlaca);
            this.Controls.Add(this.btnBuscarVehiculo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmAsociarVehiculoxPropie";
            this.Text = "frmAsociarVehiculoxPropie";
            this.Load += new System.EventHandler(this.frmAsociarVehiculoxPropie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPropietarioPorPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnBuscarVehiculo;
        private System.Windows.Forms.DataGridView gridPropietarioPorPlaca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblprueba;
        private System.Windows.Forms.DataGridView gridVehiculo;
        private System.Windows.Forms.Label label2;
    }
}