using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Tracker
{
    public partial class KeszletUC : UserControl
    {
        public KeszletUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void KeszletUC_Load(object sender, EventArgs e)
        {
            ErkezettKeszlet ErkezettDgv = new ErkezettKeszlet();
            ErkezettDgv.Erkezett(dataGridView1);

            FelhasznaltKeszlet FelhasznaltDgv = new FelhasznaltKeszlet();
            FelhasznaltDgv.Felhasznalt(dataGridView2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                KeszletUC_Load(sender, e);
            }

            dataGridView1.Rows.Add(textBoxNevE.Text.ToString(), textBoxMennyisegE.Text.ToString(), textBoxDatumE.Text.ToString());

            dataGridView1.Refresh();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                KeszletUC_Load(sender, e);
            }

            dataGridView2.Rows.Add(textBoxNevF.Text.ToString(), textBoxMennyisegF.Text.ToString(), textBoxDatumF.Text.ToString());

            dataGridView2.Refresh();
        }
    }
}
