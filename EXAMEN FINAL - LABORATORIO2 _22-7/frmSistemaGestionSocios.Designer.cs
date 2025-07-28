namespace EXAMEN_FINAL___LABORATORIO_2
{
    partial class frmSistemaGestionSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistemaGestionSocios));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoTotalSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoSociosDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoSociosPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoSociosPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMiniminizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sociosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDesarrolladorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // informacionDesarrolladorToolStripMenuItem
            // 
            this.informacionDesarrolladorToolStripMenuItem.Name = "informacionDesarrolladorToolStripMenuItem";
            this.informacionDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.informacionDesarrolladorToolStripMenuItem.Text = "Informacion Desarrollador";
            this.informacionDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.informacionDesarrolladorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoSocioToolStripMenuItem,
            this.buscarSocioToolStripMenuItem,
            this.consultaDeSocioToolStripMenuItem,
            this.toolStripMenuItem2,
            this.listadoTotalSociosToolStripMenuItem,
            this.listadoSociosDeudoresToolStripMenuItem,
            this.listadoSociosPorActividadToolStripMenuItem,
            this.listadoSociosPorBarrioToolStripMenuItem});
            this.sociosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // agregarNuevoSocioToolStripMenuItem
            // 
            this.agregarNuevoSocioToolStripMenuItem.Name = "agregarNuevoSocioToolStripMenuItem";
            this.agregarNuevoSocioToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.agregarNuevoSocioToolStripMenuItem.Text = "Agregar Nuevo Socio...";
            this.agregarNuevoSocioToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoSocioToolStripMenuItem_Click);
            // 
            // buscarSocioToolStripMenuItem
            // 
            this.buscarSocioToolStripMenuItem.Name = "buscarSocioToolStripMenuItem";
            this.buscarSocioToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.buscarSocioToolStripMenuItem.Text = "Buscar Socio...";
            this.buscarSocioToolStripMenuItem.Click += new System.EventHandler(this.buscarSocioToolStripMenuItem_Click);
            // 
            // consultaDeSocioToolStripMenuItem
            // 
            this.consultaDeSocioToolStripMenuItem.Name = "consultaDeSocioToolStripMenuItem";
            this.consultaDeSocioToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.consultaDeSocioToolStripMenuItem.Text = "Consulta de Socio...";
            this.consultaDeSocioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeSocioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 6);
            // 
            // listadoTotalSociosToolStripMenuItem
            // 
            this.listadoTotalSociosToolStripMenuItem.Name = "listadoTotalSociosToolStripMenuItem";
            this.listadoTotalSociosToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listadoTotalSociosToolStripMenuItem.Text = "Listado Total Socios...";
            this.listadoTotalSociosToolStripMenuItem.Click += new System.EventHandler(this.listadoTotalSociosToolStripMenuItem_Click);
            // 
            // listadoSociosDeudoresToolStripMenuItem
            // 
            this.listadoSociosDeudoresToolStripMenuItem.Name = "listadoSociosDeudoresToolStripMenuItem";
            this.listadoSociosDeudoresToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listadoSociosDeudoresToolStripMenuItem.Text = "Listado Socios Deudores...";
            this.listadoSociosDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoSociosDeudoresToolStripMenuItem_Click);
            // 
            // listadoSociosPorActividadToolStripMenuItem
            // 
            this.listadoSociosPorActividadToolStripMenuItem.Name = "listadoSociosPorActividadToolStripMenuItem";
            this.listadoSociosPorActividadToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listadoSociosPorActividadToolStripMenuItem.Text = "Listado Socios por Actividad...";
            this.listadoSociosPorActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoSociosPorActividadToolStripMenuItem_Click);
            // 
            // listadoSociosPorBarrioToolStripMenuItem
            // 
            this.listadoSociosPorBarrioToolStripMenuItem.Name = "listadoSociosPorBarrioToolStripMenuItem";
            this.listadoSociosPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listadoSociosPorBarrioToolStripMenuItem.Text = "Listado Socios por Barrio...";
            this.listadoSociosPorBarrioToolStripMenuItem.Click += new System.EventHandler(this.listadoSociosPorBarrioToolStripMenuItem_Click);
            // 
            // btnMiniminizar
            // 
            this.btnMiniminizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniminizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMiniminizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMiniminizar.BackgroundImage")));
            this.btnMiniminizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMiniminizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiniminizar.FlatAppearance.BorderSize = 0;
            this.btnMiniminizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniminizar.Location = new System.Drawing.Point(684, 0);
            this.btnMiniminizar.Name = "btnMiniminizar";
            this.btnMiniminizar.Size = new System.Drawing.Size(39, 35);
            this.btnMiniminizar.TabIndex = 2;
            this.btnMiniminizar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMiniminizar.UseVisualStyleBackColor = false;
            this.btnMiniminizar.Click += new System.EventHandler(this.btnMiniminizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(729, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(39, 35);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Visible = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(729, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(39, 35);
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // frmSistemaGestionSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 409);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMiniminizar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSistemaGestionSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Gestion Socios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSistemaGestionSocios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoTotalSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoSociosDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoSociosPorActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoSociosPorBarrioToolStripMenuItem;
        private System.Windows.Forms.Button btnMiniminizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;
    }
}