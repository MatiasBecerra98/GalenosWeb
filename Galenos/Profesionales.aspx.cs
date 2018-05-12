using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{

    public partial class Medico
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string foto { get; set; }

    }
    public partial class Profesionales : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            string apiUrl = "http://apigalenos.herokuapp.com/medicos";
            object input = new
            {
                //Name = txtName.Text.Trim(),
            };
            string inputJson = (new JavaScriptSerializer()).Serialize(input);
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            StreamReader json1 = new StreamReader(client.OpenRead(apiUrl));
            string json = json1.ReadToEnd();

            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            //var nombre = jsonObj[0]["nombre"].ToString();
            var nombres = new ArrayList();
            foreach (var item in jsonObj)
            {
                Medico medico = new Medico();
                medico.nombre = item["nombre"];
                medico.id = item["id"];
                medico.foto = "https://image.ibb.co/fZW1Jn/seba.jpg";
                nombres.Add(medico);
            }
            gvProfesionales.DataSource = nombres;
            gvProfesionales.DataBind();
        }
    }
}