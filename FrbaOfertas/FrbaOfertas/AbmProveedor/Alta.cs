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

namespace FrbaOfertas.AbmProveedor
{
    public partial class Alta : AltaYModificacion
    {
        public Alta()
        {
            InitializeComponent();
            habilitado.Visible = false;
            confirmar.Text = "Crear";
        }

        override protected void confirmar_Click(object sender, EventArgs e)
        {
            // TODO: [D] Validaciones
            // TODO: [D] chequeo que no haya 2 con misma razon social y cuit
            insertarLocalidadParaDireccion();
        }

        private void insertarLocalidadParaDireccion()
        {
            SqlCommand chequearLocalidad = 
                new SqlCommand(
                    string.Format(
                        "SELECT localidad_id,localidad_nombre FROM NO_LO_TESTEAMOS_NI_UN_POCO.Localidad WHERE localidad_nombre='{0}'", 
                        localidad.Text), Helper.dbOfertas);

            SqlDataReader dataReaderLocalidad = Helper.realizarConsultaSQL(chequearLocalidad);
            if (dataReaderLocalidad != null)
            {
                if (dataReaderLocalidad.HasRows) // Localidad ya existe
                {
                    dataReaderLocalidad.Read();
                    string idLocalidad = dataReaderLocalidad.GetValue(0).ToString();
                    dataReaderLocalidad.Close();
                    insertarDomicilioParaDireccion(idLocalidad);
                }
                else
                {
                    dataReaderLocalidad.Close();
                    SqlCommand insertarNuevaLocalidad = 
                        new SqlCommand(
                            string.Format(
                                "INSERT INTO NO_LO_TESTEAMOS_NI_UN_POCO.Localidad (localidad_nombre) VALUES ('{0}'); SELECT SCOPE_IDENTITY()", 
                                localidad.Text), Helper.dbOfertas);

                    SqlDataReader dataReader = Helper.realizarConsultaSQL(insertarNuevaLocalidad);
                    if (dataReader != null)
                    {
                        if (dataReader.Read())
                        {
                            string idLocalidad = dataReader.GetValue(0).ToString();
                            dataReader.Close();
                            insertarDomicilioParaDireccion(idLocalidad);
                        }
                        else
                        {
                            //MessageBox.Show("Error al guardar la localidad");
                            dataReader.Close();
                        }
                    }
                }
            }
        }

        private void insertarDomicilioParaDireccion(string idLocalidad)
        {
            SqlCommand chequearDomicilio = 
                new SqlCommand(
                    string.Format(
                        "SELECT domicilio_id, domicilio_calle, domicilio_numero_piso, domicilio_departamento " +
                            "FROM NO_LO_TESTEAMOS_NI_UN_POCO.Domicilio " +
                            "WHERE domicilio_calle='{0}' AND domicilio_numero_piso='{1}'AND domicilio_departamento='{2}'", 
                            calle.Text, piso.Text, depto.Text), Helper.dbOfertas);

            SqlDataReader dataReaderDomicilio = Helper.realizarConsultaSQL(chequearDomicilio);
            if (dataReaderDomicilio != null)
            {
                if (dataReaderDomicilio.HasRows) // Domicilio ya existe
                {
                    dataReaderDomicilio.Read();
                    string idDomicilio = dataReaderDomicilio.GetValue(0).ToString();
                    dataReaderDomicilio.Close();
                    insertarRubro(idDomicilio);
                }
                else
                {
                    dataReaderDomicilio.Close();
                    SqlCommand insertarNuevoDomicilio = 
                        new SqlCommand(
                            string.Format(
                                "INSERT INTO NO_LO_TESTEAMOS_NI_UN_POCO.Domicilio " +
                                "(domicilio_id_localidad,domicilio_calle,domicilio_numero_piso,domicilio_departamento,domicilio_codigo_postal) " +
                                "VALUES ('{0}','{1}','{2}','{3}','{4}'); SELECT SCOPE_IDENTITY()", 
                                idLocalidad, calle.Text, piso.Text, depto.Text, codigoPostal.Text), Helper.dbOfertas);

                    SqlDataReader dataReader = Helper.realizarConsultaSQL(insertarNuevoDomicilio);
                    if (dataReader != null)
                    {
                        if (dataReader.Read())
                        {
                            string idDomicilio = dataReader.GetValue(0).ToString();
                            dataReader.Close();
                            insertarDomicilioParaDireccion(idDomicilio);
                        }
                        else
                        {
                            //MessageBox.Show("Error al guardar el domicilio");
                            dataReader.Close();
                        }
                    }
                }
            }
        }

