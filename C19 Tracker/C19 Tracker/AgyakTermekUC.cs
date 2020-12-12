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
    public partial class AgyakTermekUC : UserControl
    {
        CoronaTracker_DBEntities context = new CoronaTracker_DBEntities();
        public AgyakTermekUC()
        {
            InitializeComponent();

            context.Terems.Load();
            context.Agies.Load();
        }

        private void AgyakTermekUC_Load(object sender, EventArgs e)
        {            

            dataGridView1.DataSource = (from a in context.Agies
                                        join t in context.Terems
                                        on a.TeremFK equals t.TeremID
                                        where a.Foglalt == false
                                        select new
                                        {
                                            Ágy = a.AgyID,
                                            Terem = a.TeremFK,
                                            Típus = t.TeremTipus,

                                        }).ToList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DataSource = (from a in context.Agies
                                        join b in context.Betegs
                                        on a.JelenlegiBetegFK equals b.BetegID
                                        join t in context.Terems
                                        on a.TeremFK equals t.TeremID

                                        select new
                                        {
                                            Ágy = a.AgyID,
                                            Terem = t.TeremID,
                                            Típus = t.TeremTipus,
                                            Név = b.Nev
                                        }).ToList();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                         
            var ag = from x in context.Agies
                     select x;
            agyBindingSource.DataSource = ag.ToList();

            var AgyID = from a in context.Agies
                      select a;
            comboBoxAgy.DataSource = AgyID.ToList();

            comboBoxAgy.DisplayMember = "AgyID";

            var nev = from a in context.Betegs
                      select a;
            comboBoxNev.DataSource = nev.ToList();

            comboBoxNev.DisplayMember = "Nev";

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var ag1 = from x in context.Agies
                     select x;
            agyBindingSource1.DataSource = ag1.ToList();

            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnElhelyez_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                dataGridView1.Refresh();
                dataGridView2.Refresh();
                dataGridView3.Refresh(); 
                dataGridView4.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxNev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beteg be = (Beteg)((ComboBox)sender).SelectedItem;

            var id = (from b in context.Betegs
                      where b.Nev == be.Nev
                      select b.BetegID
                           );

            lblID.Text = id.First().ToString();
        }

        private void comboBoxAgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Agy agy = (Agy)((ComboBox)sender).SelectedItem;

            dataGridView3.DataSource = (from a in context.Agies
                                        where a.AgyID == agy.AgyID
                                        select new
                                        {
                                            AgyID = a.AgyID,
                                            TeremFK = a.TeremFK,
                                            Foglalt = a.Foglalt,
                                            JelenlegiBetegFK = a.JelenlegiBetegFK
                                        }).ToList();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
