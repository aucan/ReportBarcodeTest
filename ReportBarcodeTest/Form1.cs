using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportBarcodeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dskagit.kagit' table. You can move, or remove it, as needed.
            this.kagitTableAdapter.Fill(this.dskagit.kagit);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ReportParameter Barkod = new ReportParameter("Barkod", textBox1.Text);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Barkod });
            this.reportViewer1.RefreshReport();
        }
    }
}
