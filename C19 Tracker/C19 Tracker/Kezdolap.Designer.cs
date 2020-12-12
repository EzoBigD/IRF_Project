namespace C19_Tracker
{
    partial class Bejelentkezes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bejelentkezes));
            this.btnAgyakTermek = new System.Windows.Forms.Button();
            this.btnBetegek = new System.Windows.Forms.Button();
            this.btnBeosztas = new System.Windows.Forms.Button();
            this.btnAllapot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelFelhaszn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgyakTermek
            // 
            this.btnAgyakTermek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgyakTermek.BackgroundImage")));
            this.btnAgyakTermek.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgyakTermek.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAgyakTermek.Location = new System.Drawing.Point(492, 0);
            this.btnAgyakTermek.Name = "btnAgyakTermek";
            this.btnAgyakTermek.Size = new System.Drawing.Size(191, 123);
            this.btnAgyakTermek.TabIndex = 0;
            this.btnAgyakTermek.Text = "Ágyak/Termek";
            this.btnAgyakTermek.UseVisualStyleBackColor = true;
            this.btnAgyakTermek.Click += new System.EventHandler(this.btnAgyakTermek_Click);
            // 
            // btnBetegek
            // 
            this.btnBetegek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBetegek.BackgroundImage")));
            this.btnBetegek.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetegek.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBetegek.Location = new System.Drawing.Point(677, 0);
            this.btnBetegek.Name = "btnBetegek";
            this.btnBetegek.Size = new System.Drawing.Size(191, 123);
            this.btnBetegek.TabIndex = 1;
            this.btnBetegek.Text = "Betegek";
            this.btnBetegek.UseVisualStyleBackColor = true;
            this.btnBetegek.Click += new System.EventHandler(this.btnBetegek_Click);
            // 
            // btnBeosztas
            // 
            this.btnBeosztas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeosztas.BackgroundImage")));
            this.btnBeosztas.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeosztas.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBeosztas.Location = new System.Drawing.Point(864, 0);
            this.btnBeosztas.Name = "btnBeosztas";
            this.btnBeosztas.Size = new System.Drawing.Size(191, 123);
            this.btnBeosztas.TabIndex = 2;
            this.btnBeosztas.Text = "Beosztás";
            this.btnBeosztas.UseVisualStyleBackColor = true;
            this.btnBeosztas.Click += new System.EventHandler(this.btnBeosztas_Click);
            // 
            // btnAllapot
            // 
            this.btnAllapot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllapot.BackgroundImage")));
            this.btnAllapot.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllapot.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAllapot.Location = new System.Drawing.Point(1050, 0);
            this.btnAllapot.Name = "btnAllapot";
            this.btnAllapot.Size = new System.Drawing.Size(191, 123);
            this.btnAllapot.TabIndex = 3;
            this.btnAllapot.Text = "Betegek Állapota";
            this.btnAllapot.UseVisualStyleBackColor = true;
            this.btnAllapot.Click += new System.EventHandler(this.btnAllapot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C19_Tracker.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkCyan;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.Location = new System.Drawing.Point(1700, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::C19_Tracker.Properties.Resources.Background2;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1738, 627);
            this.panel1.TabIndex = 6;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelDay.Location = new System.Drawing.Point(1502, 15);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(93, 37);
            this.labelDay.TabIndex = 7;
            this.labelDay.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTime.Location = new System.Drawing.Point(1580, 52);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(93, 37);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelFelhaszn
            // 
            this.labelFelhaszn.AutoSize = true;
            this.labelFelhaszn.BackColor = System.Drawing.Color.Transparent;
            this.labelFelhaszn.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFelhaszn.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelFelhaszn.Location = new System.Drawing.Point(1296, 38);
            this.labelFelhaszn.Name = "labelFelhaszn";
            this.labelFelhaszn.Size = new System.Drawing.Size(26, 37);
            this.labelFelhaszn.TabIndex = 9;
            this.labelFelhaszn.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(1247, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bejelentkezve:";
            // 
            // Bejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::C19_Tracker.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1738, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFelhaszn);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAllapot);
            this.Controls.Add(this.btnBeosztas);
            this.Controls.Add(this.btnBetegek);
            this.Controls.Add(this.btnAgyakTermek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2100, 1200);
            this.MinimizeBox = false;
            this.Name = "Bejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoronaTracker";
            this.Load += new System.EventHandler(this.Bejelentkezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgyakTermek;
        private System.Windows.Forms.Button btnBetegek;
        private System.Windows.Forms.Button btnBeosztas;
        private System.Windows.Forms.Button btnAllapot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelFelhaszn;
        private System.Windows.Forms.Label label2;
    }
}

