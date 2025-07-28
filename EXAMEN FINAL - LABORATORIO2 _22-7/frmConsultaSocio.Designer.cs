namespace EXAMEN_FINAL___LABORATORIO_2
{
    partial class frmConsultaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSocio));
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSocio
            // 
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(153, 36);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(282, 21);
            this.cmbSocio.TabIndex = 12;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrar.Location = new System.Drawing.Point(475, 23);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(162, 49);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del socio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosCliente.Controls.Add(this.lblDeuda);
            this.grpDatosCliente.Controls.Add(this.label11);
            this.grpDatosCliente.Controls.Add(this.lblActividad);
            this.grpDatosCliente.Controls.Add(this.label3);
            this.grpDatosCliente.Controls.Add(this.lblBarrio);
            this.grpDatosCliente.Controls.Add(this.label7);
            this.grpDatosCliente.Controls.Add(this.lblDomicilio);
            this.grpDatosCliente.Controls.Add(this.label5);
            this.grpDatosCliente.Controls.Add(this.lblDni);
            this.grpDatosCliente.Controls.Add(this.label4);
            this.grpDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosCliente.Location = new System.Drawing.Point(22, 108);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(636, 292);
            this.grpDatosCliente.TabIndex = 9;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del Socio";
            // 
            // lblDeuda
            // 
            this.lblDeuda.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeuda.Location = new System.Drawing.Point(152, 249);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(240, 23);
            this.lblDeuda.TabIndex = 12;
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(66, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Deuda:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActividad
            // 
            this.lblActividad.BackColor = System.Drawing.Color.Transparent;
            this.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActividad.Location = new System.Drawing.Point(152, 194);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(240, 25);
            this.lblActividad.TabIndex = 9;
            this.lblActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Actividad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBarrio
            // 
            this.lblBarrio.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarrio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBarrio.Location = new System.Drawing.Point(152, 146);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(441, 23);
            this.lblBarrio.TabIndex = 8;
            this.lblBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightYellow;
            this.label7.Location = new System.Drawing.Point(66, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Barrio:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDomicilio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDomicilio.Location = new System.Drawing.Point(152, 93);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(441, 25);
            this.lblDomicilio.TabIndex = 5;
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(46, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Domicilio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDni.Location = new System.Drawing.Point(152, 45);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(240, 25);
            this.lblDni.TabIndex = 4;
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(66, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "D.N.I:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(648, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 35);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmConsultaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbSocio);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDatosCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Socio";
            this.Load += new System.EventHandler(this.frmConsultaSocio_Load);
            this.grpDatosCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
    }
}