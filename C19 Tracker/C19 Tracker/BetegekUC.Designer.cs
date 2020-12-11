namespace C19_Tracker
{
    partial class BetegekUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulIdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulHelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tajSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orvosFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelenlegiAllapotFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyogyultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.betegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coronaTracker_DBDataSet = new C19_Tracker.CoronaTracker_DBDataSet();
            this.betegTableAdapter = new C19_Tracker.CoronaTracker_DBDataSetTableAdapters.BetegTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaTracker_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nevDataGridViewTextBoxColumn,
            this.szulIdoDataGridViewTextBoxColumn,
            this.szulHelyDataGridViewTextBoxColumn,
            this.nemDataGridViewTextBoxColumn,
            this.tajSzamDataGridViewTextBoxColumn,
            this.regNapDataGridViewTextBoxColumn,
            this.orvosFKDataGridViewTextBoxColumn,
            this.jelenlegiAllapotFKDataGridViewTextBoxColumn,
            this.gyogyultDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.betegBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.Width = 125;
            // 
            // szulIdoDataGridViewTextBoxColumn
            // 
            this.szulIdoDataGridViewTextBoxColumn.DataPropertyName = "Szul_Ido";
            this.szulIdoDataGridViewTextBoxColumn.HeaderText = "Születés Idő";
            this.szulIdoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szulIdoDataGridViewTextBoxColumn.Name = "szulIdoDataGridViewTextBoxColumn";
            this.szulIdoDataGridViewTextBoxColumn.Width = 130;
            // 
            // szulHelyDataGridViewTextBoxColumn
            // 
            this.szulHelyDataGridViewTextBoxColumn.DataPropertyName = "Szul_Hely";
            this.szulHelyDataGridViewTextBoxColumn.HeaderText = "Születési Hely";
            this.szulHelyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szulHelyDataGridViewTextBoxColumn.Name = "szulHelyDataGridViewTextBoxColumn";
            this.szulHelyDataGridViewTextBoxColumn.Width = 125;
            // 
            // nemDataGridViewTextBoxColumn
            // 
            this.nemDataGridViewTextBoxColumn.DataPropertyName = "Nem";
            this.nemDataGridViewTextBoxColumn.HeaderText = "Nem";
            this.nemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nemDataGridViewTextBoxColumn.Name = "nemDataGridViewTextBoxColumn";
            this.nemDataGridViewTextBoxColumn.Width = 125;
            // 
            // tajSzamDataGridViewTextBoxColumn
            // 
            this.tajSzamDataGridViewTextBoxColumn.DataPropertyName = "Taj_Szam";
            this.tajSzamDataGridViewTextBoxColumn.HeaderText = "Taj Szám";
            this.tajSzamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tajSzamDataGridViewTextBoxColumn.Name = "tajSzamDataGridViewTextBoxColumn";
            this.tajSzamDataGridViewTextBoxColumn.Width = 130;
            // 
            // regNapDataGridViewTextBoxColumn
            // 
            this.regNapDataGridViewTextBoxColumn.DataPropertyName = "Reg_Nap";
            this.regNapDataGridViewTextBoxColumn.HeaderText = "Regisztráció Napja";
            this.regNapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regNapDataGridViewTextBoxColumn.Name = "regNapDataGridViewTextBoxColumn";
            this.regNapDataGridViewTextBoxColumn.Width = 125;
            // 
            // orvosFKDataGridViewTextBoxColumn
            // 
            this.orvosFKDataGridViewTextBoxColumn.DataPropertyName = "OrvosFK";
            this.orvosFKDataGridViewTextBoxColumn.HeaderText = "Orvos";
            this.orvosFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orvosFKDataGridViewTextBoxColumn.Name = "orvosFKDataGridViewTextBoxColumn";
            this.orvosFKDataGridViewTextBoxColumn.Width = 140;
            // 
            // jelenlegiAllapotFKDataGridViewTextBoxColumn
            // 
            this.jelenlegiAllapotFKDataGridViewTextBoxColumn.DataPropertyName = "JelenlegiAllapotFK";
            this.jelenlegiAllapotFKDataGridViewTextBoxColumn.HeaderText = "Jelenlegi Állapot";
            this.jelenlegiAllapotFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenlegiAllapotFKDataGridViewTextBoxColumn.Name = "jelenlegiAllapotFKDataGridViewTextBoxColumn";
            this.jelenlegiAllapotFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // gyogyultDataGridViewCheckBoxColumn
            // 
            this.gyogyultDataGridViewCheckBoxColumn.DataPropertyName = "Gyogyult";
            this.gyogyultDataGridViewCheckBoxColumn.HeaderText = "Meggyógyult";
            this.gyogyultDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gyogyultDataGridViewCheckBoxColumn.Name = "gyogyultDataGridViewCheckBoxColumn";
            this.gyogyultDataGridViewCheckBoxColumn.Width = 125;
            // 
            // betegBindingSource
            // 
            this.betegBindingSource.DataMember = "Beteg";
            this.betegBindingSource.DataSource = this.coronaTracker_DBDataSet;
            // 
            // coronaTracker_DBDataSet
            // 
            this.coronaTracker_DBDataSet.DataSetName = "CoronaTracker_DBDataSet";
            this.coronaTracker_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betegTableAdapter
            // 
            this.betegTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1181, 171);
            this.btnSave.MaximumSize = new System.Drawing.Size(108, 42);
            this.btnSave.MinimumSize = new System.Drawing.Size(108, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.Location = new System.Drawing.Point(1181, 235);
            this.btnWrite.MaximumSize = new System.Drawing.Size(108, 42);
            this.btnWrite.MinimumSize = new System.Drawing.Size(108, 42);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(108, 42);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Kiírás";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTorles.Location = new System.Drawing.Point(1181, 298);
            this.btnTorles.MaximumSize = new System.Drawing.Size(108, 42);
            this.btnTorles.MinimumSize = new System.Drawing.Size(108, 42);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(108, 42);
            this.btnTorles.TabIndex = 3;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // BetegekUC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::C19_Tracker.Properties.Resources.Background2;
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BetegekUC";
            this.Size = new System.Drawing.Size(1409, 593);
            this.Load += new System.EventHandler(this.BetegekUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaTracker_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource betegBindingSource;
        private CoronaTracker_DBDataSet coronaTracker_DBDataSet;
        private CoronaTracker_DBDataSetTableAdapters.BetegTableAdapter betegTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szulIdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szulHelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tajSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orvosFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenlegiAllapotFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gyogyultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnTorles;
    }
}
