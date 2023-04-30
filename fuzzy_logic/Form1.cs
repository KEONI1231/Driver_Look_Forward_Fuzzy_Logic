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

using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;

using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using System.Windows.Forms.Integration;

//test\
//아니 왜 이거 안되는 거지
namespace fuzzy_logic
{
    public partial class Form1 : Form
    {
       
        ChartArea turnHeadDurationChartArea = new ChartArea();
        ChartArea turnHeadCountChartArea = new ChartArea();
        ChartArea ConfidenceIntervalChartArea = new ChartArea();



        ChartArea deFuzzyChartAreaResultArea = new ChartArea();

        System.Windows.Forms.DataVisualization.Charting.Legend legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      
        System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();

        System.Windows.Forms.DataVisualization.Charting.Legend intervalChartLegend = new System.Windows.Forms.DataVisualization.Charting.Legend();

        System.Windows.Forms.DataVisualization.Charting.Chart turnHeadDurationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        Series turnHeadDuration = new Series();
        Series turnHeadDuration1 = new Series();
        Series turnHeadDuration2 = new Series();
        

        System.Windows.Forms.DataVisualization.Charting.Chart turnHeadCountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        Series turnHeadCount = new Series();
        Series turnHeadCount1 = new Series();
        Series turnHeadCount2= new Series();
        Series turnHeadCount3 = new Series();
        Series turnHeadCount4 = new Series();

        System.Windows.Forms.DataVisualization.Charting.Chart confidenceIntervalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        Series IntervalOutDuration = new Series();
        Series IntervalOutDuration1 = new Series();
        Series IntervalOutDuration2 = new Series();
        Series IntervalOutDuration3 = new Series();
        Series IntervalOutDuration4 = new Series();


        System.Windows.Forms.DataVisualization.Charting.Chart deFuzzyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        Series deFuzzySeries = new Series();
        Series deFuzzySeries1 = new Series();
        Series deFuzzySeries2 = new Series();
        Series deFuzzySeries3 = new Series();
        
        System.Windows.Forms.DataVisualization.Charting.Chart deFuzzyResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        Series deFuzzyResultSeries = new Series();
        Series deFuzzyResultSeries1 = new Series();
        Series deFuzzyResultSeries2 = new Series();
        Series deFuzzyResultSeries3 = new Series();

        System.Windows.Forms.DataVisualization.Charting.DataPoint eyeClosedChartPoint;
        System.Windows.Forms.DataVisualization.Charting.DataPoint eyeClosedChartPoint1;
        System.Windows.Forms.DataVisualization.Charting.DataPoint eyeClosedChartPoint2;
        System.Windows.Forms.DataVisualization.Charting.DataPoint eyeClosedChartPoint3;

        System.Windows.Forms.DataVisualization.Charting.DataPoint defuzzyChartPoint;
        System.Windows.Forms.DataVisualization.Charting.DataPoint defuzzyChartPoint1;
        System.Windows.Forms.DataVisualization.Charting.DataPoint defuzzyChartPoint2;
        System.Windows.Forms.DataVisualization.Charting.DataPoint defuzzyChartPoint3;


        System.Windows.Forms.DataVisualization.Charting.DataPoint headDownChartPoint;
        System.Windows.Forms.DataVisualization.Charting.DataPoint headDownChartPoint1;
        System.Windows.Forms.DataVisualization.Charting.DataPoint headDownChartPoint2;

        double eyeClosedYvalue;
        double eyeClosedYvalue1;
        double eyeClosedYvalue2;
        double eyeClosedYvalue3;


        double headDownYvalue;
        double headDownYvalue1;
        double headDownYvalue2;

        int eyeClosedInput;
        int headDownXinput;
        

        double result1;
        double result2;
        double result2_1;
        double result3;
        double result3_1;
        double result4;
        double result4_1;


        List<double> thirdX1 = new List<double>();
        List<double> thirdX2 = new List<double>();
        List<double> thirdX3 = new List<double>();
        List<double> thirdX4 = new List<double>();

        List<double> thirdResult1 = new List<double>();
        List<double> thirdResult2 = new List<double>();
        List<double> thirdResult3 = new List<double>();
        List<double> thirdResult4 = new List<double>();

        List<double> third1y = new List<double>();
        List<double> third2y = new List<double>();
        List<double> third3y = new List<double>();

