namespace WSD
{
    partial class WSD
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSD));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timetoshutdowntext = new System.Windows.Forms.TextBox();
            this.bywho = new System.Windows.Forms.Label();
            this.why = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.what = new System.Windows.Forms.Button();
            this.whomade = new System.Windows.Forms.Label();
            this.gmail = new System.Windows.Forms.Label();
            this.NL = new System.Windows.Forms.PictureBox();
            this.NG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NG)).BeginInit();
            this.SuspendLayout();
            // 
            // timetoshutdowntext
            // 
            this.timetoshutdowntext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetoshutdowntext.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timetoshutdowntext.HideSelection = false;
            this.timetoshutdowntext.Location = new System.Drawing.Point(12, 25);
            this.timetoshutdowntext.MaximumSize = new System.Drawing.Size(260, 80);
            this.timetoshutdowntext.MaxLength = 5;
            this.timetoshutdowntext.MinimumSize = new System.Drawing.Size(260, 80);
            this.timetoshutdowntext.Name = "timetoshutdowntext";
            this.timetoshutdowntext.Size = new System.Drawing.Size(260, 80);
            this.timetoshutdowntext.TabIndex = 1;
            this.timetoshutdowntext.Text = "##:##";
            this.timetoshutdowntext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timetoshutdowntext.WordWrap = false;
            this.timetoshutdowntext.Enter += new System.EventHandler(this.begintoshuttime);
            // 
            // bywho
            // 
            this.bywho.AutoSize = true;
            this.bywho.Location = new System.Drawing.Point(12, 111);
            this.bywho.Name = "bywho";
            this.bywho.Size = new System.Drawing.Size(71, 13);
            this.bywho.TabIndex = 1;
            this.bywho.Text = "by NexusGen";
            // 
            // why
            // 
            this.why.AutoSize = true;
            this.why.Location = new System.Drawing.Point(80, 9);
            this.why.Name = "why";
            this.why.Size = new System.Drawing.Size(118, 13);
            this.why.TabIndex = 2;
            this.why.Text = "Turn off the windows at";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, -25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // what
            // 
            this.what.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.what.Location = new System.Drawing.Point(252, 108);
            this.what.Name = "what";
            this.what.Size = new System.Drawing.Size(20, 20);
            this.what.TabIndex = 4;
            this.what.Text = "?";
            this.what.UseVisualStyleBackColor = true;
            this.what.Click += new System.EventHandler(this.show2at);
            // 
            // whomade
            // 
            this.whomade.AutoSize = true;
            this.whomade.Location = new System.Drawing.Point(159, 111);
            this.whomade.Name = "whomade";
            this.whomade.Size = new System.Drawing.Size(87, 13);
            this.whomade.TabIndex = 5;
            this.whomade.Text = "Nadir Abdullayev";
            this.whomade.Visible = false;
            // 
            // gmail
            // 
            this.gmail.AutoSize = true;
            this.gmail.Location = new System.Drawing.Point(80, 9);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(124, 13);
            this.gmail.TabIndex = 6;
            this.gmail.Text = "nexusgeniuz@gmail.com";
            this.gmail.Visible = false;
            // 
            // NL
            // 
            this.NL.Image = global::WSD.Properties.Resources.NL16;
            this.NL.InitialImage = global::WSD.Properties.Resources.NL16;
            this.NL.Location = new System.Drawing.Point(105, 111);
            this.NL.Name = "NL";
            this.NL.Size = new System.Drawing.Size(16, 16);
            this.NL.TabIndex = 8;
            this.NL.TabStop = false;
            this.NL.Click += new System.EventHandler(this.Site);
            // 
            // NG
            // 
            this.NG.Image = global::WSD.Properties.Resources.NG16;
            this.NG.InitialImage = ((System.Drawing.Image)(resources.GetObject("NG.InitialImage")));
            this.NG.Location = new System.Drawing.Point(83, 111);
            this.NG.Name = "NG";
            this.NG.Size = new System.Drawing.Size(16, 16);
            this.NG.TabIndex = 7;
            this.NG.TabStop = false;
            this.NG.Click += new System.EventHandler(this.Twitter);
            // 
            // WSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.NL);
            this.Controls.Add(this.NG);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.whomade);
            this.Controls.Add(this.what);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.why);
            this.Controls.Add(this.bywho);
            this.Controls.Add(this.timetoshutdowntext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 170);
            this.MinimumSize = new System.Drawing.Size(300, 170);
            this.Name = "WSD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WSD";
            ((System.ComponentModel.ISupportInitialize)(this.NL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox timetoshutdowntext;
        private System.Windows.Forms.Label bywho;
        private System.Windows.Forms.Label why;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button what;
        private System.Windows.Forms.Label whomade;
        private System.Windows.Forms.Label gmail;
        private System.Windows.Forms.PictureBox NG;
        private System.Windows.Forms.PictureBox NL;
    }
}

