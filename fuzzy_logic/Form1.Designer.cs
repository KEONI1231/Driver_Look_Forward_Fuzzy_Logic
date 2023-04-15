namespace fuzzy_logic
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.inference1 = new System.Windows.Forms.RichTextBox();
            this.inference2 = new System.Windows.Forms.RichTextBox();
            this.inference4 = new System.Windows.Forms.RichTextBox();
            this.inference3 = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.inference6 = new System.Windows.Forms.RichTextBox();
            this.inference5 = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.resultInference4 = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.resultInference1 = new System.Windows.Forms.RichTextBox();
            this.resultInference2 = new System.Windows.Forms.RichTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.resultInference3 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 2);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(859, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fuzzification";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1902, 2);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(874, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Inference";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(848, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Defuzzification";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 149);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 21);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 120);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(46, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "수면시간";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(46, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "고개떨굼";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(45, 235);
            this.progressBar2.Maximum = 4;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(241, 23);
            this.progressBar2.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(45, 264);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 21);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(821, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(88, 29);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(821, 148);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(88, 29);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(821, 192);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(88, 29);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(821, 235);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(88, 29);
            this.richTextBox4.TabIndex = 13;
            this.richTextBox4.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(915, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "매우 낮음";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(915, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "낮음";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(915, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "높음";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(915, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "매우 높음";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(1614, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "자주";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(1614, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "가끔";
            // 
            // label15
            // 
            this.label15.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(1614, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 21);
            this.label15.TabIndex = 23;
            this.label15.Text = "거의 안함";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(1520, 188);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(88, 33);
            this.richTextBox6.TabIndex = 21;
            this.richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(1520, 144);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(88, 33);
            this.richTextBox7.TabIndex = 20;
            this.richTextBox7.Text = "";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(1520, 96);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(88, 33);
            this.richTextBox8.TabIndex = 19;
            this.richTextBox8.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(12, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(689, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "if 눈 감음 지속 시간 is 매우 낮음 and 고개 떨꿈 횟수 is 거의 안함 than 수면정도 is 완전낮음";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(512, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(689, 21);
            this.label16.TabIndex = 27;
            this.label16.Text = "if 눈 감음 지속 시간 is 매우 낮음 and 고개 떨꿈 횟수 is 거의 안함 than 수면정도 is 완전낮음";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(1141, 389);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(689, 21);
            this.label17.TabIndex = 28;
            this.label17.Text = "if 눈 감음 지속 시간 is 매우 낮음 and 고개 떨꿈 횟수 is 거의 안함 than 수면정도 is 완전낮음";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(1590, 389);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(689, 21);
            this.label18.TabIndex = 29;
            this.label18.Text = "if 눈 감음 지속 시간 is 매우 낮음 and 고개 떨꿈 횟수 is 거의 안함 than 수면정도 is 완전낮음";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(12, 489);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(267, 19);
            this.label19.TabIndex = 30;
            this.label19.Text = "완전 아님 = min( 매우 낮음, 거의 안함 )";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(12, 530);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(300, 19);
            this.label20.TabIndex = 31;
            this.label20.Text = "완전 아님 = min(                 ,                 )";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "추론";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inference1
            // 
            this.inference1.Location = new System.Drawing.Point(143, 530);
            this.inference1.Name = "inference1";
            this.inference1.Size = new System.Drawing.Size(58, 27);
            this.inference1.TabIndex = 33;
            this.inference1.Text = "";
            // 
            // inference2
            // 
            this.inference2.Location = new System.Drawing.Point(228, 530);
            this.inference2.Name = "inference2";
            this.inference2.Size = new System.Drawing.Size(58, 27);
            this.inference2.TabIndex = 34;
            this.inference2.Text = "";
            // 
            // inference4
            // 
            this.inference4.Location = new System.Drawing.Point(678, 530);
            this.inference4.Name = "inference4";
            this.inference4.Size = new System.Drawing.Size(58, 27);
            this.inference4.TabIndex = 38;
            this.inference4.Text = "";
            // 
            // inference3
            // 
            this.inference3.Location = new System.Drawing.Point(601, 530);
            this.inference3.Name = "inference3";
            this.inference3.Size = new System.Drawing.Size(58, 27);
            this.inference3.TabIndex = 37;
            this.inference3.Text = "";
            this.inference3.TextChanged += new System.EventHandler(this.richTextBox9_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(512, 530);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(242, 19);
            this.label21.TabIndex = 36;
            this.label21.Text = "의심 = min(              ,               )";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(512, 489);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(168, 19);
            this.label22.TabIndex = 35;
            this.label22.Text = "의심 = min( 낮음, 가끔 )";
            // 
            // inference6
            // 
            this.inference6.Location = new System.Drawing.Point(1357, 530);
            this.inference6.Name = "inference6";
            this.inference6.Size = new System.Drawing.Size(58, 27);
            this.inference6.TabIndex = 42;
            this.inference6.Text = "";
            // 
            // inference5
            // 
            this.inference5.Location = new System.Drawing.Point(1272, 530);
            this.inference5.Name = "inference5";
            this.inference5.Size = new System.Drawing.Size(58, 27);
            this.inference5.TabIndex = 41;
            this.inference5.Text = "";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(1141, 530);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(304, 19);
            this.label23.TabIndex = 40;
            this.label23.Text = "약간 확실 = NOT(                 ,                 )";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(1141, 489);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(229, 19);
            this.label24.TabIndex = 39;
            this.label24.Text = "약간 확실 = min( 높음, 거의안함 )";
            // 
            // resultInference4
            // 
            this.resultInference4.Location = new System.Drawing.Point(1653, 530);
            this.resultInference4.Name = "resultInference4";
            this.resultInference4.Size = new System.Drawing.Size(58, 27);
            this.resultInference4.TabIndex = 45;
            this.resultInference4.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(1590, 530);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 19);
            this.label25.TabIndex = 44;
            this.label25.Text = "확실 = ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(1590, 489);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 19);
            this.label26.TabIndex = 43;
            this.label26.Text = "확실 = 매우높음";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(318, 530);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 19);
            this.label27.TabIndex = 46;
            this.label27.Text = "=";
            // 
            // resultInference1
            // 
            this.resultInference1.Location = new System.Drawing.Point(343, 530);
            this.resultInference1.Name = "resultInference1";
            this.resultInference1.Size = new System.Drawing.Size(58, 27);
            this.resultInference1.TabIndex = 47;
            this.resultInference1.Text = "";
            // 
            // resultInference2
            // 
            this.resultInference2.Location = new System.Drawing.Point(785, 530);
            this.resultInference2.Name = "resultInference2";
            this.resultInference2.Size = new System.Drawing.Size(58, 27);
            this.resultInference2.TabIndex = 48;
            this.resultInference2.Text = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(760, 530);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 19);
            this.label28.TabIndex = 49;
            this.label28.Text = "=";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(1451, 530);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(19, 19);
            this.label29.TabIndex = 50;
            this.label29.Text = "=";
            // 
            // resultInference3
            // 
            this.resultInference3.Location = new System.Drawing.Point(1476, 530);
            this.resultInference3.Name = "resultInference3";
            this.resultInference3.Size = new System.Drawing.Size(58, 27);
            this.resultInference3.TabIndex = 51;
            this.resultInference3.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 643);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "역퍼지화";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(896, 855);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 25);
            this.label30.TabIndex = 53;
            this.label30.Text = " ==>";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(1680, 862);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(97, 25);
            this.richTextBox5.TabIndex = 54;
            this.richTextBox5.Text = "";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.Location = new System.Drawing.Point(1682, 834);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 21);
            this.label31.TabIndex = 55;
            this.label31.Text = "무게중심";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1783, 862);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 56;
            this.button4.Text = "3D";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(318, 42);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1126, 752);
            this.elementHost1.TabIndex = 57;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1784, 961);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.resultInference3);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.resultInference2);
            this.Controls.Add(this.resultInference1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.resultInference4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.inference6);
            this.Controls.Add(this.inference5);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.inference4);
            this.Controls.Add(this.inference3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.inference2);
            this.Controls.Add(this.inference1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox inference1;
        private System.Windows.Forms.RichTextBox inference2;
        private System.Windows.Forms.RichTextBox inference4;
        private System.Windows.Forms.RichTextBox inference3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox inference6;
        private System.Windows.Forms.RichTextBox inference5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RichTextBox resultInference4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RichTextBox resultInference1;
        private System.Windows.Forms.RichTextBox resultInference2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RichTextBox resultInference3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

