namespace EXAMEN_FINAL___LABORATORIO_2
{
    partial class frmListadoTotalSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoTotalSocios));
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirR = new System.Windows.Forms.Button();
            this.btnGenerarR = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenorD = new System.Windows.Forms.Label();
            this.lblMayorD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalDeuda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalDeuda.Location = new System.Drawing.Point(842, 193);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(119, 24);
            this.lblTotalDeuda.TabIndex = 29;
            this.lblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPromedioDeuda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(842, 153);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(119, 23);
            this.lblPromedioDeuda.TabIndex = 28;
            this.lblPromedioDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(699, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mayor deuda:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(699, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Menor deuda:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Transparent;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnListar.Location = new System.Drawing.Point(735, 295);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(193, 47);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Grilla.Location = new System.Drawing.Point(26, 30);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(629, 440);
            this.Grilla.TabIndex = 24;
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
            this.btnImprimirR.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnImprimirR.ForeColor = System.Drawing.SystemColors.Info;
            this.btnImprimirR.Location = new System.Drawing.Point(735, 423);
            this.btnImprimirR.Name = "btnImprimirR";
            this.btnImprimirR.Size = new System.Drawing.Size(193, 47);
            this.btnImprimirR.TabIndex = 22;
            this.btnImprimirR.Text = "Imprimir Reporte";
            this.btnImprimirR.UseVisualStyleBackColor = false;
            this.btnImprimirR.Click += new System.EventHandler(this.btnImprimirR_Click);
            // 
            // btnGenerarR
            // 
            this.btnGenerarR.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarR.FlatAppearance.BorderSize = 0;
            this.btnGenerarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarR.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnGenerarR.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenerarR.Location = new System.Drawing.Point(735, 356);
            this.btnGenerarR.Name = "btnGenerarR";
            this.btnGenerarR.Size = new System.Drawing.Size(193, 47);
            this.btnGenerarR.TabIndex = 20;
            this.btnGenerarR.Text = "Generar Reporte";
            this.btnGenerarR.UseVisualStyleBackColor = false;
            this.btnGenerarR.Click += new System.EventHandler(this.btnGenerarR_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedio.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPromedio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPromedio.Location = new System.Drawing.Point(675, 157);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(160, 21);
            this.lblPromedio.TabIndex = 23;
            this.lblPromedio.Text = "Promedio de deuda:";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenorD
            // 
            this.lblMenorD.BackColor = System.Drawing.Color.Transparent;
            this.lblMenorD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenorD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMenorD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMenorD.Location = new System.Drawing.Point(842, 113);
            this.lblMenorD.Name = "lblMenorD";
            this.lblMenorD.Size = new System.Drawing.Size(119, 24);
            this.lblMenorD.TabIndex = 21;
            this.lblMenorD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMayorD
            // 
            this.lblMayorD.BackColor = System.Drawing.Color.Transparent;
            this.lblMayorD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayorD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMayorD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMayorD.Location = new System.Drawing.Point(842, 73);
            this.lblMayorD.Name = "lblMayorD";
            this.lblMayorD.Size = new System.Drawing.Size(119, 23);
            this.lblMayorD.TabIndex = 19;
            this.lblMayorD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(699, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total de deuda:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage_1);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(963, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 35);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmListadoTotalSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.lblPromedioDeuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.btnImprimirR);
            this.Controls.Add(this.btnGenerarR);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblMenorD);
            this.Controls.Add(this.lblMayorD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoTotalSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Total de Socios";
            this.Load += new System.EventHandler(this.frmListadoTotalSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnImprimirR;
        private System.Windows.Forms.Button btnGenerarR;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenorD;
        private System.Windows.Forms.Label lblMayorD;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Windows.Forms.Button btnCerrar;
    }
}