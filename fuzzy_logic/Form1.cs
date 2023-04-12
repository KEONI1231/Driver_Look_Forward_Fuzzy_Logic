using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace fuzzy_logic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
            // Chart 생성
            Chart chart1 = new Chart();
            chart1.Width = 400;
            chart1.Height = 250;
            chart1.Left = 400;
            chart1.Top = 70;
            // ChartArea 생성
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "ChartArea";
            chartArea.AxisX.Title = "눈 감음 시간";
            chartArea.AxisY.Title = "가중치";

            // Series 생성
            Series series = new Series();
            series.Name = "Series";
            series.ChartArea = "ChartArea";

            // DataPoint 생성 및 Series에 추가
            series.Points.Add(new DataPoint(1, 2));
            series.Points.Add(new DataPoint(2, 4));
            series.Points.Add(new DataPoint(3, 6));
            series.Points.Add(new DataPoint(4, 8));
            //double yValue = series.Points.FirstOrDefault(p => p.XValue == 2)?.YValues[0];
            // ChartType 설정
            series.ChartType = SeriesChartType.Line;

            // Chart 컨트롤에 ChartArea와 Series 추가
            chart1.ChartAreas.Add(chartArea);
            chart1.Series.Add(series);

            // Form에 Chart 추가
            this.Controls.Add(chart1);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
