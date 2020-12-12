namespace C19_Tracker
{
    partial class AgyakTermekUC
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
            this.components = new System.ComponentModel.Container();
            this.btnElhelyez = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.agyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teremFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foglaltDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jelenlegiBetegFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coronaTracker_DBDataSet = new C19_Tracker.CoronaTracker_DBDataSet();
            this.labelSzabad = new System.Windows.Forms.Label();
            this.labelFoglalt = new System.Windows.Forms.Label();
            this.agyTableAdapter = new C19_Tracker.CoronaTracker_DBDataSetTableAdapters.AgyTableAdapter();
            this.comboBoxAgy = new System.Windows.Forms.ComboBox();
            this.comboBoxNev = new System.Windows.Forms.ComboBox();
            this.labelSzam = new System.Windows.Forms.Label();
            this.labelBetegID = new System.Windows.Forms.Label();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.agyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teremFKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foglaltDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jelenlegiBetegFKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaTracker_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElhelyez
            // 
            this.btnElhelyez.Location = new System.Drawing.Point(689, 492);
            this.btnElhelyez.Name = "btnElhelyez";
            this.btnElhelyez.Size = new System.Drawing.Size(118, 34);
            this.btnElhelyez.TabIndex = 0;
            this.btnElhelyez.Text = "Elhelyezés";
            this.btnElhelyez.UseVisualStyleBackColor = true;
            this.btnElhelyez.Click += new System.EventHandler(this.btnElhelyez_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(71, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView2.Location = new System.Drawing.Point(664, 213);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(462, 179);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agyIDDataGridViewTextBoxColumn,
            this.teremFKDataGridViewTextBoxColumn,
            this.foglaltDataGridViewCheckBoxColumn,
            this.jelenlegiBetegFKDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.agyBindingSource;
            this.dataGridView3.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView3.Location = new System.Drawing.Point(211, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(504, 83);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // agyIDDataGridViewTextBoxColumn
            // 
            this.agyIDDataGridViewTextBoxColumn.DataPropertyName = "AgyID";
            this.agyIDDataGridViewTextBoxColumn.HeaderText = "Ágy száma";
            this.agyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agyIDDataGridViewTextBoxColumn.Name = "agyIDDataGridViewTextBoxColumn";
            this.agyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.agyIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // teremFKDataGridViewTextBoxColumn
            // 
            this.teremFKDataGridViewTextBoxColumn.DataPropertyName = "TeremFK";
            this.teremFKDataGridViewTextBoxColumn.HeaderText = "Terem száma";
            this.teremFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teremFKDataGridViewTextBoxColumn.Name = "teremFKDataGridViewTextBoxColumn";
            this.teremFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // foglaltDataGridViewCheckBoxColumn
            // 
            this.foglaltDataGridViewCheckBoxColumn.DataPropertyName = "Foglalt";
            this.foglaltDataGridViewCheckBoxColumn.HeaderText = "Foglalt";
            this.foglaltDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.foglaltDataGridViewCheckBoxColumn.Name = "foglaltDataGridViewCheckBoxColumn";
            this.foglaltDataGridViewCheckBoxColumn.Width = 125;
            // 
            // jelenlegiBetegFKDataGridViewTextBoxColumn
            // 
            this.jelenlegiBetegFKDataGridViewTextBoxColumn.DataPropertyName = "JelenlegiBetegFK";
            this.jelenlegiBetegFKDataGridViewTextBoxColumn.HeaderText = "Beteg ID";
            this.jelenlegiBetegFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenlegiBetegFKDataGridViewTextBoxColumn.Name = "jelenlegiBetegFKDataGridViewTextBoxColumn";
            this.jelenlegiBetegFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // agyBindingSource
            // 
            this.agyBindingSource.DataMember = "Agy";
            this.agyBindingSource.DataSource = this.coronaTracker_DBDataSet;
            // 
            // coronaTracker_DBDataSet
            // 
            this.coronaTracker_DBDataSet.DataSetName = "CoronaTracker_DBDataSet";
            this.coronaTracker_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelSzabad
            // 
            this.labelSzabad.AutoSize = true;
            this.labelSzabad.BackColor = System.Drawing.Color.Transparent;
            this.labelSzabad.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSzabad.Location = new System.Drawing.Point(71, 161);
            this.labelSzabad.Name = "labelSzabad";
            this.labelSzabad.Size = new System.Drawing.Size(151, 29);
            this.labelSzabad.TabIndex = 4;
            this.labelSzabad.Text = "Szabad ágyak:";
            // 
            // labelFoglalt
            // 
            this.labelFoglalt.AutoSize = true;
            this.labelFoglalt.BackColor = System.Drawing.Color.Transparent;
            this.labelFoglalt.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoglalt.Location = new System.Drawing.Point(659, 161);
            this.labelFoglalt.Name = "labelFoglalt";
            this.labelFoglalt.Size = new System.Drawing.Size(148, 29);
            this.labelFoglalt.TabIndex = 5;
            this.labelFoglalt.Text = "Foglalt ágyak:";
            // 
            // agyTableAdapter
            // 
            this.agyTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxAgy
            // 
            this.comboBoxAgy.FormattingEnabled = true;
            this.comboBoxAgy.Location = new System.Drawing.Point(59, 62);
            this.comboBoxAgy.Name = "comboBoxAgy";
            this.comboBoxAgy.Size = new System.Drawing.Size(121, 30);
            this.comboBoxAgy.TabIndex = 6;
            this.comboBoxAgy.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgy_SelectedIndexChanged);
            // 
            // comboBoxNev
            // 
            this.comboBoxNev.FormattingEnabled = true;
            this.comboBoxNev.Location = new System.Drawing.Point(966, 72);
            this.comboBoxNev.Name = "comboBoxNev";
            this.comboBoxNev.Size = new System.Drawing.Size(121, 30);
            this.comboBoxNev.TabIndex = 7;
            this.comboBoxNev.SelectedIndexChanged += new System.EventHandler(this.comboBoxNev_SelectedIndexChanged);
            // 
            // labelSzam
            // 
            this.labelSzam.AutoSize = true;
            this.labelSzam.BackColor = System.Drawing.Color.Transparent;
            this.labelSzam.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSzam.Location = new System.Drawing.Point(59, 12);
            this.labelSzam.Name = "labelSzam";
            this.labelSzam.Size = new System.Drawing.Size(121, 29);
            this.labelSzam.TabIndex = 8;
            this.labelSzam.Text = "Ágy száma:";
            // 
            // labelBetegID
            // 
            this.labelBetegID.AutoSize = true;
            this.labelBetegID.BackColor = System.Drawing.Color.Transparent;
            this.labelBetegID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetegID.Location = new System.Drawing.Point(1131, 24);
            this.labelBetegID.Name = "labelBetegID";
            this.labelBetegID.Size = new System.Drawing.Size(173, 29);
            this.labelBetegID.TabIndex = 9;
            this.labelBetegID.Text = "Hozzátartozó ID:";
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.BackColor = System.Drawing.Color.Transparent;
            this.labelNev.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNev.Location = new System.Drawing.Point(961, 24);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(128, 29);
            this.labelNev.TabIndex = 10;
            this.labelNev.Text = "Beteg neve:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(1131, 72);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 29);
            this.labelID.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(1131, 73);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 29);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "-";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agyIDDataGridViewTextBoxColumn1,
            this.teremFKDataGridViewTextBoxColumn1,
            this.foglaltDataGridViewCheckBoxColumn1,
            this.jelenlegiBetegFKDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.agyBindingSource1;
            this.dataGridView4.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView4.Location = new System.Drawing.Point(71, 454);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(546, 102);
            this.dataGridView4.TabIndex = 13;
            // 
            // agyBindingSource1
            // 
            this.agyBindingSource1.DataMember = "Agy";
            this.agyBindingSource1.DataSource = this.coronaTracker_DBDataSet;
            // 
            // agyIDDataGridViewTextBoxColumn1
            // 
            this.agyIDDataGridViewTextBoxColumn1.DataPropertyName = "AgyID";
            this.agyIDDataGridViewTextBoxColumn1.HeaderText = "Ágy száma";
            this.agyIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.agyIDDataGridViewTextBoxColumn1.Name = "agyIDDataGridViewTextBoxColumn1";
            this.agyIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.agyIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // teremFKDataGridViewTextBoxColumn1
            // 
            this.teremFKDataGridViewTextBoxColumn1.DataPropertyName = "TeremFK";
            this.teremFKDataGridViewTextBoxColumn1.HeaderText = "Terem száma";
            this.teremFKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.teremFKDataGridViewTextBoxColumn1.Name = "teremFKDataGridViewTextBoxColumn1";
            this.teremFKDataGridViewTextBoxColumn1.Width = 125;
            // 
            // foglaltDataGridViewCheckBoxColumn1
            // 
            this.foglaltDataGridViewCheckBoxColumn1.DataPropertyName = "Foglalt";
            this.foglaltDataGridViewCheckBoxColumn1.HeaderText = "Foglalt";
            this.foglaltDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.foglaltDataGridViewCheckBoxColumn1.Name = "foglaltDataGridViewCheckBoxColumn1";
            this.foglaltDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // jelenlegiBetegFKDataGridViewTextBoxColumn1
            // 
            this.jelenlegiBetegFKDataGridViewTextBoxColumn1.DataPropertyName = "JelenlegiBetegFK";
            this.jelenlegiBetegFKDataGridViewTextBoxColumn1.HeaderText = "Beteg ID";
            this.jelenlegiBetegFKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.jelenlegiBetegFKDataGridViewTextBoxColumn1.Name = "jelenlegiBetegFKDataGridViewTextBoxColumn1";
            this.jelenlegiBetegFKDataGridViewTextBoxColumn1.Width = 125;
            // 
            // AgyakTermekUC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::C19_Tracker.Properties.Resources.Background2;
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.labelBetegID);
            this.Controls.Add(this.labelSzam);
            this.Controls.Add(this.comboBoxNev);
            this.Controls.Add(this.comboBoxAgy);
            this.Controls.Add(this.labelFoglalt);
            this.Controls.Add(this.labelSzabad);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnElhelyez);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AgyakTermekUC";
            this.Size = new System.Drawing.Size(1336, 600);
            this.Load += new System.EventHandler(this.AgyakTermekUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaTracker_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElhelyez;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelSzabad;
        private System.Windows.Forms.Label labelFoglalt;
        private System.Windows.Forms.BindingSource agyBindingSource;
        private CoronaTracker_DBDataSet coronaTracker_DBDataSet;
        private CoronaTracker_DBDataSetTableAdapters.AgyTableAdapter agyTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxAgy;
        private System.Windows.Forms.ComboBox comboBoxNev;
        private System.Windows.Forms.Label labelSzam;
        private System.Windows.Forms.Label labelBetegID;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn agyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teremFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn foglaltDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenlegiBetegFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource agyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teremFKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn foglaltDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenlegiBetegFKDataGridViewTextBoxColumn1;
    }
}