        List<double> thirdz = new List<double>();
        public Form1()
        {

            InitializeComponent();
            // Legend 생성

            legend.Name = "Legend";
            legend.Title = "Legend Title";
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            legend.BackColor = Color.White;
            legend.Font = new Font("맑은 고딕", 9, FontStyle.Bold);

            legend1.Name = "Legend";
            legend1.Title = "Legend Title";
            legend1.Docking = Docking.Bottom;
            legend1.Alignment = StringAlignment.Center;
            legend1.BackColor = Color.White;
            legend1.Font = new Font("맑은 고딕", 9, FontStyle.Bold);



            legend3.Name = "Legend";
            legend3.Title = "Legend Title";
            legend3.Docking = Docking.Bottom;
            legend3.Alignment = StringAlignment.Center;
            legend3.BackColor = Color.White;
            legend3.Font = new Font("맑은 고딕", 9, FontStyle.Bold);

            intervalChartLegend.Name = "Legend";
            intervalChartLegend.Title = "Legend Title";
            intervalChartLegend.Docking = Docking.Bottom;
            intervalChartLegend.Alignment = StringAlignment.Center;
            intervalChartLegend.BackColor = Color.White;
            intervalChartLegend.Font = new Font("맑은 고딕", 9, FontStyle.Bold);
            // 범례 아이템의 모양을 원형으로 설정


            // Chart 생성

            turnHeadCountChart.Width = 300;
            turnHeadCountChart.Height = 250;
            turnHeadCountChart.Left = 800;
            turnHeadCountChart.Top = 70;

            turnHeadDurationChart.Width = 300;
            turnHeadDurationChart.Height = 250;
            turnHeadDurationChart.Left = 250;
            turnHeadDurationChart.Top = 70;


            confidenceIntervalChart.Width = 300;
            confidenceIntervalChart.Height = 250;
            confidenceIntervalChart.Left = 1400;
            confidenceIntervalChart.Top = 70;


            deFuzzyChart.Width = 300;
            deFuzzyChart.Height = 300;
            deFuzzyChart.Left = 300;
            deFuzzyChart.Top = 700;

            deFuzzyResultChart.Width = 400;
            deFuzzyResultChart.Height = 250;
            deFuzzyResultChart.Left = 1100;
            deFuzzyResultChart.Top = 700;

            deFuzzyChartAreaResultArea.AxisX.MajorGrid.Enabled = false;
            deFuzzyChartAreaResultArea.AxisY.MajorGrid.Enabled = false;
            deFuzzyChartAreaResultArea.Name = "ChartArea";
            deFuzzyChartAreaResultArea.AxisX.Title = "눈 감음 시간";
            deFuzzyChartAreaResultArea.AxisY.Title = "가중치";
            deFuzzyChartAreaResultArea.AxisX.Minimum = 0;
            deFuzzyChartAreaResultArea.AxisX.Maximum = 100;
            deFuzzyChartAreaResultArea.AxisX.Interval = 20;


            // ChartArea 생성
            turnHeadCountChartArea.AxisX.MajorGrid.Enabled = false;
            turnHeadCountChartArea.AxisY.MajorGrid.Enabled = false;
            turnHeadCountChartArea.Name = "ChartArea";
            turnHeadCountChartArea.AxisX.Title = "눈 감음 시간";
            turnHeadCountChartArea.AxisY.Title = "가중치";
            turnHeadCountChartArea.AxisX.Minimum = 0;
            turnHeadCountChartArea.AxisX.Maximum = 10;
            turnHeadCountChartArea.AxisX.Interval = 1;

            turnHeadDurationChartArea.AxisX.MajorGrid.Enabled = false;
            turnHeadDurationChartArea.AxisY.MajorGrid.Enabled = false;
            turnHeadDurationChartArea.Name = "ChartArea";
            turnHeadDurationChartArea.AxisX.Title = "눈 감음 시간";
            turnHeadDurationChartArea.AxisY.Title = "가중치";
            turnHeadDurationChartArea.AxisX.Minimum = 0;
            turnHeadDurationChartArea.AxisX.Maximum = 4;
            turnHeadDurationChartArea.AxisX.Interval = 1;

            ConfidenceIntervalChartArea.AxisX.MajorGrid.Enabled = false;
            ConfidenceIntervalChartArea.AxisY.MajorGrid.Enabled = false;
            ConfidenceIntervalChartArea.Name = "ChartArea";
            ConfidenceIntervalChartArea.AxisX.Title = "눈 감음 시간";
            ConfidenceIntervalChartArea.AxisY.Title = "가중치";
            ConfidenceIntervalChartArea.AxisX.Minimum = 0;
            ConfidenceIntervalChartArea.AxisX.Maximum = 10;
            ConfidenceIntervalChartArea.AxisX.Interval = 1;


            // Series 생성
            turnHeadDuration.Name = "Series";
            turnHeadDuration.ChartArea = "ChartArea";


            // DataPoint 생성 및 Series에 추가
            for (int x = 0; x <= 4; x++)
            {
                double y;
                if (x <= 1)
                {
                    y = 1;
                }
                else if (x > 1 && x < 2)
                {
                    y = (2 - x) / 1;
                }
                else
                {
                    y = 0;
                }
                turnHeadDuration.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (int x = 0; x <= 4; x++)
            {
                double y;
                if (x <= 1)
                {
                    y = 0;
                }
                else if (x > 1 && x <= 2)
                {
                    y = (x - 2) / 1 + 1;
                }
                else if (x > 2 && x <= 3)
                {
                    y = (3 - x) / 1;
                }
                else
                {
                    y = 0;
                }
                turnHeadDuration1.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (int x = 0; x <= 4; x++)
            {
                double y;
                if (x <= 2)
                {
                    y = 0;
                }
                else if (x > 2 && x <= 3)
                {
                    y = (x - 3) / 2 + 1;
                }
                else if (x > 3)
                {
                    y = 1;
                }
                else
                    y = 1;
                
                turnHeadDuration2.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
           

            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 1)
                {
                    y = 1;
                }
                else if (x > 1 && x <= 2)
                {
                    y = (2 - x) / 1;
                }
                else
                {
                    y = 0;
                }
                turnHeadCount.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;
                
                if (x >= 0 && x <= 2)
                {
                    y = x / 2;
                }
                else if (x >= 2.0 && x <= 4.0)
                {
                    y = (2 - x) / 2+ 1.0;
                }
                else
                {
                    y = 0;
                }
                turnHeadCount1.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 2)
                {
                    y = 0;
                }
                else if (x > 2 && x <= 4)
                {
                    y = (x - 2) / 2;
                }
                else if (x > 4 && x <= 6)
                {
                    y = (4 - x) /2 + 1;
                }
                else
                {
                    y = 0;
                }
                turnHeadCount2.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 4)
                {
                    y = 0;
                }
                else if (x > 4 && x <= 6)
                {
                    y = (x - 6) / 2 + 1;
                }
                else if (x > 6 && x <= 8)
                {
                    y = (6 - x) / 2 + 1;
                }
                else
                {
                    y = 0;
                }
                turnHeadCount3.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 6)
                {
                    y = 0;
                }
                else if (x > 6 && x <= 8)
                {
                    y = (x - 8) / 2 + 1;
                }
                