        private void insertarRubro(string idDomicilio)
        {
            SqlCommand chequearRubro = 
                new SqlCommand(
                    string.Format("SELECT rubro_id FROM NO_LO_TESTEAMOS_NI_UN_POCO.Rubro WHERE rubro_descripcion='{0}'", 
                    rubro.Text), Helper.dbOfertas);

            SqlDataReader dataReaderRubro = Helper.realizarConsultaSQL(chequearRubro);
            if (dataReaderRubro != null)
            {
                if (dataReaderRubro.HasRows) // Rubro ya existe
                {
                    dataReaderRubro.Read();
                    string idRubro = dataReaderRubro.GetValue(0).ToString();
                    dataReaderRubro.Close();
                    insertarProveedor(idDomicilio, idRubro);
                }
                else
                {
                    dataReaderRubro.Close();
                    SqlCommand insertarNuevoRubro = 
                        new SqlCommand(
                            string.Format("INSERT INTO NO_LO_TESTEAMOS_NI_UN_POCO.Rubro (rubro_descripcion) VALUES ('{0}'); " +
                                            "SELECT SCOPE_IDENTITY()", rubro.Text), Helper.dbOfertas);

                    SqlDataReader dataReader = Helper.realizarConsultaSQL(insertarNuevoRubro);
                    if (dataReader != null)
                    {
                        if (dataReader.Read())
                        {
                            string idRubro = dataReader.GetValue(0).ToString();
                            dataReader.Close();
                            insertarProveedor(idDomicilio, idRubro);
                        }
                        else
                        {
                            //MessageBox.Show("Error al guardar el domicilio");
                            dataReader.Close();
                        }
                    }
                }
            }
        }

        private void insertarProveedor(string idDomicilio, string idRubro)
        {
            SqlCommand insertarNuevoUsuario =
                new SqlCommand(
                    string.Format("INSERT INTO NO_LO_TESTEAMOS_NI_UN_POCO.Usuario (usuario_username, usuario_password) " +
                    "VALUES ('{0}','{1}');",
                    CUIT.Text, Helper.encriptarConSHA256(CUIT.Text)), Helper.dbOfertas);

            SqlDataReader dataReaderUsuario = Helper.realizarConsultaSQL(insertarNuevoUsuario);
            if (dataReaderUsuario != null)
            {
                if (dataReaderUsuario.RecordsAffected == 0)
                {
                    dataReaderUsuario.Close();
                }
                else
                {
                    dataReaderUsuario.Close();
                    SqlCommand insertarRolProveedor =
                        new SqlCommand(
                            string.Format("INSERT INTO NO_LO_TESTEAMOS_NI_UN_POCO.RolesxUsuario (rolesxusuario_id_usuario, rolesxusuario_id_rol) VALUES('{0}',{1})",
                            CUIT.Text, "2"), Helper.dbOfertas);

                    SqlDataReader dataReaderRolProveedor = Helper.realizarConsultaSQL(insertarRolProveedor);
                    if (dataReaderRolProveedor != null)
                    {
                        if (dataReaderRolProveedor.RecordsAffected == 0)
                        {
                            dataReaderRolProveedor.Close();
                        }
                        else
                        {
                            dataReaderRolProveedor.Close();
                            SqlCommand insertarNuevoProveedor =
                                new SqlCommand(
                                    string.Format("INSERT INTO NO_LO_TESTEAMOS_NI_UN_POCO.Proveedor (proveedor_razon_social, proveedor_id_domicilio," +
                                    "proveedor_cuit, proveedor_telefono, proveedor_mail, proveedor_id_rubro, proveedor_nombre_contacto, proveedor_id_usuario) " +
                                    "VALUES ('{0}',{1},'{2}','{3}','{4}',{5},'{6}','{7}'); SELECT SCOPE_IDENTITY()",
                            razonSocial.Text, idDomicilio, CUIT.Text, telefono.Text, mail.Text, idRubro, nombre.Text, CUIT.Text), Helper.dbOfertas);
                            SqlDataReader dataReader = Helper.realizarConsultaSQL(insertarNuevoProveedor);
                            if (dataReader != null)
                            {
                                if (dataReader.RecordsAffected == 0)
                                {
                                    MessageBox.Show("Error al crear proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Proveedor REGISTRADO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
