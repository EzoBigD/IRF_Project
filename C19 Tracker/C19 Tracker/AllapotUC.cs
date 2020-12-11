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

namespace C19_Tracker
{
    public partial class AllapotUC : UserControl
    {
        CoronaTracker_DBEntities context = new CoronaTracker_DBEntities();
        public AllapotUC()
        {
            InitializeComponent();

            context.Allapots.Load();
        }

        private void AllapotUC_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            

            var al = from x in context.Allapots
                     select x;
            allapotBindingSource.DataSource = al.ToList();

            var ne = from a in context.Betegs
                     select a;
            listBoxNev.DataSource = ne.ToList();

            listBoxNev.DisplayMember = "Nev";

        }

        private void listBoxNev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beteg beteg = (Beteg)((ListBox)sender).SelectedItem;

            dataGridView2.DataSource = (from a in context.Allapots
                                        where a.BetegFK == beteg.BetegID
                                        select new
                                        {
                                            Állapot = a.AllapotID,
                                            Dátum = a.FDatum,
                                            Súlyosság = a.Sulyossag,
                                            Köhögés = a.Kohoges,
                                            Nehézlégzés = a.NehezLegzes,
                                            Láz = a.Laz,
                                            ÍzVesztés = a.IzVesztes
                                        }).ToList();
        }

        private void textBoxNev_TextChanged(object sender, EventArgs e)
        {
            listBoxNev.DataSource = (from i in context.Betegs
                                     where i.Nev.StartsWith(textBoxNev.Text)
                                     select i).ToList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
    }
}
