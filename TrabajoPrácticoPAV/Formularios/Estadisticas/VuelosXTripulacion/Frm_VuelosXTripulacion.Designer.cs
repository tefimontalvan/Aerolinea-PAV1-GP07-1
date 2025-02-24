﻿namespace TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXTripulacion
{
    partial class Frm_VuelosXTripulacion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_cargo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu_Todos = new System.Windows.Forms.RadioButton();
            this.rbu_Cargo = new System.Windows.Forms.RadioButton();
            this.btn_Generar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXTripulacion.Reporte_VuelosXTri" +
    "pulacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(775, 390);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmb_cargo.FormattingEnabled = true;
            this.cmb_cargo.Location = new System.Drawing.Point(88, 24);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Pp_CampoAceptaNull = true;
            this.cmb_cargo.Pp_EsPk = false;
            this.cmb_cargo.Pp_MensajeError = null;
            this.cmb_cargo.Pp_NombreCampo = "nombre";
            this.cmb_cargo.Pp_NombreCampoInsert = null;
            this.cmb_cargo.Pp_NombreTabla = "Cargo_Tripulacion";
            this.cmb_cargo.Pp_PkTabla = "idCargoTripulacion";
            this.cmb_cargo.Size = new System.Drawing.Size(131, 26);
            this.cmb_cargo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu_Todos);
            this.groupBox1.Controls.Add(this.rbu_Cargo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(256, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 40);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rbu_Todos
            // 
            this.rbu_Todos.AutoSize = true;
            this.rbu_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_Todos.Location = new System.Drawing.Point(129, 16);
            this.rbu_Todos.Name = "rbu_Todos";
            this.rbu_Todos.Size = new System.Drawing.Size(66, 21);
            this.rbu_Todos.TabIndex = 1;
            this.rbu_Todos.TabStop = true;
            this.rbu_Todos.Text = "Todos";
            this.rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // rbu_Cargo
            // 
            this.rbu_Cargo.AutoSize = true;
            this.rbu_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbu_Cargo.Location = new System.Drawing.Point(15, 16);
            this.rbu_Cargo.Name = "rbu_Cargo";
            this.rbu_Cargo.Size = new System.Drawing.Size(90, 21);
            this.rbu_Cargo.TabIndex = 0;
            this.rbu_Cargo.TabStop = true;
            this.rbu_Cargo.Text = "Por Cargo";
            this.rbu_Cargo.UseVisualStyleBackColor = true;
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(698, 24);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Pp_Presionado = false;
            this.btn_Generar.Size = new System.Drawing.Size(90, 26);
            this.btn_Generar.TabIndex = 3;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // Frm_VuelosXTripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_cargo);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_VuelosXTripulacion";
            this.Text = "Frm_VuelosXTripulacion";
            this.Load += new System.EventHandler(this.Frm_VuelosXTripulacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Clase.ComboBox_Aerolinea cmb_cargo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu_Todos;
        private System.Windows.Forms.RadioButton rbu_Cargo;
        private Clase.Button_Aerolinea btn_Generar;
    }
}