﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas
{
    public partial class RegistrarUsuario : Utils
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
            conectarseABaseDeDatosOfertas();
        }

        bool usuarioOk = false;
        // TODO: {M} VALIDAR UNIQUE USERNAME
        // TODO: {M} LISTA ROLES - VER ACTUALIZACION DE ROLES CON DIEGO
        private void crearUsuario()
        {
            if (this.camposObligatorios())
            {
                if (this.usuarioUnico()) // Username unico
                {
                    desactivarErrores();

                    SqlCommand insertarNuevoUsuario = new SqlCommand(string.Format("INSERT INTO usuario (usuario_username, usuario_password) VALUES ('{0}','{1}'); SELECT SCOPE_IDENTITY()", username.Text, this.SHA256Encrypt(password.Text)), dbOfertas);
                    SqlDataReader dataReader = insertarNuevoUsuario.ExecuteReader();
                    dataReader.Close();
                }
                else
                {
                    desactivarErrores();
                    errorUsername.SetError(username, "Username ya existe");
                    this.Show();
                }
            }
            
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            crearUsuario();
            if (usuarioOk)
            {
                AddFormInPanel(new AbmCliente.Alta());
                buttonProveedor.Enabled = false;
            }

        }

        private void buttonProveedor_Click(object sender, EventArgs e)
        {
            crearUsuario();
            if (usuarioOk)
            {
                AddFormInPanel(new AbmProveedor.Alta());
                buttonCliente.Enabled = false;
            }
        }

        private void AddFormInPanel(object formHijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            if (fh.Size.Height > Size.Height || fh.Size.Width > Size.Width)
            {
                this.Size = new Size(fh.Width + buttonCliente.Size.Width, fh.Height + buttonCliente.Size.Height);
            }
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private bool camposObligatorios()
        {
            bool camposOk = true;
            if (username.Text == string.Empty)
            {
                errorUsername.SetError(username, "Campo Obligatorio");
                camposOk = false;
            }
            if (password.Text == string.Empty)
            {
                errorPassword.SetError(password, "Campo Obligatorio");
                camposOk = false;
            }
            //if (rol.Text == string.Empty)
            //{
            //    errorRol.SetError(rol, "Campo Obligatorio");
            //    camposOk = false;
            //}
            return camposOk;
        }

        private void desactivarErrores()
        {
            errorUsername.Clear();
            errorPassword.Clear();
            //errorRol.Clear();
        }

        private bool usuarioUnico()
        {
            SqlCommand chequearExistenciaUsername = new SqlCommand(string.Format("SELECT usuario_username FROM usuario WHERE usuario_username='{0}'", username.Text), dbOfertas);
            SqlDataReader dataReaderUsuario = chequearExistenciaUsername.ExecuteReader();
            usuarioOk = !dataReaderUsuario.HasRows;
            dataReaderUsuario.Close();
            return usuarioOk;
        }

    }
}
