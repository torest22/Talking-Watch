namespace Talking_Watch
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusButton = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.b_Stop1 = new System.Windows.Forms.Button();
            this.b_Start1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.StatusButton2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.b_Stop2 = new System.Windows.Forms.Button();
            this.b_Start2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.b_Stop3 = new System.Windows.Forms.Button();
            this.b_Start3 = new System.Windows.Forms.Button();
            this.StatusButton3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.b_Stop4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.b_Start4 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.StatusButton4 = new System.Windows.Forms.Label();
            this.StatusButton5 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.b_Start5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.b_Stop5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.Return = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusButton
            // 
            this.StatusButton.AutoSize = true;
            this.StatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusButton.Location = new System.Drawing.Point(316, 8);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(111, 24);
            this.StatusButton.TabIndex = 3;
            this.StatusButton.Text = "Status alarm";
            this.StatusButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(24, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.b_Stop1);
            this.splitContainer1.Panel1.Controls.Add(this.b_Start1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.StatusButton);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel2.Controls.Add(this.StatusButton2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.b_Stop2);
            this.splitContainer1.Panel2.Controls.Add(this.b_Start2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(521, 255);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 6;
            // 
            // b_Stop1
            // 
            this.b_Stop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Stop1.Location = new System.Drawing.Point(320, 45);
            this.b_Stop1.Name = "b_Stop1";
            this.b_Stop1.Size = new System.Drawing.Size(84, 30);
            this.b_Stop1.TabIndex = 10;
            this.b_Stop1.Text = "Stop";
            this.b_Stop1.UseVisualStyleBackColor = true;
            this.b_Stop1.Click += new System.EventHandler(this.b_Stop1_Click);
            // 
            // b_Start1
            // 
            this.b_Start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Start1.Location = new System.Drawing.Point(184, 45);
            this.b_Start1.Name = "b_Start1";
            this.b_Start1.Size = new System.Drawing.Size(84, 30);
            this.b_Start1.TabIndex = 9;
            this.b_Start1.Text = "Start";
            this.b_Start1.UseVisualStyleBackColor = true;
            this.b_Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alarm massage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alarm 1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 29);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker);
            // 
            // StatusButton2
            // 
            this.StatusButton2.AutoSize = true;
            this.StatusButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusButton2.Location = new System.Drawing.Point(316, 16);
            this.StatusButton2.Name = "StatusButton2";
            this.StatusButton2.Size = new System.Drawing.Size(111, 24);
            this.StatusButton2.TabIndex = 15;
            this.StatusButton2.Text = "Status alarm";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(184, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 29);
            this.textBox2.TabIndex = 14;
            // 
            // b_Stop2
            // 
            this.b_Stop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Stop2.Location = new System.Drawing.Point(320, 53);
            this.b_Stop2.Name = "b_Stop2";
            this.b_Stop2.Size = new System.Drawing.Size(94, 32);
            this.b_Stop2.TabIndex = 13;
            this.b_Stop2.Text = "Stop";
            this.b_Stop2.UseVisualStyleBackColor = true;
            this.b_Stop2.Click += new System.EventHandler(this.Stop2_Click);
            // 
            // b_Start2
            // 
            this.b_Start2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Start2.Location = new System.Drawing.Point(184, 53);
            this.b_Start2.Name = "b_Start2";
            this.b_Start2.Size = new System.Drawing.Size(94, 32);
            this.b_Start2.TabIndex = 12;
            this.b_Start2.Text = "Start";
            this.b_Start2.UseVisualStyleBackColor = true;
            this.b_Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alarm 2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(24, 273);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.b_Stop3);
            this.splitContainer2.Panel1.Controls.Add(this.b_Start3);
            this.splitContainer2.Panel1.Controls.Add(this.StatusButton3);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker3);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox4);
            this.splitContainer2.Panel2.Controls.Add(this.b_Stop4);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.b_Start4);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker4);
            this.splitContainer2.Panel2.Controls.Add(this.StatusButton4);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(521, 230);
            this.splitContainer2.SplitterDistance = 115;
            this.splitContainer2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(184, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 29);
            this.textBox3.TabIndex = 13;
            // 
            // b_Stop3
            // 
            this.b_Stop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Stop3.Location = new System.Drawing.Point(329, 45);
            this.b_Stop3.Name = "b_Stop3";
            this.b_Stop3.Size = new System.Drawing.Size(75, 32);
            this.b_Stop3.TabIndex = 12;
            this.b_Stop3.Text = "Stop";
            this.b_Stop3.UseVisualStyleBackColor = true;
            this.b_Stop3.Click += new System.EventHandler(this.Stop3_Click);
            // 
            // b_Start3
            // 
            this.b_Start3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Start3.Location = new System.Drawing.Point(184, 45);
            this.b_Start3.Name = "b_Start3";
            this.b_Start3.Size = new System.Drawing.Size(75, 32);
            this.b_Start3.TabIndex = 11;
            this.b_Start3.Text = "Start";
            this.b_Start3.UseVisualStyleBackColor = true;
            this.b_Start3.Click += new System.EventHandler(this.Start3_Click);
            // 
            // StatusButton3
            // 
            this.StatusButton3.AutoSize = true;
            this.StatusButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusButton3.Location = new System.Drawing.Point(316, 14);
            this.StatusButton3.Name = "StatusButton3";
            this.StatusButton3.Size = new System.Drawing.Size(111, 24);
            this.StatusButton3.TabIndex = 10;
            this.StatusButton3.Text = "Status alarm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alarm 3";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:mm:ss";
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(184, 9);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(98, 29);
            this.dateTimePicker3.TabIndex = 9;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(184, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 29);
            this.textBox4.TabIndex = 13;
            // 
            // b_Stop4
            // 
            this.b_Stop4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Stop4.Location = new System.Drawing.Point(329, 41);
            this.b_Stop4.Name = "b_Stop4";
            this.b_Stop4.Size = new System.Drawing.Size(75, 32);
            this.b_Stop4.TabIndex = 12;
            this.b_Stop4.Text = "Stop";
            this.b_Stop4.UseVisualStyleBackColor = true;
            this.b_Stop4.Click += new System.EventHandler(this.b_Stop4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alarm 4";
            // 
            // b_Start4
            // 
            this.b_Start4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Start4.Location = new System.Drawing.Point(184, 41);
            this.b_Start4.Name = "b_Start4";
            this.b_Start4.Size = new System.Drawing.Size(75, 32);
            this.b_Start4.TabIndex = 11;
            this.b_Start4.Text = "Start";
            this.b_Start4.UseVisualStyleBackColor = true;
            this.b_Start4.Click += new System.EventHandler(this.b_Start4_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "HH:mm:ss";
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(184, 5);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(98, 29);
            this.dateTimePicker4.TabIndex = 9;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // StatusButton4
            // 
            this.StatusButton4.AutoSize = true;
            this.StatusButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusButton4.Location = new System.Drawing.Point(316, 10);
            this.StatusButton4.Name = "StatusButton4";
            this.StatusButton4.Size = new System.Drawing.Size(111, 24);
            this.StatusButton4.TabIndex = 10;
            this.StatusButton4.Text = "Status alarm";
            // 
            // StatusButton5
            // 
            this.StatusButton5.AutoSize = true;
            this.StatusButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusButton5.Location = new System.Drawing.Point(316, 14);
            this.StatusButton5.Name = "StatusButton5";
            this.StatusButton5.Size = new System.Drawing.Size(111, 24);
            this.StatusButton5.TabIndex = 10;
            this.StatusButton5.Text = "Status alarm";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "HH:mm:ss";
            this.dateTimePicker5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(184, 9);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(98, 29);
            this.dateTimePicker5.TabIndex = 9;
            // 
            // b_Start5
            // 
            this.b_Start5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Start5.Location = new System.Drawing.Point(184, 45);
            this.b_Start5.Name = "b_Start5";
            this.b_Start5.Size = new System.Drawing.Size(75, 32);
            this.b_Start5.TabIndex = 11;
            this.b_Start5.Text = "Start";
            this.b_Start5.UseVisualStyleBackColor = true;
            this.b_Start5.Click += new System.EventHandler(this.b_Start5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Alarm 5";
            // 
            // b_Stop5
            // 
            this.b_Stop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Stop5.Location = new System.Drawing.Point(329, 45);
            this.b_Stop5.Name = "b_Stop5";
            this.b_Stop5.Size = new System.Drawing.Size(75, 32);
            this.b_Stop5.TabIndex = 12;
            this.b_Stop5.Text = "Stop";
            this.b_Stop5.UseVisualStyleBackColor = true;
            this.b_Stop5.Click += new System.EventHandler(this.b_Stop5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(184, 83);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 29);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(24, 509);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox5);
            this.splitContainer3.Panel1.Controls.Add(this.StatusButton5);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            this.splitContainer3.Panel1.Controls.Add(this.b_Stop5);
            this.splitContainer3.Panel1.Controls.Add(this.dateTimePicker5);
            this.splitContainer3.Panel1.Controls.Add(this.b_Start5);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(521, 230);
            this.splitContainer3.SplitterDistance = 115;
            this.splitContainer3.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "Alarm 5";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(514, 19);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(87, 31);
            this.Return.TabIndex = 15;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "HH:mm:ss";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(184, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 29);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(630, 288);
            this.ControlBox = false;
            this.Controls.Add(this.Return);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatusButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label StatusButton2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button b_Stop2;
        private System.Windows.Forms.Button b_Start2;
        private System.Windows.Forms.Label StatusButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button b_Stop3;
        private System.Windows.Forms.Button b_Start3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button b_Stop4;
        private System.Windows.Forms.Button b_Start4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label StatusButton4;
        private System.Windows.Forms.Label StatusButton5;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Button b_Start5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_Stop5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button b_Stop1;
        private System.Windows.Forms.Button b_Start1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}