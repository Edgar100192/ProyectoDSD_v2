using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Web;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Messaging;
using System.Xml;
using System.Xml.Serialization;

namespace WCFAplicationsMedical
{
    public partial class ConsultarColegioMedicos : Form
    {
        public ConsultarColegioMedicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient Clima = new HttpClient();
            Clima.BaseAddress = new Uri("http://localhost:50386");
            HttpResponseMessage response2 = Clima.GetAsync("/Medicos.svc/Medicos/" + textBoxCM.Text).Result;
            ConsultarMedicos emp = response2.Content.ReadAsAsync<ConsultarMedicos>().Result;
            List<ConsultarMedicos> emplist = new List<ConsultarMedicos>();
            emplist.Add(emp);
            dataGridView1.DataSource = emplist;

            StringBuilder sb = new StringBuilder();
            sb.Append("                 El medico a buscar se encuentra inscrito");
            sb.Append("\n");
            sb.Append("                      en el Colegio Nacional de Medicos");
            sb.Append("\n");
            MessageBox.Show(sb.ToString(), "Mensaje");


        }
    }
}
