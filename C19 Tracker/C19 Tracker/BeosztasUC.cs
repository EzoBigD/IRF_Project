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
    public partial class BeosztasUC : UserControl
    {
        CoronaTracker_DBEntities context = new CoronaTracker_DBEntities();
        public BeosztasUC()
        {
            InitializeComponent();

            context.Orvos.Load();
            context.Beosztas.Load();

            listBoxOrvos.DisplayMember = "OrvosNev";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BeosztasUC_Load(object sender, EventArgs e)
        {

            var or = from a in context.Orvos
                     select a;
            listBoxOrvos.DataSource = or.ToList();            
        }      

        private void textBoxOrvos_TextChanged(object sender, EventArgs e)
        {
            listBoxOrvos.DataSource = (from i in context.Orvos
                                       where i.OrvosNev.StartsWith(textBoxOrvos.Text)
                                       select i).ToList();
        }

        private void listBoxOrvos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orvo orvo = (Orvo)((ListBox)sender).SelectedItem;

            dataGridView1.DataSource = (from b in context.Beosztas
                                        join o in context.Orvos
                                        on b.OrvosFK equals o.OrvosID
                                        where b.OrvosFK == orvo.OrvosID
                                        select new
                                        {
                                            b.Műszak
                                        }).ToList();
        }
    }
}
