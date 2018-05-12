using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /*static async void Get()
        {
            string uri = "http://apigalenos.herokuapp.com/users/?id=2";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(uri);

            HttpContent content = response.Content;

            // ... Read the string.
            string result = await content.ReadAsStringAsync();
            //Console.WriteLine(result + "\n");

            //var json = JArray.Parse(result);
            dynamic jsonObj = JsonConvert.DeserializeObject(result);
            //var nombre = jsonObj[0]["nombre"].ToString();
            foreach (var item in jsonObj)
            {
               lblProbando.Text(item['username']);
            }

        }*/
    }
}