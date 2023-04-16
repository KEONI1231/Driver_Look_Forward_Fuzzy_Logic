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


namespace fuzzy_logic
{
    public partial class Form1 : Form
    {
       
        ChartArea eyeClosedChartArea = new ChartArea();
        ChartArea headDownChartArea = new ChartArea();
        
        ChartArea deFuzzyChartAreaResultArea = new ChartArea();

        System.Windows.Forms.DataVisualization.Charting.Legend legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      
        System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();

        System.Windows.Forms.DataVisualization.Charting.Chart eyeClosedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        Series eyeClosedSeries = new Series();
        Series eyeClosedSeries1 = new Series();
        Series eyeClosedSeries2 = new Series();
        Series eyeClosedSeries3 = new Series();

        System.Windows.Forms.DataVisualization.Charting.Chart headDownChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        Series headDownSeries = new Series();
        Series headDownSeries1 = new Series();
        Series headDownSeries2= new Series();
        Series headDownSeries3 = new Series();

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
        double result3;
        double result4;

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
            // 범례 아이템의 모양을 원형으로 설정


            // Chart 생성

            headDownChart.Width = 400;
            headDownChart.Height = 250;
            headDownChart.Left = 1100;
            headDownChart.Top = 70;

            eyeClosedChart.Width = 400;
            eyeClosedChart.Height = 250;
            eyeClosedChart.Left = 400;
            eyeClosedChart.Top = 70;

            deFuzzyChart.Width = 400;
            deFuzzyChart.Height = 250;
            deFuzzyChart.Left = 400;
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
            headDownChartArea.AxisX.MajorGrid.Enabled = false;
            headDownChartArea.AxisY.MajorGrid.Enabled = false;
            headDownChartArea.Name = "ChartArea";
            headDownChartArea.AxisX.Title = "눈 감음 시간";
            headDownChartArea.AxisY.Title = "가중치";
            headDownChartArea.AxisX.Minimum = 0;
            headDownChartArea.AxisX.Maximum = 40;
            headDownChartArea.AxisX.Interval = 10;

            eyeClosedChartArea.AxisX.MajorGrid.Enabled = false;
            eyeClosedChartArea.AxisY.MajorGrid.Enabled = false;
            eyeClosedChartArea.Name = "ChartArea";
            eyeClosedChartArea.AxisX.Title = "눈 감음 시간";
            eyeClosedChartArea.AxisY.Title = "가중치";
            eyeClosedChartArea.AxisX.Minimum = 0;
            eyeClosedChartArea.AxisX.Maximum = 1000;
            eyeClosedChartArea.AxisX.Interval = 200;
            // Series 생성
            eyeClosedSeries.Name = "Series";
            eyeClosedSeries.ChartArea = "ChartArea";


