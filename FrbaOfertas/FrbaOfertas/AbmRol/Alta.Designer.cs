﻿namespace FrbaOfertas.AbmRol
{
    partial class Alta
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.funcionalidadesASeleccionar = new System.Windows.Forms.CheckedListBox();
            this.confirmarAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(118, 37);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionalidades";
            // 
            // funcionalidadesASeleccionar
            // 
            this.funcionalidadesASeleccionar.FormattingEnabled = true;
            this.funcionalidadesASeleccionar.Location = new System.Drawing.Point(31, 108);
            this.funcionalidadesASeleccionar.Name = "funcionalidadesASeleccionar";
            this.funcionalidadesASeleccionar.Size = new System.Drawing.Size(187, 94);
            this.funcionalidadesASeleccionar.TabIndex = 4;
            // 
            // confirmarAlta
            // 
            this.confirmarAlta.Location = new System.Drawing.Point(142, 222);
            this.confirmarAlta.Name = "confirmarAlta";
            this.confirmarAlta.Size = new System.Drawing.Size(75, 23);
            this.confirmarAlta.TabIndex = 5;
            this.confirmarAlta.Text = "Confirmar";
            this.confirmarAlta.UseVisualStyleBackColor = true;
            this.confirmarAlta.Click += new System.EventHandler(this.confirmarAlta_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.confirmarAlta);
            this.Controls.Add(this.funcionalidadesASeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "Alta";
            this.Text = "Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox funcionalidadesASeleccionar;
        private System.Windows.Forms.Button confirmarAlta;
    }
}