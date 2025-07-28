namespace EXAMEN_FINAL___LABORATORIO_2
{
    partial class frmListadoSocioBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoSocioBarrio));
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirR = new System.Windows.Forms.Button();
            this.btnGenerarR = new System.Windows.Forms.Button();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblMenorD = new System.Windows.Forms.Label();
            this.lblMayorD = new System.Windows.Forms.Label();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Barrio:";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(104, 27);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(336, 21);
            this.cmbBarrio.TabIndex = 68;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Transparent;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnListar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListar.Location = new System.Drawing.Point(449, 11);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(203, 46);
            this.btnListar.TabIndex = 56;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalDeuda.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeuda.Location = new System.Drawing.Point(854, 205);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(119, 24);
            this.lblTotalDeuda.TabIndex = 64;
            this.lblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Grilla.Location = new System.Drawing.Point(23, 79);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(629, 339);
            this.Grilla.TabIndex = 63;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y apellido";
            this.Column2.Name = "Column2";
            this.Column2.Width = 340;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deuda";
            this.Column3.Name = "Column3";
            // 
            // btnImprimirR
            // 
            this.btnImprimirR.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirR.FlatAppearance.BorderSize = 0;
            this.btnImprimirR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirR.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimirR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimirR.Location = new System.Drawing.Point(740, 372);
            this.btnImprimirR.Name = "btnImprimirR";
            this.btnImprimirR.Size = new System.Drawing.Size(193, 46);
            this.btnImprimirR.TabIndex = 60;
            this.btnImprimirR.Text = "Imprimir Reporte";
            this.btnImprimirR.UseVisualStyleBackColor = false;
            this.btnImprimirR.Click += new System.EventHandler(this.btnImprimirR_Click);
            // 
            // btnGenerarR
            // 
            this.btnGenerarR.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarR.FlatAppearance.BorderSize = 0;
            this.btnGenerarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarR.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerarR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarR.Location = new System.Drawing.Point(740, 305);
            this.btnGenerarR.Name = "btnGenerarR";
            this.btnGenerarR.Size = new System.Drawing.Size(193, 46);
            this.btnGenerarR.TabIndex = 58;
            this.btnGenerarR.Text = "Generar Reporte";
            this.btnGenerarR.UseVisualStyleBackColor = false;
            this.btnGenerarR.Click += new System.EventHandler(this.btnGenerarR_Click);
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPromedioDeuda.ForeColor = System.Drawing.Color.White;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(853, 161);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(119, 24);
            this.lblPromedioDeuda.TabIndex = 61;
            this.lblPromedioDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMenorD
            // 
            this.lblMenorD.BackColor = System.Drawing.Color.Transparent;
            this.lblMenorD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenorD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMenorD.ForeColor = System.Drawing.Color.White;
            this.lblMenorD.Location = new System.Drawing.Point(853, 118);
            this.lblMenorD.Name = "lblMenorD";
            this.lblMenorD.Size = new System.Drawing.Size(119, 24);
            this.lblMenorD.TabIndex = 59;
            this.lblMenorD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMayorD
            // 
            this.lblMayorD.BackColor = System.Drawing.Color.Transparent;
            this.lblMayorD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayorD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMayorD.ForeColor = System.Drawing.Color.White;
            this.lblMayorD.Location = new System.Drawing.Point(853, 79);
            this.lblMayorD.Name = "lblMayorD";
            this.lblMayorD.Size = new System.Drawing.Size(119, 24);
            this.lblMayorD.TabIndex = 57;
            this.lblMayorD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(705, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 42);
            this.label6.TabIndex = 73;
            this.label6.Text = "Mayor deuda:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(718, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 34);
            this.label7.TabIndex = 72;
            this.label7.Text = "Menor deuda:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(686, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 42);
            this.label8.TabIndex = 70;
            this.label8.Text = "Promedio de deuda:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(715, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 42);
            this.label9.TabIndex = 71;
            this.label9.Text = "Total de deuda:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(974, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 35);
            this.btnCerrar.TabIndex = 76;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmListadoSocioBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 445);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.btnImprimirR);
            this.Controls.Add(this.btnGenerarR);
            this.Controls.Add(this.lblPromedioDeuda);
            this.Controls.Add(this.lblMenorD);
            this.Controls.Add(this.lblMayorD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoSocioBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Socio por Barrio";
            this.Load += new System.EventHandler(this.frmListadoSocioBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnImprimirR;
        private System.Windows.Forms.Button btnGenerarR;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblMenorD;
        private System.Windows.Forms.Label lblMayorD;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCerrar;
    }
}