                else
                {
                    y = 1;
                }
                turnHeadCount3.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }


            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 1)
                {
                    y = 1;
                }
                else if (x > 1 && x <= 2)
                {
                    y = (2 - x) / 1;
                }
                else
                {
                    y = 0;
                }
                IntervalOutDuration.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;

                if (x >= 0 && x <= 2)
                {
                    y = x / 2;
                }
                else if (x >= 2.0 && x <= 4.0)
                {
                    y = (2 - x) / 2 + 1.0;
                }
                else
                {
                    y = 0;
                }
                IntervalOutDuration1.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 2)
                {
                    y = 0;
                }
                else if (x > 2 && x <= 4)
                {
                    y = (x - 2) / 2;
                }
                else if (x > 4 && x <= 6)
                {
                    y = (4 - x) / 2 + 1;
                }
                else
                {
                    y = 0;
                }
                IntervalOutDuration2.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 4)
                {
                    y = 0;
                }
                else if (x > 4 && x <= 6)
                {
                    y = (x - 6) / 2 + 1;
                }
                else if (x > 6 && x <= 8)
                {
                    y = (6 - x) / 2 + 1;
                }
                else
                {
                    y = 0;
                }
                IntervalOutDuration3.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 10; x++)
            {
                double y;
                if (x <= 6)
                {
                    y = 0;
                }
                else if (x > 6 && x <= 8)
                {
                    y = (x - 8) / 2 + 1;
                }

                else
                {
                    y = 1;
                }
                IntervalOutDuration4.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }




            deFuzzySeries.Points.Clear();
            deFuzzySeries1.Points.Clear();
            deFuzzySeries2.Points.Clear();
            deFuzzySeries3.Points.Clear();
            for (double x = 0; x <= 100; x++)
            {
                double y;
                
                if (x >= 0 && x < 20)
                {
                    y = (x / 20);
                 
                }
                else if (x >= 20 && x < 40)
                {
                    y = ((40 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                
          
                deFuzzySeries.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
                
            }
            for (double x = 0; x <= 100; x++)
            {
                double y;

                if (x >= 20 && x < 40)
                {
                    y = (x-20) / 20;

                }
                else if (x >= 40 && x < 60)
                {
                    y = ((60 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                deFuzzySeries1.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 100; x++)
            {
                double y;

                if (x >= 40 && x < 60)
                {
                    y = (x - 40) / 20;

                }
                else if (x >= 60 && x < 80)
                {
                    y = ((80 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                deFuzzySeries2.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 100; x++)
            {
                double y;

                if (x >= 60 && x < 80)
                {
                    y = (x - 60) / 20;

                }
                else if (x >= 80 && x < 100)
                {
                    y = ((100 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                deFuzzySeries3.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }

            //double yValue = series.Points.FirstOrDefault(p => p.XValue == 2)?.YValues[0];
            // ChartType 설정
            turnHeadDuration.ChartType = SeriesChartType.Line;
            turnHeadDuration.BorderColor = Color.Blue;
            turnHeadDuration.BorderWidth = 2;

            turnHeadDuration1.ChartType = SeriesChartType.Line;
            turnHeadDuration1.BorderColor = Color.Orange;
            turnHeadDuration1.BorderWidth = 2;

            turnHeadDuration2.ChartType = SeriesChartType.Line;
            turnHeadDuration2.BorderColor = Color.Green;
            turnHeadDuration2.BorderWidth = 2;

           


            deFuzzySeries.ChartType = SeriesChartType.Line;
            deFuzzySeries.BorderColor = Color.Blue;
            deFuzzySeries.BorderWidth = 2;

            deFuzzySeries1.ChartType = SeriesChartType.Line;
            deFuzzySeries1.BorderColor = Color.Orange;
            deFuzzySeries1.BorderWidth = 2;

            deFuzzySeries2.ChartType = SeriesChartType.Line;
            deFuzzySeries2.BorderColor = Color.Green;
            deFuzzySeries2.BorderWidth = 2;

            deFuzzySeries3.ChartType = SeriesChartType.Line;
            deFuzzySeries3.BorderColor = Color.Red;
            deFuzzySeries3.BorderWidth = 2;

            turnHeadCount.ChartType = SeriesChartType.Line;
            turnHeadCount.BorderColor = Color.Blue;
            turnHeadCount.BorderWidth = 2;

            turnHeadCount1.ChartType = SeriesChartType.Line;
            turnHeadCount1.BorderColor = Color.Orange;
            turnHeadCount1.BorderWidth = 2;

            turnHeadCount2.ChartType = SeriesChartType.Line;
            turnHeadCount2.BorderColor = Color.Green;
            turnHeadCount2.BorderWidth = 2;

            turnHeadCount3.ChartType = SeriesChartType.Line;
            turnHeadCount3.BorderColor = Color.Purple;
            turnHeadCount3.BorderWidth = 2;

            turnHeadCount4.ChartType = SeriesChartType.Line;
            turnHeadCount4.BorderColor = Color.Black;
            turnHeadCount4.BorderWidth = 2;


            // Chart 컨트롤에 ChartArea와 Series 추가
            turnHeadDurationChart.ChartAreas.Add(turnHeadDurationChartArea);
            turnHeadDurationChart.Series.Add(turnHeadDuration);
            //chart1.ChartAreas.Add(chartArea);
            turnHeadDurationChart.Series.Add(turnHeadDuration1);
            //chart1.ChartAreas.Add(chartArea);
            turnHeadDurationChart.Series.Add(turnHeadDuration2);
            //chart1.ChartAreas.Add(chartArea);

            confidenceIntervalChart.ChartAreas.Add(ConfidenceIntervalChartArea);
            confidenceIntervalChart.Series.Add(IntervalOutDuration);
            confidenceIntervalChart.Series.Add(IntervalOutDuration1);
            confidenceIntervalChart.Series.Add(IntervalOutDuration2);
            confidenceIntervalChart.Series.Add(IntervalOutDuration3);
            confidenceIntervalChart.Series.Add(IntervalOutDuration4);



            deFuzzyResultChart.ChartAreas.Add(deFuzzyChartAreaResultArea);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries1);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries2);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries3);

            turnHeadCountChart.ChartAreas.Add(turnHeadCountChartArea);
            turnHeadCountChart.Series.Add(turnHeadCount);
            turnHeadCountChart.Series.Add(turnHeadCount1);
            turnHeadCountChart.Series.Add(turnHeadCount2);

            turnHeadCountChart.Series.Add(turnHeadCount3);
            turnHeadCountChart.Series.Add(turnHeadCount4);
   
            //chart1.ChartAreas.Add(chartArea);



            // Form에 Chart 추가
            this.Controls.Add(turnHeadDurationChart);
            this.Controls.Add(turnHeadCountChart);
            this.Controls.Add(confidenceIntervalChart);

            turnHeadDuration.LegendText = "정상";
            turnHeadDuration1.LegendText = "주의";
            turnHeadDuration2.LegendText = "전방 미주시";
           
            turnHeadDurationChart.Legends.Add(legend);

          

            turnHeadCount.LegendText = "매우 낮음";
            turnHeadCount1.LegendText = "낮음";
            turnHeadCount2.LegendText = "중간";
            turnHeadCount3.LegendText = "높음";
            turnHeadCount4.LegendText = "매우 높음";
            
            turnHeadCountChart.Legends.Add(legend1);

            label12.Text = "1) if 눈 감음 지속 시간 is 매우 낮음 \n2) and고개 떨꿈 횟수 is 거의 안함 \n3) than 수면정도 is 완전낮음";
            label16.Text = "1) if 눈 감음 지속 시간 is 낮음 \n2) and고개 떨꿈 횟수 is 가끔 \n3) than 수면정도 is 의심";
            label17.Text = "1) if 눈 감음 지속 시간 is 높음 \n2) and 고개 떨꿈 횟수 is not 거의 안함 \n3) than 수면정도 is 약간 확실";
            label18.Text = "1) if 눈 감음 지속 시간 is 매우 높음 \n2) than 수면정도 is 확실";



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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            eyeClosedInput = Decimal.ToInt32(numericUpDown1.Value);
            progressBar1.Value = eyeClosedInput;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            headDownXinput = Decimal.ToInt32(numericUpDown2.Value);
           // richTextBox9.Text = headDownXinput.ToString();
            progressBar2.Value = (int)headDownXinput;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            eyeClosedChartPoint = turnHeadDuration.Points.FirstOrDefault(p => p.XValue == eyeClosedInput);
            eyeClosedChartPoint1 = turnHeadDuration1.Points.FirstOrDefault(p => p.XValue == eyeClosedInput);
            eyeClosedChartPoint2 = turnHeadDuration2.Points.FirstOrDefault(p => p.XValue == eyeClosedInput);
           

            headDownChartPoint = turnHeadCount.Points.FirstOrDefault(p => p.XValue == headDownXinput);
            headDownChartPoint1 = turnHeadCount1.Points.FirstOrDefault(p => p.XValue == headDownXinput);
            headDownChartPoint2 = turnHeadCount2.Points.FirstOrDefault(p => p.XValue == headDownXinput);

            

            eyeClosedYvalue = (double)eyeClosedChartPoint.YValues[0];
            eyeClosedYvalue1 = (double)eyeClosedChartPoint1.YValues[0];
            eyeClosedYvalue2 = (double)eyeClosedChartPoint2.YValues[0];
            eyeClosedYvalue3 = (double)eyeClosedChartPoint3.YValues[0];

            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            richTextBox3.ReadOnly = true;
            richTextBox4.ReadOnly = true;
            richTextBox1.Text = eyeClosedYvalue.ToString();
            richTextBox2.Text = eyeClosedYvalue1.ToString();
            richTextBox3.Text = eyeClosedYvalue2.ToString();
            richTextBox4.Text = eyeClosedYvalue3.ToString();

            //richTextBox9.Text = headDownSeries.Points.FirstOrDefault(p => p.XValue == headDownXinput).ToString();

            headDownYvalue = (double)headDownChartPoint.YValues[0];
            headDownYvalue1 = (double)headDownChartPoint1.YValues[0];
            headDownYvalue2 = (double)headDownChartPoint2.YValues[0];
            
            richTextBox6.ReadOnly = true;
            richTextBox7.ReadOnly = true;
            richTextBox8.ReadOnly = true;
            
            richTextBox8.Text = headDownYvalue.ToString();
            richTextBox7.Text = headDownYvalue1.ToString();
            richTextBox6.Text = headDownYvalue2.ToString();

            inference1.ReadOnly = true;
            inference2.ReadOnly = true;
            inference3.ReadOnly = true;
            inference4.ReadOnly = true;
            inference5.ReadOnly = true;
            inference6.ReadOnly = true;
            resultInference4.ReadOnly = true;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inference1.Text = eyeClosedYvalue.ToString();
            inference2.Text = headDownYvalue.ToString();

            inference3.Text = eyeClosedYvalue1.ToString();
            inference4.Text = headDownYvalue1.ToString();

            inference5.Text = eyeClosedYvalue2.ToString();
            inference6.Text = headDownYvalue.ToString();

            resultInference4.Text = headDownYvalue.ToString();



            //1.IF 눈 감음 지속시간이 "매우 낮음"이면서 고개 떨굼 횟수가 "거의 안함"이면, 수면 정도는 "완전 아님"일 가능성이 높습니다. (AND 연산자)
            //2.IF 눈 감음 지속시간이 "매우 낮음"이거나 고개 떨굼 횟수가 "거의 안함"이면, 수면 정도는 "완전 아님"일 가능성이 높습니다. (OR 연산자)
            //3.IF 눈 감음 지속시간이 "낮음"이면서 고개 떨굼 횟수가 "가끔"이면, 수면 정도는 "의심"일 가능성이 높습니다. (AND 연산자)
            //4.IF 눈 감음 지속시간이 "매우 높음"이거나 고개 떨굼 횟수가 "자주"이면, 수면 정도는 "확실"일 가능성이 높습니다. (OR 연산자)

            /*result1 = (double)eyeClosedYvalue <= headDownYvalue ? eyeClosedYvalue : headDownYvalue;
            result2 = (double)eyeClosedYvalue1 >= headDownYvalue1 ? eyeClosedYvalue1 : headDownYvalue1;
            result3 = (double)(eyeClosedYvalue2 <=  ((1 - headDownYvalue)) ? eyeClosedYvalue2 : ( 1 - headDownYvalue));
            result4 = eyeClosedYvalue3;*/
            result1 = (double)eyeClosedYvalue <= headDownYvalue ? eyeClosedYvalue : headDownYvalue ;
            
            //result1 = (double)eyeClosedYvalue3 >= headDownYvalue ? eyeClosedYvalue : headDownYvalue;

            result2 = (double)eyeClosedYvalue1 >= headDownYvalue1 ? eyeClosedYvalue1 : headDownYvalue1;
            
            result3 = (double)eyeClosedYvalue2 <= headDownYvalue2 ? eyeClosedYvalue2 : headDownYvalue2;

            result4 = (double)eyeClosedYvalue3 <= headDownYvalue2 ? eyeClosedYvalue3 : headDownYvalue2;
            
            /*if(eyeClosedInput > 600 && headDownXinput <=20 )
            {
                result1 = 
            }*/
            resultInference1.Text = result1.ToString();
            resultInference2.Text = result2.ToString();
            resultInference3.Text = result3.ToString();
            resultInference4.Text = result4.ToString();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            ChartArea deFuzzyChartArea = new ChartArea();
            deFuzzyChartArea.AxisX.MajorGrid.Enabled = false;
            deFuzzyChartArea.AxisY.MajorGrid.Enabled = false;
            deFuzzyChartArea.Name = "ChartArea";
            deFuzzyChartArea.AxisX.Title = "눈 감음 시간";
            deFuzzyChartArea.AxisY.Title = "가중치";
            deFuzzyChartArea.AxisX.Minimum = 0;
            deFuzzyChartArea.AxisX.Maximum = 100;
            deFuzzyChartArea.AxisX.Interval = 20;

            deFuzzyChart.ChartAreas.Clear();
            deFuzzyChart.Series.Clear();

            
            deFuzzyChart.ChartAreas.Add(deFuzzyChartArea);
            deFuzzyChart.Series.Add(deFuzzySeries);
            deFuzzyChart.Series.Add(deFuzzySeries1);
            deFuzzyChart.Series.Add(deFuzzySeries2);
            deFuzzyChart.Series.Add(deFuzzySeries3);

            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            legend2.Name = "Legend";
            legend2.Title = "Legend Title";
            legend2.Docking = Docking.Bottom;
            legend2.Alignment = StringAlignment.Center;
            legend2.BackColor = Color.White;
            legend2.Font = new Font("맑은 고딕", 9, FontStyle.Bold);

            this.Controls.Add(deFuzzyChart);
            deFuzzySeries.LegendText = "완전아님";
            deFuzzySeries1.LegendText = "의심";
            deFuzzySeries2.LegendText = "약간 확실";
            deFuzzySeries3.LegendText = "확실";
            deFuzzyChart.Legends.Clear();
            deFuzzyChart.Legends.Add(legend2);

            deFuzzyResultSeries.Points.Clear();
            deFuzzyResultSeries1.Points.Clear();
            deFuzzyResultSeries2.Points.Clear();
            deFuzzyResultSeries3.Points.Clear();
            for (double x = 0; x <= 100; x++)
            {
                double y;
                if (x >= 0 && x < 20)
                {
                    y = (x / 20);
                }
                else if (x >= 20 && x < 40)
                {
                    y = ((40 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                if( y >= result1)
                {
                    y = result1;
                }
                deFuzzyResultSeries.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 100; x++)
            {
                double y;
                if (x >= 20 && x < 40)
                {
                    y = (x - 20) / 20;
                }
                else if (x >= 40 && x < 60)
                {
                    y = ((60 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                if (y >= result2)
                {
                    y = result2;
                }
                deFuzzyResultSeries1.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 100; x++)
            {
                double y;
                if (x >= 40 && x < 60)
                {
                    y = (x - 40) / 20;
                }
                else if (x >= 60 && x < 80)
                {
                    y = ((80 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                if (y >= result3)
                {
                    y = result3;
                }
                deFuzzyResultSeries2.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 100; x++)
            {
                double y;
                if (x >= 60 && x < 80)
                {
                    y = (x - 60) / 20;
                }
                else if (x >= 80 && x < 100)
                {
                    y = ((100 - x) / 20);
                }
                else
                {
                    y = 0;
                }
                if (y >= result4)
                {
                    y = result4;
                }
                deFuzzyResultSeries3.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            deFuzzyResultSeries.ChartType = SeriesChartType.Line;
            deFuzzyResultSeries.BorderColor = Color.Blue;
            deFuzzyResultSeries.BorderWidth = 2;

            deFuzzyResultSeries1.ChartType = SeriesChartType.Line;
            deFuzzyResultSeries1.BorderColor = Color.Orange;
            deFuzzyResultSeries1.BorderWidth = 2;

            deFuzzyResultSeries2.ChartType = SeriesChartType.Line;
            deFuzzyResultSeries2.BorderColor = Color.Green;
            deFuzzyResultSeries2.BorderWidth = 2;

            deFuzzyResultSeries3.ChartType = SeriesChartType.Line;
            deFuzzyResultSeries3.BorderColor = Color.Red;
            deFuzzyResultSeries3.BorderWidth = 2;

            this.Controls.Add(deFuzzyResultChart);
            deFuzzyResultSeries.LegendText = "완전아님";
            deFuzzyResultSeries1.LegendText = "의심";
            deFuzzyResultSeries2.LegendText = "약간 확실";
            deFuzzyResultSeries3.LegendText = "확실";
            deFuzzyResultChart.Legends.Clear();
            deFuzzyResultChart.Legends.Add(legend3);

            double totalX = 0;
            double totalY = 0;
            double totalWeight = 0;

            // calculate weighted average for each series
            for (int i = 0; i < deFuzzyResultSeries.Points.Count-1; i++)
            {
                double x = deFuzzyResultSeries.Points[i].XValue;
                double y = deFuzzyResultSeries.Points[i].YValues[0];
                
                double weight = y * (i + 0.5); // use mid-point of interval as weight
                totalX += x * weight;
                totalY += y * weight;
                totalWeight += weight;
            }
            for (int i = 0; i < deFuzzyResultSeries1.Points.Count-1; i++)
            {
                double x = deFuzzyResultSeries1.Points[i].XValue;
                double y = deFuzzyResultSeries1.Points[i].YValues[0];
                double weight = y * (i + 0.5);
                totalX += x * weight;
                totalY += y * weight;
                totalWeight += weight;
            }
            for (int i = 0; i < deFuzzyResultSeries2.Points.Count-1; i++)
            {
                double x = deFuzzyResultSeries2.Points[i].XValue;
                double y = deFuzzyResultSeries2.Points[i].YValues[0];
                double weight = y * (i + 0.5);
                totalX += x * weight;
                totalY += y * weight;
                totalWeight += weight;
            }
            for (int i = 0; i < deFuzzyResultSeries3.Points.Count-1; i++)
            {
                double x = deFuzzyResultSeries3.Points[i].XValue;
                double y = deFuzzyResultSeries3.Points[i].YValues[0];
                double weight = y * (i + 0.5);
                totalX += x * weight;
                totalY += y * weight;
                totalWeight += weight;
            }

            // divide by total weight to get weighted average
            double centerX = totalX / totalWeight;
            double centerY = totalY / totalWeight;

            if(totalWeight == 0) {
                centerX = 0;
            }
            richTextBox5.Text = centerX.ToString();
        }
       

        private void elementHost1_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string output = "";
            for(int i = 0; i < 1001; ++i)
            {
                for(double j = 0; j < 5; j += 0.1f)
                {
                    numericUpDown1.Value = i;
                    numericUpDown2.Value = (decimal)j;
                    button1_Click(sender, e);
                    button2_Click(sender, e);
                    button3_Click(sender, e);
                    output += "" + i + " " + j + " " + richTextBox5.Text + "\n";
                }
            }
            System.IO.File.WriteAllText("fuzzy.txt", output, Encoding.Default);
           
           /* for (int i = 0; i < 1000; i++)
            {
                eyeClosedChartPoint = eyeClosedSeries.Points.FirstOrDefault(p => p.XValue == i);
                thirdX1.Add((double)eyeClosedChartPoint.YValues[0]);

                eyeClosedChartPoint1 = eyeClosedSeries1.Points.FirstOrDefault(p => p.XValue == i);
                thirdX2.Add((double)eyeClosedChartPoint1.YValues[0]);

                eyeClosedChartPoint2 = eyeClosedSeries2.Points.FirstOrDefault(p => p.XValue == i);
                thirdX3.Add((double)eyeClosedChartPoint2.YValues[0]);

                eyeClosedChartPoint3 = eyeClosedSeries3.Points.FirstOrDefault(p => p.XValue == i);
                thirdX4.Add((double)eyeClosedChartPoint3.YValues[0]);
            }

            for (int i = 0; i <= 4; i++)
            {
                headDownChartPoint = headDownSeries.Points.FirstOrDefault(p => p.XValue == i);
                third1y.Add((double)headDownChartPoint.YValues[0]);

                headDownChartPoint1 = headDownSeries1.Points.FirstOrDefault(p => p.XValue == i);
                third2y.Add((double)headDownChartPoint1.YValues[0]);

                headDownChartPoint2 = headDownSeries2.Points.FirstOrDefault(p => p.XValue == i);
                third3y.Add((double)headDownChartPoint2.YValues[0]);
            }
       
            for (int i = 0; i < 1000; i++)
            {
                for (int j =0; j < 5; j++)
                {

                    *//* result1 = (double)eyeClosedYvalue < headDownYvalue ? eyeClosedYvalue : headDownYvalue;
                     result2 = (double)eyeClosedYvalue1 < headDownYvalue1 ? eyeClosedYvalue1 : headDownYvalue1;
                     result3 = (double)(eyeClosedYvalue2 < ((1 - headDownYvalue)) ? eyeClosedYvalue2 : (1 - headDownYvalue));
                     result4 = eyeClosedYvalue3;*//*
                    
                    
                    
                    
                    thirdResult1.Add(((double)thirdX1[i] <= third1y[j]) ? thirdX1[i] : third1y[j]); //완전아님
                    thirdResult2.Add(((double)thirdX2[i] <= third2y[j]) ? thirdX2[i] : third2y[j]); // 의심
                    thirdResult3.Add((double)(thirdX3[i] <= ((1 - third1y[j])) ? thirdX3[i] : (1 - third1y[j]))); // 약간 확실
                    thirdResult4.Add((double)thirdX4[i]); // 확실


                    //richTextBox9.Text += "r1 : " + testx1.ToString() + ", r2 : " + testx2.ToString() + 
                   //    ", r3 : " + testx3.ToString() + ", r4 : " + testx4.ToString() + "\n";

                }

            }*/




        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