            // DataPoint 생성 및 Series에 추가
            for (int x = 0; x <= 1000; x++)
            {
                double y;
                if (x <= 200)
                {
                    y = 1;
                }
                else if (x > 200 && x < 400)
                {
                    y = (400 - x) / 200.0;
                }
                else
                {
                    y = 0;
                }
                eyeClosedSeries.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (int x = 0; x <= 1000; x++)
            {
                double y;
                if (x <= 200)
                {
                    y = 0;
                }
                else if (x > 200 && x <= 400)
                {
                    y = (x - 400) / 200.0 + 1;
                }
                else if (x > 400 && x <= 600)
                {
                    y = (600 - x) / 200.0;
                }
                else
                {
                    y = 0;
                }
                eyeClosedSeries1.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (int x = 0; x <= 1000; x++)
            {
                double y;
                if (x <= 400)
                {
                    y = 0;
                }
                else if (x > 400 && x <= 600)
                {
                    y = (x - 600) / 200.0 + 1;
                }
                else if (x > 600 && x <= 800)
                {
                    y = (800 - x) / 200.0;
                }
                else
                {
                    y = 0;
                }
                eyeClosedSeries2.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (int x = 0; x <= 1000; x++)
            {
                double y;
                if (x <= 600)
                {
                    y = 0;
                }
                else if (x > 600 && x <= 800)
                {
                    y = (x - 800) / 200.0 + 1;
                }

                else
                {
                    y = 1;
                }
                eyeClosedSeries3.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }

            for (double x = 0; x <= 40; x++)
            {
                double y;
                if (x <= 10)
                {
                    y = 1;
                }
                else if (x > 10 && x <= 20)
                {
                    y = (20 - x) / 10;
                }
                else
                {
                    y = 0;
                }
                headDownSeries.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 40; x++)
            {
                double y;
                if (x <= 10)
                {
                    y = 0;
                }
                else if (x > 10 && x < 20)
                {
                    y = (x - 10) / 10;
                }
                else if (x >= 20 && x <= 30)
                {
                    y = (20 - x) / 10 + 1;
                }
                else
                {
                    y = 0;
                }
                headDownSeries1.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
            }
            for (double x = 0; x <= 40; x++)
            {
                double y;
                if (x <= 20)
                {
                    y = 0;
                }
                else if (x > 20 && x < 30)
                {
                    y = (x - 20) / 10;
                }
                else if (x >= 20 && x <= 30)
                {
                    y = (30 - x) / 10 + 1;
                }
                else
                {
                    y = 1;
                }
                headDownSeries2.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(x, y));
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
            eyeClosedSeries.ChartType = SeriesChartType.Line;
            eyeClosedSeries.BorderColor = Color.Blue;
            eyeClosedSeries.BorderWidth = 2;

            eyeClosedSeries1.ChartType = SeriesChartType.Line;
            eyeClosedSeries1.BorderColor = Color.Orange;
            eyeClosedSeries1.BorderWidth = 2;

            eyeClosedSeries2.ChartType = SeriesChartType.Line;
            eyeClosedSeries2.BorderColor = Color.Green;
            eyeClosedSeries2.BorderWidth = 2;

            eyeClosedSeries3.ChartType = SeriesChartType.Line;
            eyeClosedSeries3.BorderColor = Color.Red;
            eyeClosedSeries3.BorderWidth = 2;



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

            headDownSeries.ChartType = SeriesChartType.Line;
            headDownSeries.BorderColor = Color.Blue;
            headDownSeries.BorderWidth = 2;

            headDownSeries1.ChartType = SeriesChartType.Line;
            headDownSeries1.BorderColor = Color.Orange;
            headDownSeries1.BorderWidth = 2;

            headDownSeries2.ChartType = SeriesChartType.Line;
            headDownSeries2.BorderColor = Color.Green;
            headDownSeries2.BorderWidth = 2;

      

            // Chart 컨트롤에 ChartArea와 Series 추가
            eyeClosedChart.ChartAreas.Add(eyeClosedChartArea);
            eyeClosedChart.Series.Add(eyeClosedSeries);
            //chart1.ChartAreas.Add(chartArea);
            eyeClosedChart.Series.Add(eyeClosedSeries1);
            //chart1.ChartAreas.Add(chartArea);
            eyeClosedChart.Series.Add(eyeClosedSeries2);
            //chart1.ChartAreas.Add(chartArea);
            eyeClosedChart.Series.Add(eyeClosedSeries3);

            

            deFuzzyResultChart.ChartAreas.Add(deFuzzyChartAreaResultArea);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries1);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries2);
            deFuzzyResultChart.Series.Add(deFuzzyResultSeries3);

            headDownChart.ChartAreas.Add(headDownChartArea);
            headDownChart.Series.Add(headDownSeries);
            headDownChart.Series.Add(headDownSeries1);
            headDownChart.Series.Add(headDownSeries2);
            //chart1.ChartAreas.Add(chartArea);



            // Form에 Chart 추가
            this.Controls.Add(eyeClosedChart);
            this.Controls.Add(headDownChart);
         

            eyeClosedSeries.LegendText = "매우 낮음";
            eyeClosedSeries1.LegendText = "낮음";
            eyeClosedSeries2.LegendText = "높음";
            eyeClosedSeries3.LegendText = "매우 높음";
            eyeClosedChart.Legends.Add(legend);

          

            headDownSeries.LegendText = "거의 안함";
            headDownSeries1.LegendText = "가끔";
            headDownSeries2.LegendText = "자주";
            headDownChart.Legends.Add(legend1);

            label12.Text = "1) if 눈 감음 지속 시간 is 매우 낮음 \n2) and고개 떨꿈 횟수 is 거의 안함 \n3) than 수면정도 is 완전낮음";
            label16.Text = "1) if 눈 감음 지속 시간 is 낮음 \n2) and고개 떨꿈 횟수 is 가끔 \n3) than 수면정도 is 의심";
            label17.Text = "1) if 눈 감음 지속 시간 is 높음 \n2) and 고개 떨꿈 횟수 is not 거의 안함 \n3) than 수면정도 is 약간 확실";
            label18.Text = "1) if 눈 감음 지속 시간 is 매우 높음 \n2) than 수면정도 is 확실";


            /*this.openGLControl1 = new SharpGL.OpenGLControl();
            this.openGLControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl1.Name = "openGLControl";

            // 이벤트 핸들러 연결
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);

            // 폼에 OpenGLControl 추가
            this.Controls.Add(this.openGLControl1);*//*
            //System.Windows.Media.Media3D.


            // HelixViewport3D 컨트롤 생성
            HelixViewport3D viewport = new HelixViewport3D();

            // 카메라 위치 설정
            viewport.Camera.Position = new System.Windows.Media.Media3D.Point3D(10, 10, 10);
            viewport.Camera.LookDirection = new Vector3D(-10, -10, -10);

            // 그리드 생성
            GridLinesVisual3D grid = new GridLinesVisual3D()
            {
                Center = new System.Windows.Media.Media3D.Point3D(0, 0, 0),
                MajorDistance = 10,
                MinorDistance = 1,
                Thickness = 0.05,
                //Color = System.Windows.Media.Colors.Gray
            };

            // 그리드를 뷰포트에 추가
            viewport.Children.Add(grid);

            // 3D 그래프 생성
            int n = 50;
            double step = 0.2;
            System.Windows.Media.Media3D.Point3D[,] points = new System.Windows.Media.Media3D.Point3D[n, n];
            MeshBuilder meshBuilder = new MeshBuilder();
           *//* for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double x = i * step - (n / 2.0) * step;
                    double y = j * step - (n / 2.0) * step;
                    double z = x * x + y * y;
                    Color color = Color.Red; // 빨간색으로 변
                    points[i, j] = new System.Windows.Media.Media3D.Point3D(x, y, z);
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    System.Windows.Media.Media3D.Point3D p0 = points[i, j];
                    System.Windows.Media.Media3D.Point3D p1 = points[i + 1, j];
                    System.Windows.Media.Media3D.Point3D p2 = points[i + 1, j + 1];
                    System.Windows.Media.Media3D.Point3D p3 = points[i, j + 1];
                    meshBuilder.AddTriangle(p0, p1, p2);
                    meshBuilder.AddTriangle(p0, p2, p3);
                }
            }*//*

            for(int x = 0; x < 1000; x++)
            {
                
                 
                    
            }

            GeometryModel3D model = new GeometryModel3D(meshBuilder.ToMesh(), Materials.Blue);
            ModelVisual3D visual = new ModelVisual3D();
            visual.Content = model;
            viewport.Children.Add(visual);

            // ElementHost에 뷰포트 추가
            elementHost1.Child = viewport;



*/



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
            

            eyeClosedChartPoint = eyeClosedSeries.Points.FirstOrDefault(p => p.XValue == eyeClosedInput);
            eyeClosedChartPoint1 = eyeClosedSeries1.Points.FirstOrDefault(p => p.XValue == eyeClosedInput);
            eyeClosedChartPoint2 = eyeClosedSeries2.Points.FirstOrDefault(p => p.XValue == eyeClosedInput);
            eyeClosedChartPoint3 = eyeClosedSeries3.Points.FirstOrDefault(p => p.XValue == eyeClosedInput);

            headDownChartPoint = headDownSeries.Points.FirstOrDefault(p => p.XValue == headDownXinput);
            headDownChartPoint1 = headDownSeries1.Points.FirstOrDefault(p => p.XValue == headDownXinput);
            headDownChartPoint2 = headDownSeries2.Points.FirstOrDefault(p => p.XValue == headDownXinput);

            

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

            result1=(double)eyeClosedYvalue <= headDownYvalue ? eyeClosedYvalue : headDownYvalue;
            result2 = (double)eyeClosedYvalue1 >= headDownYvalue1 ? eyeClosedYvalue1 : headDownYvalue1;
            result3 = (double)(eyeClosedYvalue2 <=  ((1 - headDownYvalue)) ? eyeClosedYvalue2 : ( 1 - headDownYvalue));
            result4 = eyeClosedYvalue3;
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
    }
}
