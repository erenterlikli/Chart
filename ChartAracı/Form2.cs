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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Sınav Sonuçları");
            this.chart1.Series["Matematik"].Points.AddXY("Ayşe Yıldız",40);
            this.chart1.Series["Matematik"].Points.AddXY("Ali Kaya", 70);
            this.chart1.Series["Matematik"].Points.AddXY("Mehmet Demir", 90);
            this.chart1.Series["Matematik"].Points.AddXY("Ahmet Yılmaz", 80);
            this.chart1.Series["Matematik"].Points.AddXY("Fatma Öztürk", 85);
            this.chart1.Series["Matematik"].Points.AddXY("Hasan Karaca", 65);

            this.chart1.Series["Fizik"].Points.AddXY("Ayşe Yıldız", 30);
            this.chart1.Series["Fizik"].Points.AddXY("Ali Kaya", 60);
            this.chart1.Series["Fizik"].Points.AddXY("Mehmet Demir", 75);
            this.chart1.Series["Fizik"].Points.AddXY("Ahmet Yılmaz", 65);
            this.chart1.Series["Fizik"].Points.AddXY("Fatma Öztürk", 70);
            this.chart1.Series["Fizik"].Points.AddXY("Hasan Karaca", 55);


            this.chart1.Series["Türkçe"].Points.AddXY("Ayşe Yıldız", 80);
            this.chart1.Series["Türkçe"].Points.AddXY("Ali Kaya", 90);
            this.chart1.Series["Türkçe"].Points.AddXY("Mehmet Demir", 85);
            this.chart1.Series["Türkçe"].Points.AddXY("Ahmet Yılmaz", 55);
            this.chart1.Series["Türkçe"].Points.AddXY("Fatma Öztürk", 70);
            this.chart1.Series["Türkçe"].Points.AddXY("Hasan Karaca", 65);

            this.chart1.Series["İngilizce"].Points.AddXY("Ayşe Yıldız", 50);
            this.chart1.Series["İngilizce"].Points.AddXY("Ali Kaya", 70);
            this.chart1.Series["İngilizce"].Points.AddXY("Mehmet Demir", 75);
            this.chart1.Series["İngilizce"].Points.AddXY("Ahmet Yılmaz", 65);
            this.chart1.Series["İngilizce"].Points.AddXY("Fatma Öztürk", 40);
            this.chart1.Series["İngilizce"].Points.AddXY("Hasan Karaca", 25);

            this.chart1.Series["Kimya"].Points.AddXY("Ayşe Yıldız", 50);
            this.chart1.Series["Kimya"].Points.AddXY("Ali Kaya", 75);
            this.chart1.Series["Kimya"].Points.AddXY("Mehmet Demir", 65);
            this.chart1.Series["Kimya"].Points.AddXY("Ahmet Yılmaz", 45);
            this.chart1.Series["Kimya"].Points.AddXY("Fatma Öztürk", 60);
            this.chart1.Series["Kimya"].Points.AddXY("Hasan Karaca", 55);
        }
    }
}
