using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmCPFConsultar : Form
    {
        public FrmCPFConsultar()
        {
            InitializeComponent();
        }

        //Será implementado após o pagamento da api

        private string URL = "https://api.nfse.io/NaturalPeople/Basicinfo/taxNumber/";
        public async Task<RootObject> getRequest()
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(URL);
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await Client.GetAsync("51243055847/1999-08-26");
                if (response.IsSuccessStatusCode)
                {
                    string resposta = await response.Content.ReadAsStringAsync();

                    RootObject obj = JsonConvert.DeserializeObject<RootObject>(resposta);

                    MessageBox.Show(resposta);
                    return obj;
                }
                else
                {
                    RootObject pessoa = new RootObject();
                    return pessoa;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            _ = getRequest();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
