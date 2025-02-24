﻿namespace TrabajoPrácticoPAV.Formularios.Pais
{
    partial class Frm_ModificarPais
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
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_aceptar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idPais = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(251, 165);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(120, 34);
            this.btn_cancelar.TabIndex = 66;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_aceptar.Location = new System.Drawing.Point(99, 165);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Pp_Presionado = false;
            this.btn_aceptar.Size = new System.Drawing.Size(120, 34);
            this.btn_aceptar.TabIndex = 65;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(163, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(65, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Id";
            // 
            // txt_idPais
            // 
            this.txt_idPais.Enabled = false;
            this.txt_idPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_idPais.Location = new System.Drawing.Point(99, 85);
            this.txt_idPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idPais.Mask = "999";
            this.txt_idPais.Name = "txt_idPais";
            this.txt_idPais.Pp_EsPk = true;
            this.txt_idPais.Pp_MensajeError = "Ingrese un ID";
            this.txt_idPais.Pp_NombreCampo = "idPais";
            this.txt_idPais.Pp_NombreTabla = "Pais";
            this.txt_idPais.Size = new System.Drawing.Size(40, 27);
            this.txt_idPais.TabIndex = 63;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_nombre.Location = new System.Drawing.Point(263, 85);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = "Ingrese el nombre";
            this.txt_nombre.Pp_NombreCampo = "nombrePais";
            this.txt_nombre.Pp_NombreTabla = "Pais";
            this.txt_nombre.Size = new System.Drawing.Size(225, 27);
            this.txt_nombre.TabIndex = 64;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.label15);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(525, 39);
            this.BarraSuperior.TabIndex = 67;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "MODIFICAR PAÍS";
            // 
            // Frm_ModificarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 249);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idPais);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ModificarPais";
            this.Text = "Frm_ModificarPais";
            this.Load += new System.EventHandler(this.Frm_ModificarPais_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.Button_Aerolinea btn_cancelar;
        private Clase.Button_Aerolinea btn_aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clase.MaskedTextBox_Aerolinea txt_idPais;
        private Clase.TextBox_Aerolinea txt_nombre;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label label15;
    }
}