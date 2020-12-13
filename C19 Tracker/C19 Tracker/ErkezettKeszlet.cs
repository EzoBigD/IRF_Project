using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Tracker
{
    class ErkezettKeszlet
    {
        public void Erkezett (DataGridView dgw1)
        {
            dgw1.ColumnCount = 3;

            dgw1.Columns[0].Name = "Nev";
            dgw1.Columns[1].Name = "Mennyiseg";
            dgw1.Columns[2].Name = "Datum";

            dgw1.Columns[0].HeaderText = "Gyógyszer neve";
            dgw1.Columns[1].HeaderText = "Beérkezett mennyiség";
            dgw1.Columns[2].HeaderText = "Feljegyzés dátuma";

            dgw1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
