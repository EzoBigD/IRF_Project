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
    public partial class BetegekUC : UserControl
    {
        CoronaTracker_DBEntities context = new CoronaTracker_DBEntities();
        public BetegekUC()
        {
            InitializeComponent();
        }

        private void BetegekUC_Load(object sender, EventArgs e)
        {
            context.Betegs.Load();
            var be = from x in context.Betegs
                     select x;
            betegBindingSource.DataSource = be.ToList();
        }
    }
}
