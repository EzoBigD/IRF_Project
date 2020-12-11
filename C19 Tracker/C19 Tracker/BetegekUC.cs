using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;

namespace C19_Tracker
{
    public partial class BetegekUC : UserControl
    {

        CoronaTracker_DBEntities context = new CoronaTracker_DBEntities();
        public BetegekUC()
        {
            InitializeComponent();
            context.Betegs.Load();
        }

        private void BetegekUC_Load(object sender, EventArgs e)
        {           
            var be = from x in context.Betegs
                     select x;
            betegBindingSource.DataSource = be.ToList();
           
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[8].Value);

                 if (s == true)
                    {
                        toDelete.Add(row);
                    }
            }

            foreach (DataGridViewRow row in toDelete)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Refresh();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var b in context.Betegs)
                {                    
                    sw.Write(b.Nev);
                    sw.Write(";");
                    sw.Write(b.Szul_Ido.ToString());
                    sw.Write(";");
                    sw.Write(b.Szul_Hely);
                    sw.Write(";");
                    sw.Write(b.Nem);
                    sw.Write(";");
                    sw.Write(b.Taj_Szam.ToString());
                    sw.Write(";");
                    sw.Write(b.Reg_Nap.ToString());
                    sw.Write(";");
                    sw.Write(b.OrvosFK.ToString());
                    sw.Write(";");
                    sw.Write(b.JelenlegiAllapotFK.ToString());
                    sw.Write(";");
                    sw.Write(b.Gyogyult.ToString());
                    sw.WriteLine();
                }
            }
        }
    }
}
