namespace Prueba2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDePropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVhiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarVehiculosYPropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fcaturacionDeTramitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDePropietariosToolStripMenuItem,
            this.gestionDeVhiculosToolStripMenuItem,
            this.asociarVehiculosYPropietariosToolStripMenuItem,
            this.fcaturacionDeTramitesToolStripMenuItem,
            this.buscarFacturasToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestiónDePropietariosToolStripMenuItem
            // 
            this.gestiónDePropietariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.mmToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.gestiónDePropietariosToolStripMenuItem.Image = global::Prueba2.Properties.Resources._306232;
            this.gestiónDePropietariosToolStripMenuItem.Name = "gestiónDePropietariosToolStripMenuItem";
            this.gestiónDePropietariosToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.gestiónDePropietariosToolStripMenuItem.Text = "Gestión de propietarios";
            this.gestiónDePropietariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePropietariosToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // mmToolStripMenuItem
            // 
            this.mmToolStripMenuItem.Name = "mmToolStripMenuItem";
            this.mmToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mmToolStripMenuItem.Text = "Listar";
            this.mmToolStripMenuItem.Click += new System.EventHandler(this.mmToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // gestionDeVhiculosToolStripMenuItem
            // 
            this.gestionDeVhiculosToolStripMenuItem.Image = global::Prueba2.Properties.Resources.auto_1941991_960_720;
            this.gestionDeVhiculosToolStripMenuItem.Name = "gestionDeVhiculosToolStripMenuItem";
            this.gestionDeVhiculosToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.gestionDeVhiculosToolStripMenuItem.Text = "Gestión de vehiculos";
            this.gestionDeVhiculosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeVhiculosToolStripMenuItem_Click);
            // 
            // asociarVehiculosYPropietariosToolStripMenuItem
            // 
            this.asociarVehiculosYPropietariosToolStripMenuItem.Name = "asociarVehiculosYPropietariosToolStripMenuItem";
            this.asociarVehiculosYPropietariosToolStripMenuItem.Size = new System.Drawing.Size(186, 20);
            this.asociarVehiculosYPropietariosToolStripMenuItem.Text = "Asociar Vehiculos y Propietarios";
            this.asociarVehiculosYPropietariosToolStripMenuItem.Click += new System.EventHandler(this.asociarVehiculosYPropietariosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Image = global::Prueba2.Properties.Resources.el_CFDI_3_3_I;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.reporteToolStripMenuItem.Text = "Ejemplo";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // fcaturacionDeTramitesToolStripMenuItem
            // 
            this.fcaturacionDeTramitesToolStripMenuItem.Image = global::Prueba2.Properties.Resources.invoice;
            this.fcaturacionDeTramitesToolStripMenuItem.Name = "fcaturacionDeTramitesToolStripMenuItem";
            this.fcaturacionDeTramitesToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.fcaturacionDeTramitesToolStripMenuItem.Text = "Facturacion de tramites";
            this.fcaturacionDeTramitesToolStripMenuItem.Click += new System.EventHandler(this.fcaturacionDeTramitesToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.facturaToolStripMenuItem.Text = "Reporte propietarios";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // buscarFacturasToolStripMenuItem
            // 
            this.buscarFacturasToolStripMenuItem.Name = "buscarFacturasToolStripMenuItem";
            this.buscarFacturasToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.buscarFacturasToolStripMenuItem.Text = "Buscar Facturas";
            this.buscarFacturasToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 357);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVhiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarVehiculosYPropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fcaturacionDeTramitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturasToolStripMenuItem;
    }
}