﻿namespace C19_Tracker
{
    partial class BeosztasUC
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
            this.listBoxOrvos = new System.Windows.Forms.ListBox();
            this.textBoxOrvos = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelBeosztas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxOrvos
            // 
            this.listBoxOrvos.BackColor = System.Drawing.Color.LightGray;
            this.listBoxOrvos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOrvos.ForeColor = System.Drawing.Color.DarkCyan;
            this.listBoxOrvos.FormattingEnabled = true;
            this.listBoxOrvos.ItemHeight = 22;
            this.listBoxOrvos.Location = new System.Drawing.Point(118, 186);
            this.listBoxOrvos.Name = "listBoxOrvos";
            this.listBoxOrvos.Size = new System.Drawing.Size(140, 264);
            this.listBoxOrvos.TabIndex = 0;
            this.listBoxOrvos.SelectedIndexChanged += new System.EventHandler(this.listBoxOrvos_SelectedIndexChanged);
            // 
            // textBoxOrvos
            // 
            this.textBoxOrvos.Location = new System.Drawing.Point(118, 122);
            this.textBoxOrvos.Name = "textBoxOrvos";
            this.textBoxOrvos.Size = new System.Drawing.Size(140, 29);
            this.textBoxOrvos.TabIndex = 1;
            this.textBoxOrvos.TextChanged += new System.EventHandler(this.textBoxOrvos_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(325, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 334);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.BackColor = System.Drawing.Color.Transparent;
            this.labelNev.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNev.Location = new System.Drawing.Point(33, 120);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(58, 29);
            this.labelNev.TabIndex = 3;
            this.labelNev.Text = "Név:";
            // 
            // labelBeosztas
            // 
            this.labelBeosztas.AutoSize = true;
            this.labelBeosztas.BackColor = System.Drawing.Color.Transparent;
            this.labelBeosztas.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeosztas.Location = new System.Drawing.Point(320, 70);
            this.labelBeosztas.Name = "labelBeosztas";
            this.labelBeosztas.Size = new System.Drawing.Size(202, 29);
            this.labelBeosztas.TabIndex = 4;
            this.labelBeosztas.Text = "Orvosok beosztása:";
            // 
            // BeosztasUC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::C19_Tracker.Properties.Resources.Background2;
            this.Controls.Add(this.labelBeosztas);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxOrvos);
            this.Controls.Add(this.listBoxOrvos);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BeosztasUC";
            this.Size = new System.Drawing.Size(1332, 593);
            this.Load += new System.EventHandler(this.BeosztasUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrvos;
        private System.Windows.Forms.TextBox textBoxOrvos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelBeosztas;
    }
}
