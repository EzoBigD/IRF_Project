using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Tracker
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();
        }

        private void Bejelentkezes_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;

            AgyakTermekUC At = new AgyakTermekUC();
            panel1.Controls.Add(At);

            labelFelhaszn.Text = Felhasznalo.felhaszn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDay.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgyakTermek_Click(object sender, EventArgs e)
        {
            AgyakTermekUC At = new AgyakTermekUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(At);
        }

        private void btnBetegek_Click(object sender, EventArgs e)
        {
            BetegekUC be = new BetegekUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(be);
        }

        private void btnBeosztas_Click(object sender, EventArgs e)
        {
            BeosztasUC bo = new BeosztasUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(bo);
        }

        private void btnAllapot_Click(object sender, EventArgs e)
        {
            AllapotUC bo = new AllapotUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(bo);
        }
    }
}
