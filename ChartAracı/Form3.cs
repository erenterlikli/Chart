using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //series için.

namespace ChartAracı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Mühendislik kontenjanları");

            string[] bolumler = { "Bilgisayar", "Makina", "İnşaat", "Elektrik-Elektronik", "Endüstri","Mekatronik"};
            int[] kontenjanlar = { 40, 50, 50, 40, 30, 25 };

            for(int i=0;i<bolumler.Length;i++)
            {
                Series sutunlar = this.chart1.Series.Add(bolumler[i]);
                sutunlar.Points.Add(kontenjanlar[i]);
            }
        }
    }
}
