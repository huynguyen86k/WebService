using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;
using WcfService.Models;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ServiceSP.WebServiceSoapClient sv = new ServiceSP.WebServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sv.AddSP("hihi");
                dataGridView1.DataSource = sv.GetSanPhamID(1);

        }
    }
}
