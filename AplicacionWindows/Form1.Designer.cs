namespace AplicacionWindows
{
    partial class frmPrincipal
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtConsumosBimestre = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotalkwh = new System.Windows.Forms.TextBox();
            this.lblimpuestos = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.grpgeneral = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpesos = new System.Windows.Forms.Label();
            this.txtImporteKwh = new System.Windows.Forms.TextBox();
            this.lblImportekwh = new System.Windows.Forms.Label();
            this.grpDepartamento = new System.Windows.Forms.GroupBox();
            this.lblkwh = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblImporteaPagar = new System.Windows.Forms.Label();
            this.grpgeneral.SuspendLayout();
            this.grpDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitulo.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltitulo.Location = new System.Drawing.Point(119, 19);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltitulo.Size = new System.Drawing.Size(395, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Calculo Luz Bimestre";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtConsumosBimestre
            // 
            this.txtConsumosBimestre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtConsumosBimestre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumosBimestre.Location = new System.Drawing.Point(6, 39);
            this.txtConsumosBimestre.Name = "txtConsumosBimestre";
            this.txtConsumosBimestre.Size = new System.Drawing.Size(103, 29);
            this.txtConsumosBimestre.TabIndex = 6;
            this.txtConsumosBimestre.TextChanged += new System.EventHandler(this.txtConsumosBimestre_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(17, 46);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(61, 13);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Total Kwh :";
            // 
            // txttotalkwh
            // 
            this.txttotalkwh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalkwh.BackColor = System.Drawing.SystemColors.Window;
            this.txttotalkwh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalkwh.Location = new System.Drawing.Point(146, 39);
            this.txttotalkwh.Name = "txttotalkwh";
            this.txttotalkwh.Size = new System.Drawing.Size(100, 29);
            this.txttotalkwh.TabIndex = 2;
            this.txttotalkwh.TextChanged += new System.EventHandler(this.txttotalkwh_TextChanged);
            // 
            // lblimpuestos
            // 
            this.lblimpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblimpuestos.AutoSize = true;
            this.lblimpuestos.Location = new System.Drawing.Point(21, 132);
            this.lblimpuestos.Name = "lblimpuestos";
            this.lblimpuestos.Size = new System.Drawing.Size(61, 13);
            this.lblimpuestos.TabIndex = 3;
            this.lblimpuestos.Text = "Impuestos :";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuestos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuestos.Location = new System.Drawing.Point(146, 125);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(100, 29);
            this.txtImpuestos.TabIndex = 4;
            this.txtImpuestos.TextChanged += new System.EventHandler(this.txtImpuestos_TextChanged);
            // 
            // grpgeneral
            // 
            this.grpgeneral.Controls.Add(this.label1);
            this.grpgeneral.Controls.Add(this.label2);
            this.grpgeneral.Controls.Add(this.lblpesos);
            this.grpgeneral.Controls.Add(this.txtImporteKwh);
            this.grpgeneral.Controls.Add(this.lblImportekwh);
            this.grpgeneral.Controls.Add(this.txtImpuestos);
            this.grpgeneral.Controls.Add(this.lblimpuestos);
            this.grpgeneral.Controls.Add(this.txttotalkwh);
            this.grpgeneral.Controls.Add(this.lbltotal);
            this.grpgeneral.Location = new System.Drawing.Point(39, 82);
            this.grpgeneral.Name = "grpgeneral";
            this.grpgeneral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpgeneral.Size = new System.Drawing.Size(309, 192);
            this.grpgeneral.TabIndex = 7;
            this.grpgeneral.TabStop = false;
            this.grpgeneral.Text = "Totales factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "KWH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "$";
            // 
            // lblpesos
            // 
            this.lblpesos.AutoSize = true;
            this.lblpesos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesos.Location = new System.Drawing.Point(122, 88);
            this.lblpesos.Name = "lblpesos";
            this.lblpesos.Size = new System.Drawing.Size(18, 18);
            this.lblpesos.TabIndex = 9;
            this.lblpesos.Text = "$";
            // 
            // txtImporteKwh
            // 
            this.txtImporteKwh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteKwh.Location = new System.Drawing.Point(146, 82);
            this.txtImporteKwh.Name = "txtImporteKwh";
            this.txtImporteKwh.Size = new System.Drawing.Size(100, 29);
            this.txtImporteKwh.TabIndex = 8;
            this.txtImporteKwh.TextChanged += new System.EventHandler(this.txtImporteKwh_TextChanged);
            // 
            // lblImportekwh
            // 
            this.lblImportekwh.AutoSize = true;
            this.lblImportekwh.Location = new System.Drawing.Point(17, 93);
            this.lblImportekwh.Name = "lblImportekwh";
            this.lblImportekwh.Size = new System.Drawing.Size(111, 13);
            this.lblImportekwh.TabIndex = 7;
            this.lblImportekwh.Text = "Importe KWH totales: ";
            // 
            // grpDepartamento
            // 
            this.grpDepartamento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grpDepartamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDepartamento.Controls.Add(this.lblkwh);
            this.grpDepartamento.Controls.Add(this.txtConsumosBimestre);
            this.grpDepartamento.Location = new System.Drawing.Point(354, 82);
            this.grpDepartamento.Name = "grpDepartamento";
            this.grpDepartamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpDepartamento.Size = new System.Drawing.Size(286, 192);
            this.grpDepartamento.TabIndex = 8;
            this.grpDepartamento.TabStop = false;
            this.grpDepartamento.Text = "Consumos Bimestrales del departamento";
            // 
            // lblkwh
            // 
            this.lblkwh.AutoSize = true;
            this.lblkwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkwh.Location = new System.Drawing.Point(115, 52);
            this.lblkwh.Name = "lblkwh";
            this.lblkwh.Size = new System.Drawing.Size(114, 16);
            this.lblkwh.TabIndex = 7;
            this.lblkwh.Text = "Kwh/Mensuales";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(83, 381);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(220, 23);
            this.lblresultado.TabIndex = 9;
            this.lblresultado.Text = "Total a pagar :";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatAppearance.BorderSize = 4;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(91, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(455, 47);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular importe a pagar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblImporteaPagar
            // 
            this.lblImporteaPagar.AutoSize = true;
            this.lblImporteaPagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteaPagar.ForeColor = System.Drawing.Color.Red;
            this.lblImporteaPagar.Location = new System.Drawing.Point(320, 364);
            this.lblImporteaPagar.Name = "lblImporteaPagar";
            this.lblImporteaPagar.Size = new System.Drawing.Size(0, 40);
            this.lblImporteaPagar.TabIndex = 12;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.lblImporteaPagar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpDepartamento);
            this.Controls.Add(this.grpgeneral);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpgeneral.ResumeLayout(false);
            this.grpgeneral.PerformLayout();
            this.grpDepartamento.ResumeLayout(false);
            this.grpDepartamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtConsumosBimestre;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotalkwh;
        private System.Windows.Forms.Label lblimpuestos;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.GroupBox grpgeneral;
        private System.Windows.Forms.GroupBox grpDepartamento;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblImporteaPagar;
        private System.Windows.Forms.Label lblImportekwh;
        private System.Windows.Forms.TextBox txtImporteKwh;
        private System.Windows.Forms.Label lblkwh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpesos;
        private System.Windows.Forms.Label label1;
    }
}

