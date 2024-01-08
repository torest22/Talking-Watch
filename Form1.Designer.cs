namespace Talking_Watch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.TimeSec = new System.Windows.Forms.Label();
            this.B_new_wind = new System.Windows.Forms.Button();
            this.Week = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.Control;
            this.Time.Location = new System.Drawing.Point(23, 19);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(216, 85);
            this.Time.TabIndex = 4;
            this.Time.Text = "12:48";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.Control;
            this.Date.Location = new System.Drawing.Point(38, 137);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(78, 34);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // TimeSec
            // 
            this.TimeSec.AutoSize = true;
            this.TimeSec.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSec.ForeColor = System.Drawing.SystemColors.Control;
            this.TimeSec.Location = new System.Drawing.Point(245, 64);
            this.TimeSec.Name = "TimeSec";
            this.TimeSec.Size = new System.Drawing.Size(42, 28);
            this.TimeSec.TabIndex = 4;
            this.TimeSec.Text = "35";
            this.TimeSec.Click += new System.EventHandler(this.TimeSec_Click);
            // 
            // B_new_wind
            // 
            this.B_new_wind.BackColor = System.Drawing.Color.DimGray;
            this.B_new_wind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_new_wind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_new_wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_new_wind.ForeColor = System.Drawing.Color.Orange;
            this.B_new_wind.Location = new System.Drawing.Point(401, 19);
            this.B_new_wind.Name = "B_new_wind";
            this.B_new_wind.Size = new System.Drawing.Size(81, 36);
            this.B_new_wind.TabIndex = 4;
            this.B_new_wind.Text = "Alarm";
            this.B_new_wind.UseVisualStyleBackColor = false;
            this.B_new_wind.Click += new System.EventHandler(this.B_new_wind_Click);
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Week.ForeColor = System.Drawing.SystemColors.Control;
            this.Week.Location = new System.Drawing.Point(276, 137);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(83, 34);
            this.Week.TabIndex = 4;
            this.Week.Text = "Week";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.Week);
            this.splitContainer1.Panel1.Controls.Add(this.B_new_wind);
            this.splitContainer1.Panel1.Controls.Add(this.TimeSec);
            this.splitContainer1.Panel1.Controls.Add(this.Date);
            this.splitContainer1.Panel1.Controls.Add(this.Time);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(534, 183);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(534, 183);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talking Watch";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label TimeSec;
        private System.Windows.Forms.Button B_new_wind;
        private System.Windows.Forms.Label Week;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

