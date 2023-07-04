using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using ZapateriaPresentacion.Models.Request;

namespace ZapateriaPresentacion
{
    public partial class frmZapateria : Form
    {
        public frmZapateria()
        {
            InitializeComponent();
        }

        private void frmZapateria_Load(object sender, EventArgs e)
        {

        }

        public string Enviar<T>(string url, T objetoRequest, string metodo = "POST")
        {
            string resultado = "";
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objetoRequest);
                WebRequest request = WebRequest.Create(url);
                request.Method = metodo;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8";
                request.Timeout = 10000;
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    resultado = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44388/api/Tiendas";
            Tienda oTienda = new Tienda();
            oTienda.Name = textNombre.Text;
            oTienda.Address = textDireccion.Text;
            string resultado = Enviar<Tienda>(url, oTienda, "POST");
        }

        private async void buttonListar_Click(object sender, EventArgs e)
        {
            string respuesta = await ListarTiendashttp();
            List<Tienda> lista = JsonConvert.DeserializeObject<List<Tienda>>(respuesta);
            dataGridView2.DataSource = lista;
        }

        private async Task<string> ListarTiendashttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44388/api/Tiendas");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44388/api/Articulos";
            Articulos oArticulo = new Articulos();
            oArticulo.Name = textNombreArt.Text;
            oArticulo.Description = txtDescripcion.Text;
            oArticulo.price = decimal.Parse(txtPrecio.Text);
            oArticulo.total_in_shelf = int.Parse(txtTotalestante.Text);
            oArticulo.total_in_vault = int.Parse(txtTotalBodega.Text);
            oArticulo.store_id = int.Parse(txtNumeroTienda.Text);
            string resultado = Enviar<Articulos>(url, oArticulo, "POST");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string respuesta = await ListarArticuloshttp();
            List<Articulos> lista = JsonConvert.DeserializeObject<List<Articulos>>(respuesta);
            dataGridView3.DataSource = lista;
        }

        private async Task<string> ListarArticuloshttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44388/api/Articulos");
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtNumTienda.Text.Length <= 0)
            {
                MessageBox.Show("Seleccione un numero de tienda");
            }
            else 
            {
                string respuesta = await ListarArticulosXTiendahttp(txtNumTienda.Text);
                List<Articulos> lista = JsonConvert.DeserializeObject<List<Articulos>>(respuesta);
                dataGridView3.DataSource = lista;
            }
        }

        private async Task<string> ListarArticulosXTiendahttp(string id)
        {
            WebRequest request = WebRequest.Create("https://localhost:44388/api/Articulos?stored_Id=" + id);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
    }   
}
