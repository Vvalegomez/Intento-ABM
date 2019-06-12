using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM_de_Paises
{
    public partial class ABM : Form
    {
        BDPaisesEntities contexto;

        public ABM()
        {
            InitializeComponent();
        }

        //Para limpiar los textbox
        private void LimpiarTxt()
        {
            txtCiudades.Text = "";
            txtProvincias.Text = "";
            txtPaises.Text = "";
          //  txtDatos.Text = "";
        }
    
        //Para llenar el dgv
        private void LLenarDgv()
        {
            try
            {
                contexto = new BDPaisesEntities();

                var datos = from a in contexto.Tables
                            select new
                            {
                                Pais = a.Paises,
                                Ciudad = a.Ciudades,
                                Provincia = a.Provincias

                            };
                dgvMostrar.DataSource = datos.ToList();
                dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede realizar.");
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                contexto = new BDPaisesEntities();

                //Deberia crear una tabla nueva pais
                Table Pais = new Table()
                {
                    Paises = txtPaises.Text,
                    Ciudades = txtCiudades.Text,
                    Provincias = txtProvincias.Text
                   
                };
                //Se deberia agregar el objeto a la BD
                contexto.Tables.Add(Pais);
                contexto.SaveChanges();
                MessageBox.Show("Pais agregado.");
                LimpiarTxt();
                LLenarDgv();
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede realizar.");
            }

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPaises.Text != string.Empty)
                {
                    string clave = txtPaises.Text;
                    contexto = new BDPaisesEntities();

                    Table Buscar = (from a in contexto.Tables
                                    where a.Paises == clave
                                    select a).SingleOrDefault();

                    if (Buscar != null)
                    {
                        txtProvincias.Text = Buscar.Provincias;
                        txtCiudades.Text = Buscar.Ciudades;
                    }
                    else
                    {
                        LimpiarTxt();
                        MessageBox.Show("No se puede encontrar.");
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se puede realizar.");
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPaises.Text != string.Empty)
                {
                    string clave = txtPaises.Text;
                    contexto = new BDPaisesEntities();

                    Table eliminar = (from a in contexto.Tables
                                      where a.Paises == clave
                                      select a).SingleOrDefault();
                    if (eliminar != null)
                    {
                        contexto.Tables.Remove(eliminar);
                        contexto.SaveChanges();
                        MessageBox.Show("Eliminado correctamente.");
                        LLenarDgv();
                    }
                    else
                    {
                        MessageBox.Show("No se puede realizar.");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede realizar.");
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPaises.Text != string.Empty)
                {
                    string clave = txtPaises.Text;
                    contexto = new BDPaisesEntities();

                    Table Modificar = (from a in contexto.Tables
                                       where a.Paises == clave
                                       select a).SingleOrDefault();
                    if (Modificar != null)
                    {
                        Modificar.Provincias = txtProvincias.Text;
                        Modificar.Ciudades = txtCiudades.Text;
                        contexto.SaveChanges();
                        MessageBox.Show("Modificado.");
                        LimpiarTxt();
                        LLenarDgv();
                    }
                    else
                    {
                        MessageBox.Show("No se puede realizar.");
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se puede realizar.");
            }
        }
    }
} //Averiguar error que no deja poner mismo pais con diferentes ciudades y provincias.
