﻿namespace FrbaOfertas.AbmCliente
{
    partial class Listado
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.tablaDeResultados = new System.Windows.Forms.DataGridView();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(25, 75);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(120, 20);
            this.nombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(659, 113);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 9;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(25, 113);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 8;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // tablaDeResultados
            // 
            this.tablaDeResultados.AllowUserToAddRows = false;
            this.tablaDeResultados.AllowUserToDeleteRows = false;
            this.tablaDeResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tablaDeResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeResultados.Location = new System.Drawing.Point(25, 142);
            this.tablaDeResultados.Name = "tablaDeResultados";
            this.tablaDeResultados.ReadOnly = true;
            this.tablaDeResultados.Size = new System.Drawing.Size(709, 242);
            this.tablaDeResultados.TabIndex = 7;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(151, 75);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(120, 20);
            this.apellido.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(403, 75);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(120, 20);
            this.mail.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "DNI";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(277, 75);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(120, 20);
            this.dni.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mail";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(659, 403);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 19;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(578, 403);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 18;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(767, 438);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.tablaDeResultados);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Controls.SetChildIndex(this.tablaDeResultados, 0);
            this.Controls.SetChildIndex(this.limpiar, 0);
            this.Controls.SetChildIndex(this.buscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.apellido, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dni, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.mail, 0);
            this.Controls.SetChildIndex(this.modificar, 0);
            this.Controls.SetChildIndex(this.eliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button eliminar;
        protected System.Windows.Forms.Button modificar;
        protected System.Windows.Forms.DataGridView tablaDeResultados;
    }
}