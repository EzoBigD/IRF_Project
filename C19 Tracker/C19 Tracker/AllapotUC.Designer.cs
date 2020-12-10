namespace C19_Tracker
{
    partial class AllapotUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblAllapot = new System.Windows.Forms.Label();
            this.listBoxNev = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(269, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 29);
            this.textBox1.TabIndex = 1;
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.BackColor = System.Drawing.Color.Transparent;
            this.lblNev.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNev.Location = new System.Drawing.Point(3, 30);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(58, 29);
            this.lblNev.TabIndex = 2;
            this.lblNev.Text = "Név:";
            // 
            // lblAllapot
            // 
            this.lblAllapot.AutoSize = true;
            this.lblAllapot.BackColor = System.Drawing.Color.Transparent;
            this.lblAllapot.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllapot.Location = new System.Drawing.Point(265, 18);
            this.lblAllapot.Name = "lblAllapot";
            this.lblAllapot.Size = new System.Drawing.Size(185, 29);
            this.lblAllapot.TabIndex = 3;
            this.lblAllapot.Text = "Betegek állapota:";
            // 
            // listBoxNev
            // 
            this.listBoxNev.BackColor = System.Drawing.Color.LightGray;
            this.listBoxNev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNev.ForeColor = System.Drawing.Color.DarkCyan;
            this.listBoxNev.FormattingEnabled = true;
            this.listBoxNev.ItemHeight = 22;
            this.listBoxNev.Location = new System.Drawing.Point(79, 97);
            this.listBoxNev.Name = "listBoxNev";
            this.listBoxNev.Size = new System.Drawing.Size(120, 242);
            this.listBoxNev.TabIndex = 4;
            // 
            // AllapotUC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::C19_Tracker.Properties.Resources.Background2;
            this.Controls.Add(this.listBoxNev);
            this.Controls.Add(this.lblAllapot);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllapotUC";
            this.Size = new System.Drawing.Size(1332, 593);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblAllapot;
        private System.Windows.Forms.ListBox listBoxNev;
    }
}
