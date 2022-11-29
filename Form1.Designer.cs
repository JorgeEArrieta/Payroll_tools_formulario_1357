namespace Formulario1357
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl02 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lblPeriodoInformado = new System.Windows.Forms.Label();
            this.txtPerInformado = new System.Windows.Forms.TextBox();
            this.lbl03 = new System.Windows.Forms.Label();
            this.txtSecuencia = new System.Windows.Forms.TextBox();
            this.txtCodImpuesto = new System.Windows.Forms.TextBox();
            this.txt_codImpuesto = new System.Windows.Forms.Label();
            this.txtCodConcepto = new System.Windows.Forms.TextBox();
            this.lbl04 = new System.Windows.Forms.Label();
            this.txtNumFormulario = new System.Windows.Forms.TextBox();
            this.txt_nFormulario = new System.Windows.Forms.Label();
            this.txtTipPresentacion = new System.Windows.Forms.TextBox();
            this.lbl05 = new System.Windows.Forms.Label();
            this.txtVerSistema = new System.Windows.Forms.TextBox();
            this.txt_verSistema = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.procesoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarDatosToolStripMenuItem,
            this.exportarDatosToolStripMenuItem});
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.procesoToolStripMenuItem.Text = "Proceso";
            // 
            // importarDatosToolStripMenuItem
            // 
            this.importarDatosToolStripMenuItem.Name = "importarDatosToolStripMenuItem";
            this.importarDatosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.importarDatosToolStripMenuItem.Text = "Leer TXT";
            this.importarDatosToolStripMenuItem.Click += new System.EventHandler(this.importarDatosToolStripMenuItem_Click);
            // 
            // exportarDatosToolStripMenuItem
            // 
            this.exportarDatosToolStripMenuItem.Name = "exportarDatosToolStripMenuItem";
            this.exportarDatosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.exportarDatosToolStripMenuItem.Text = "Generar desde Excel";
            this.exportarDatosToolStripMenuItem.Click += new System.EventHandler(this.exportarDatosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.toolStripSeparator1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Location = new System.Drawing.Point(84, 86);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(41, 16);
            this.lbl02.TabIndex = 1;
            this.lbl02.Text = "CUIT:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(155, 87);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(158, 22);
            this.txtCUIT.TabIndex = 2;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(10, 42);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(183, 25);
            this.lbl01.TabIndex = 3;
            this.lbl01.Text = "Datos registro 01:";
            // 
            // lblPeriodoInformado
            // 
            this.lblPeriodoInformado.AutoSize = true;
            this.lblPeriodoInformado.Location = new System.Drawing.Point(341, 86);
            this.lblPeriodoInformado.Name = "lblPeriodoInformado";
            this.lblPeriodoInformado.Size = new System.Drawing.Size(121, 16);
            this.lblPeriodoInformado.TabIndex = 4;
            this.lblPeriodoInformado.Text = "Periodo informado:";
            // 
            // txtPerInformado
            // 
            this.txtPerInformado.Location = new System.Drawing.Point(476, 87);
            this.txtPerInformado.Name = "txtPerInformado";
            this.txtPerInformado.Size = new System.Drawing.Size(158, 22);
            this.txtPerInformado.TabIndex = 5;
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Location = new System.Drawing.Point(60, 127);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(74, 16);
            this.lbl03.TabIndex = 6;
            this.lbl03.Text = "Secuencia:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(155, 128);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(158, 22);
            this.txtSecuencia.TabIndex = 7;
            // 
            // txtCodImpuesto
            // 
            this.txtCodImpuesto.Location = new System.Drawing.Point(476, 128);
            this.txtCodImpuesto.Name = "txtCodImpuesto";
            this.txtCodImpuesto.Size = new System.Drawing.Size(158, 22);
            this.txtCodImpuesto.TabIndex = 9;
            // 
            // txt_codImpuesto
            // 
            this.txt_codImpuesto.AutoSize = true;
            this.txt_codImpuesto.Location = new System.Drawing.Point(349, 127);
            this.txt_codImpuesto.Name = "txt_codImpuesto";
            this.txt_codImpuesto.Size = new System.Drawing.Size(112, 16);
            this.txt_codImpuesto.TabIndex = 8;
            this.txt_codImpuesto.Text = "Codigo impuesto:";
            // 
            // txtCodConcepto
            // 
            this.txtCodConcepto.Location = new System.Drawing.Point(155, 170);
            this.txtCodConcepto.Name = "txtCodConcepto";
            this.txtCodConcepto.Size = new System.Drawing.Size(158, 22);
            this.txtCodConcepto.TabIndex = 11;
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.Location = new System.Drawing.Point(35, 170);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(99, 16);
            this.lbl04.TabIndex = 10;
            this.lbl04.Text = "Cod. Concepto:";
            // 
            // txtNumFormulario
            // 
            this.txtNumFormulario.Location = new System.Drawing.Point(476, 170);
            this.txtNumFormulario.Name = "txtNumFormulario";
            this.txtNumFormulario.Size = new System.Drawing.Size(158, 22);
            this.txtNumFormulario.TabIndex = 13;
            // 
            // txt_nFormulario
            // 
            this.txt_nFormulario.AutoSize = true;
            this.txt_nFormulario.Location = new System.Drawing.Point(341, 170);
            this.txt_nFormulario.Name = "txt_nFormulario";
            this.txt_nFormulario.Size = new System.Drawing.Size(120, 16);
            this.txt_nFormulario.TabIndex = 12;
            this.txt_nFormulario.Text = "Número formulario:";
            // 
            // txtTipPresentacion
            // 
            this.txtTipPresentacion.Location = new System.Drawing.Point(155, 212);
            this.txtTipPresentacion.Name = "txtTipPresentacion";
            this.txtTipPresentacion.Size = new System.Drawing.Size(158, 22);
            this.txtTipPresentacion.TabIndex = 15;
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.Location = new System.Drawing.Point(15, 212);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(119, 16);
            this.lbl05.TabIndex = 14;
            this.lbl05.Text = "Tipo presentación:";
            // 
            // txtVerSistema
            // 
            this.txtVerSistema.Location = new System.Drawing.Point(476, 212);
            this.txtVerSistema.Name = "txtVerSistema";
            this.txtVerSistema.Size = new System.Drawing.Size(158, 22);
            this.txtVerSistema.TabIndex = 17;
            // 
            // txt_verSistema
            // 
            this.txt_verSistema.AutoSize = true;
            this.txt_verSistema.Location = new System.Drawing.Point(356, 212);
            this.txt_verSistema.Name = "txt_verSistema";
            this.txt_verSistema.Size = new System.Drawing.Size(106, 16);
            this.txt_verSistema.TabIndex = 16;
            this.txt_verSistema.Text = "Versión sistema:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 257);
            this.Controls.Add(this.txtVerSistema);
            this.Controls.Add(this.txt_verSistema);
            this.Controls.Add(this.txtTipPresentacion);
            this.Controls.Add(this.lbl05);
            this.Controls.Add(this.txtNumFormulario);
            this.Controls.Add(this.txt_nFormulario);
            this.Controls.Add(this.txtCodConcepto);
            this.Controls.Add(this.lbl04);
            this.Controls.Add(this.txtCodImpuesto);
            this.Controls.Add(this.txt_codImpuesto);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.lbl03);
            this.Controls.Add(this.txtPerInformado);
            this.Controls.Add(this.lblPeriodoInformado);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Payroll tools - Procesador Formulario1357";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lblPeriodoInformado;
        private System.Windows.Forms.TextBox txtPerInformado;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.TextBox txtSecuencia;
        private System.Windows.Forms.TextBox txtCodImpuesto;
        private System.Windows.Forms.Label txt_codImpuesto;
        private System.Windows.Forms.TextBox txtCodConcepto;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.TextBox txtNumFormulario;
        private System.Windows.Forms.Label txt_nFormulario;
        private System.Windows.Forms.TextBox txtTipPresentacion;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.TextBox txtVerSistema;
        private System.Windows.Forms.Label txt_verSistema;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

