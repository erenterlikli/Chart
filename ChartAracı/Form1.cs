using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartAracı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Büyük şehirlerdeki kitap okuma yüzdeleri");
           
            this.chart1.Series["İstanbul"].Points.AddY(25);
            this.chart1.Series["Ankara"].Points.AddY(20);
            this.chart1.Series["İzmir"].Points.AddY(32);
            this.chart1.Series["Bursa"].Points.AddY(17);
            this.chart1.Series["Antalya"].Points.AddY(19);
            this.chart1.Series["Adana"].Points.AddY(15);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
