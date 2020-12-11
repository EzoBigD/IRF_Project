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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betegFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sulyossagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kohogesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nehezLegzesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lazDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.izVesztesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allapotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coronaTracker_DBDataSet = new C19_Tracker.CoronaTracker_DBDataSet();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblAllapot = new System.Windows.Forms.Label();
            this.listBoxNev = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.allapotTableAdapter = new C19_Tracker.CoronaTracker_DBDataSetTableAdapters.AllapotTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allapotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaTracker_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fDatumDataGridViewTextBoxColumn,
            this.betegFKDataGridViewTextBoxColumn,
            this.sulyossagDataGridViewTextBoxColumn,
            this.kohogesDataGridViewCheckBoxColumn,
            this.nehezLegzesDataGridViewCheckBoxColumn,
            this.lazDataGridViewCheckBoxColumn,
            this.izVesztesDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.allapotBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(269, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // fDatumDataGridViewTextBoxColumn
            // 
            this.fDatumDataGridViewTextBoxColumn.DataPropertyName = "FDatum";
            this.fDatumDataGridViewTextBoxColumn.HeaderText = "Feljegyzés dátuma";
            this.fDatumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fDatumDataGridViewTextBoxColumn.Name = "fDatumDataGridViewTextBoxColumn";
            this.fDatumDataGridViewTextBoxColumn.Width = 125;
            // 
            // betegFKDataGridViewTextBoxColumn
            // 
            this.betegFKDataGridViewTextBoxColumn.DataPropertyName = "BetegFK";
            this.betegFKDataGridViewTextBoxColumn.HeaderText = "Beteg ID";
            this.betegFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.betegFKDataGridViewTextBoxColumn.Name = "betegFKDataGridViewTextBoxColumn";
            this.betegFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // sulyossagDataGridViewTextBoxColumn
            // 
            this.sulyossagDataGridViewTextBoxColumn.DataPropertyName = "Sulyossag";
            this.sulyossagDataGridViewTextBoxColumn.HeaderText = "Súlyosság";
            this.sulyossagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sulyossagDataGridViewTextBoxColumn.Name = "sulyossagDataGridViewTextBoxColumn";
            this.sulyossagDataGridViewTextBoxColumn.Width = 125;
            // 
            // kohogesDataGridViewCheckBoxColumn
            // 
            this.kohogesDataGridViewCheckBoxColumn.DataPropertyName = "Kohoges";
            this.kohogesDataGridViewCheckBoxColumn.HeaderText = "Köhögés";
            this.kohogesDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.kohogesDataGridViewCheckBoxColumn.Name = "kohogesDataGridViewCheckBoxColumn";
            this.kohogesDataGridViewCheckBoxColumn.Width = 125;
            // 
            // nehezLegzesDataGridViewCheckBoxColumn
            // 
            this.nehezLegzesDataGridViewCheckBoxColumn.DataPropertyName = "NehezLegzes";
            this.nehezLegzesDataGridViewCheckBoxColumn.HeaderText = "Nehéz légzés";
            this.nehezLegzesDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.nehezLegzesDataGridViewCheckBoxColumn.Name = "nehezLegzesDataGridViewCheckBoxColumn";
            this.nehezLegzesDataGridViewCheckBoxColumn.Width = 125;
            // 
            // lazDataGridViewCheckBoxColumn
            // 
            this.lazDataGridViewCheckBoxColumn.DataPropertyName = "Laz";
            this.lazDataGridViewCheckBoxColumn.HeaderText = "Láz";
            this.lazDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.lazDataGridViewCheckBoxColumn.Name = "lazDataGridViewCheckBoxColumn";
            this.lazDataGridViewCheckBoxColumn.Width = 125;
            // 
            // izVesztesDataGridViewCheckBoxColumn
            // 
            this.izVesztesDataGridViewCheckBoxColumn.DataPropertyName = "IzVesztes";
            this.izVesztesDataGridViewCheckBoxColumn.HeaderText = "Íz vesztés";
            this.izVesztesDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.izVesztesDataGridViewCheckBoxColumn.Name = "izVesztesDataGridViewCheckBoxColumn";
            this.izVesztesDataGridViewCheckBoxColumn.Width = 125;
            // 
            // allapotBindingSource
            // 
            this.allapotBindingSource.DataMember = "Allapot";
            this.allapotBindingSource.DataSource = this.coronaTracker_DBDataSet;
            // 
            // coronaTracker_DBDataSet
            // 
            this.coronaTracker_DBDataSet.DataSetName = "CoronaTracker_DBDataSet";
            this.coronaTracker_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(79, 45);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(120, 29);
            this.textBoxNev.TabIndex = 1;
            this.textBoxNev.TextChanged += new System.EventHandler(this.textBoxNev_TextChanged);
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.BackColor = System.Drawing.Color.Transparent;
            this.lblNev.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNev.Location = new System.Drawing.Point(15, 43);
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
            this.lblAllapot.Location = new System.Drawing.Point(264, 222);
            this.lblAllapot.Name = "lblAllapot";
            this.lblAllapot.Size = new System.Drawing.Size(212, 29);
            this.lblAllapot.TabIndex = 3;
            this.lblAllapot.Text = "Állapot feljegyzések:";
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
            this.listBoxNev.SelectedIndexChanged += new System.EventHandler(this.listBoxNev_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kiválasztott beteg állapot feljegyzései:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView2.Location = new System.Drawing.Point(269, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(992, 151);
            this.dataGridView2.TabIndex = 6;
            // 
            // allapotTableAdapter
            // 
            this.allapotTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1176, 545);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 35);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AllapotUC
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::C19_Tracker.Properties.Resources.Background2;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNev);
            this.Controls.Add(this.lblAllapot);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllapotUC";
            this.Size = new System.Drawing.Size(1332, 593);
            this.Load += new System.EventHandler(this.AllapotUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allapotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaTracker_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblAllapot;
        private System.Windows.Forms.ListBox listBoxNev;
        private System.Windows.Forms.BindingSource allapotBindingSource;
        private CoronaTracker_DBDataSet coronaTracker_DBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CoronaTracker_DBDataSetTableAdapters.AllapotTableAdapter allapotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn betegFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sulyossagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kohogesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nehezLegzesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lazDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn izVesztesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonSave;
    }
}
