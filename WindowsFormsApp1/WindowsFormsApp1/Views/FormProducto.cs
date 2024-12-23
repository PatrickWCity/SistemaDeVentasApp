﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using System.Web.Script.Serialization;

namespace WindowsFormsApp1.Views
{
    public partial class FormProducto : Form
    {
        int cat;
        public FormProducto()
        {
            InitializeComponent();
            l_ZonaMensaje.Text = string.Empty;
            try { 
            Categoria();
            }
            catch
            {
                l_ZonaMensaje.Text = "Error de Conexión!";
            }
            Icon = Properties.Resources.Icon;
            B_Agregar.Enabled = true;
            B_Editar.Enabled = false;
            B_Eliminar.Enabled = false;
        }
        private async void B_Agregar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.TextLength == 0 && tb_PrecioUnitario.TextLength == 0 && tb_URLImagen.TextLength == 0)//cbcategoria and descripcion
            {
                l_ZonaMensaje.Text = "Debe ingresar los datos del Producto a Agregar";
            }
            else if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el nombre del Producto a Agregar";
            }
            else if (tb_PrecioUnitario.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el Precio Unitario del Producto a Agregar";
            }
            else if (tb_URLImagen.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar la URL de la Imagen del Producto a Agregar";
            }
            else if (!int.TryParse(tb_PrecioUnitario.Text, out int precio))
            {
                l_ZonaMensaje.Text = "Debe ingresar un valor Entero para el Precio Unitario del Producto a Agregar";
            }
            else
            {
                string urlParametros = "?";
                urlParametros += "nombre=" + tb_Nombre.Text;
                urlParametros += "&descripcion=" + tb_Descripcion.Text; 
                urlParametros += "&precioUnitario=" + tb_PrecioUnitario.Text;
                urlParametros += "&url_imagen=" + tb_URLImagen.Text;
                urlParametros += "&idCategoria=" + cb_IdCategoria.SelectedValue;
                //url lista
                try { 
                using (HttpClient cliente = new HttpClient())
                {
                    using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Producto/AddProducto" + urlParametros))
                    {
                        using (HttpContent contenido = response.Content)
                        {
                            string respuestaserver = await contenido.ReadAsStringAsync();
                            JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                            dynamic dynamic = jsserialiser.DeserializeObject(respuestaserver);

                            
                            foreach (var item in dynamic)
                            {
                                l_ZonaMensaje.Text = item.Value;
                            }
                            tb_Id.Text = string.Empty;
                            tb_Nombre.Text = string.Empty;
                            tb_Descripcion.Text = string.Empty;
                            tb_PrecioUnitario.Text = string.Empty;
                            tb_URLImagen.Text = string.Empty;
                            cb_IdCategoria.SelectedValue = 0;
                        }
                    }
                }//agregar
                using (HttpClient cliente = new HttpClient())
                {
                    using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Producto/GetAll"))
                    {
                        using (HttpContent contenido = response.Content)
                        {
                            string respuestaserver = await contenido.ReadAsStringAsync();
                            JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                            dynamic listaproductosdynamica = jsserialiser.DeserializeObject(respuestaserver);
                            List<Producto> listaproductos = new List<Producto>();
                            foreach (var item in listaproductosdynamica)
                            {
                                listaproductos.Add(new Producto
                                {
                                    idProducto = item["idProducto"],
                                    nombre = item["nombre"],
                                    descripcion = item["descripcion"],
                                    precioUnitario = item["precioUnitario"],
                                    url_imagen = item["url_imagen"],
                                    idCategoria = item["idCategoria"]
                                });
                            }
                            dataGridView1.DataSource = listaproductos;
                        }
                    }
                }//get all
                }
                catch
                {
                    l_ZonaMensaje.Text = "Error de Conexión!";
                }
            }
        }
        private async void B_Editar_Click(object sender, EventArgs e)
        {
            if (tb_Id.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_PrecioUnitario.TextLength == 0 && tb_URLImagen.TextLength == 0)//cbcategoria and descripcion
            {
                l_ZonaMensaje.Text = "Debe ingresar los datos del Producto a Agregar";
            }
            else if (tb_Id.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el ID del Producto a Eliminar";
            }
            else if (!int.TryParse(tb_Id.Text, out int id))
            {
                l_ZonaMensaje.Text = "Debe ingresar un valor Entero para el ID del Producto a Eliminar";
            }
            else if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el nombre del Producto a Agregar";
            }
            else if (tb_PrecioUnitario.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el Precio Unitario del Producto a Agregar";
            }
            else if (tb_URLImagen.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar la URL de la Imagen del Producto a Agregar";
            }
            else if (!int.TryParse(tb_PrecioUnitario.Text, out int precio))
            {
                l_ZonaMensaje.Text = "Debe ingresar un valor Entero para el Precio Unitario del Producto a Agregar";
            }
            else
            {
                string urlParametros = "?";
                urlParametros += "idProducto=" + tb_Id.Text;
                urlParametros += "&nombre=" + tb_Nombre.Text;
                urlParametros += "&descripcion=" + tb_Descripcion.Text;
                urlParametros += "&precioUnitario=" + tb_PrecioUnitario.Text;
                urlParametros += "&url_imagen=" + tb_URLImagen.Text;
                urlParametros += "&idCategoria=" + cb_IdCategoria.SelectedValue;
                //url lista
                try { 
                using (HttpClient cliente = new HttpClient())
                {
                    using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Producto/EditProducto" + urlParametros))
                    {
                        using (HttpContent contenido = response.Content)
                        {
                            string respuestaserver = await contenido.ReadAsStringAsync();
                            JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                            dynamic dynamic = jsserialiser.DeserializeObject(respuestaserver);


                            foreach (var item in dynamic)
                            {
                                l_ZonaMensaje.Text = item.Value;
                            }
                            tb_Id.Text = string.Empty;
                            tb_Nombre.Text = string.Empty;
                            tb_Descripcion.Text = string.Empty;
                            tb_PrecioUnitario.Text = string.Empty;
                            tb_URLImagen.Text = string.Empty;
                            cb_IdCategoria.SelectedValue = 0;
                        }
                    }
                }//agregar
                using (HttpClient cliente = new HttpClient())
                {
                    using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Producto/GetAll"))
                    {
                        using (HttpContent contenido = response.Content)
                        {
                            string respuestaserver = await contenido.ReadAsStringAsync();
                            JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                            dynamic listaproductosdynamica = jsserialiser.DeserializeObject(respuestaserver);
                            List<Producto> listaproductos = new List<Producto>();
                            foreach (var item in listaproductosdynamica)
                            {
                                listaproductos.Add(new Producto
                                {
                                    idProducto = item["idProducto"],
                                    nombre = item["nombre"],
                                    descripcion = item["descripcion"],
                                    precioUnitario = item["precioUnitario"],
                                    url_imagen = item["url_imagen"],
                                    idCategoria = item["idCategoria"]
                                });
                            }
                            dataGridView1.DataSource = listaproductos;
                        }
                    }
                }//get all
                }
                catch
                {
                    l_ZonaMensaje.Text = "Error de Conexión!";
                }
            }
        }
        private async void B_Eliminar_Click(object sender, EventArgs e)
        {
            if (tb_Id.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el ID del Producto a Eliminar";
            }
            else if (!int.TryParse(tb_Id.Text, out int id))
            {
                l_ZonaMensaje.Text = "Debe ingresar un valor Entero para el ID del Producto a Eliminar";
            }
            else
            {
                string urlParametros = "?";
                urlParametros += "idProducto=" + tb_Id.Text;
                //url lista
                try { 
                using (HttpClient cliente = new HttpClient())
                {
                    using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Producto/DeleteProducto" + urlParametros))
                    {
                        using (HttpContent contenido = response.Content)
                        {
                            string respuestaserver = await contenido.ReadAsStringAsync();
                            JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                            dynamic dynamic = jsserialiser.DeserializeObject(respuestaserver);


                            foreach (var item in dynamic)
                            {
                                l_ZonaMensaje.Text = item.Value;
                            }
                            tb_Id.Text = string.Empty;
                            tb_Nombre.Text = string.Empty;
                            tb_Descripcion.Text = string.Empty;
                            tb_PrecioUnitario.Text = string.Empty;
                            tb_URLImagen.Text = string.Empty;
                            cb_IdCategoria.SelectedValue = 0;
                        }
                    }
                }//agregar
                using (HttpClient cliente = new HttpClient())
                {
                    using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Producto/GetAll"))
                    {
                        using (HttpContent contenido = response.Content)
                        {
                            string respuestaserver = await contenido.ReadAsStringAsync();
                            JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                            dynamic listaproductosdynamica = jsserialiser.DeserializeObject(respuestaserver);
                            List<Producto> listaproductos = new List<Producto>();
                            foreach (var item in listaproductosdynamica)
                            {
                                listaproductos.Add(new Producto
                                {
                                    idProducto = item["idProducto"],
                                    nombre = item["nombre"],
                                    descripcion = item["descripcion"],
                                    precioUnitario = item["precioUnitario"],
                                    url_imagen = item["url_imagen"],
                                    idCategoria = item["idCategoria"]
                                });
                            }
                            dataGridView1.DataSource = listaproductos;
                        }
                    }
                }//get all
                }
                catch
                {
                    l_ZonaMensaje.Text = "Error de Conexión!";
                }
            }
        }
        private async void B_Mostrar_Click(object sender, EventArgs e)
        {
            try { 
            using (HttpClient cliente = new HttpClient())
            {
                using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Producto/GetAll"))
                {
                    using (HttpContent contenido = response.Content)
                    {
                        string respuestaserver = await contenido.ReadAsStringAsync();
                        JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                        dynamic listaproductosdynamica = jsserialiser.DeserializeObject(respuestaserver);
                        List<Producto> listaproductos = new List<Producto>();
                        foreach (var item in listaproductosdynamica)
                        {
                            listaproductos.Add(new Producto
                            {
                                idProducto = item["idProducto"],
                                nombre = item["nombre"],
                                descripcion = item["descripcion"],
                                precioUnitario = item["precioUnitario"],
                                url_imagen = item["url_imagen"],
                                idCategoria = item["idCategoria"]
                            });
                        }
                        dataGridView1.DataSource = listaproductos;
                    }
                }
            }
            l_ZonaMensaje.Text = string.Empty;
            }
            catch
            {
                l_ZonaMensaje.Text = "Error de Conexión!";
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                tb_Id.Text = row.Cells[0].Value.ToString();
                tb_Nombre.Text = row.Cells[1].Value.ToString();
                tb_Descripcion.Text = (string)row.Cells[2].Value;// para nulls
                tb_PrecioUnitario.Text = row.Cells[3].Value.ToString();
                tb_URLImagen.Text = row.Cells[4].Value.ToString();
                //cb_IdCategoria.Text = row.Cells[5].Value.ToString(); ver

                B_Agregar.Enabled = false;
                B_Editar.Enabled = true;
                B_Eliminar.Enabled = true;
            }
        }
        private async void Categoria()
        {
            using (HttpClient cliente = new HttpClient())
            {
                using (HttpResponseMessage response = await cliente.GetAsync("http://localhost:58327/Categoria/GetAll"))
                {
                    using (HttpContent contenido = response.Content)
                    {
                        string respuestaserver = await contenido.ReadAsStringAsync();
                        JavaScriptSerializer jsserialiser = new JavaScriptSerializer();
                        dynamic listaproductosdynamica = jsserialiser.DeserializeObject(respuestaserver);
                        List<Categoria> listaproductos = new List<Categoria>();
                        listaproductos.Add(new Categoria
                        {
                            idCategoria = 0,
                            nombre = "Selecionar Categoria"
                        });
                        foreach (var item in listaproductosdynamica)
                        {
                            listaproductos.Add(new Categoria
                            {
                                idCategoria = item["idCategoria"],
                                nombre = item["nombre"]
                            });
                        }
                        cb_IdCategoria.DataSource = listaproductos;
                        cb_IdCategoria.DisplayMember = "nombre";
                        cb_IdCategoria.ValueMember = "idCategoria";
                        cat = (int)cb_IdCategoria.SelectedValue;
                    }
                }
            }
        }

        private void B_Restablecer_Click(object sender, EventArgs e)
        {
            B_Agregar.Enabled = true;
            B_Editar.Enabled = false;
            B_Eliminar.Enabled = false;
            tb_Id.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            tb_Descripcion.Text = string.Empty;
            tb_PrecioUnitario.Text = string.Empty;
            tb_URLImagen.Text = string.Empty;
            cb_IdCategoria.SelectedValue = 0;
        }
    }
}