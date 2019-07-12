using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFAplicationsMedical
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            WCFAplicationsMedical.CrearMedico medico1 = new CrearMedico();
            medico1.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            WCFAplicationsMedical.BandejaMensajes mensaje1 = new BandejaMensajes();
            mensaje1.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            WCFAplicationsMedical.ConsultarColegioMedicos CM1 = new ConsultarColegioMedicos();
            CM1.ShowDialog();
            Show();

        }
    }
}
