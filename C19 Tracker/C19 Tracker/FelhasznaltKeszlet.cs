using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Tracker
{
    class FelhasznaltKeszlet
    {
        public void Felhasznalt (DataGridView dgw2)
        {
            dgw2.ColumnCount = 3;

            dgw2.Columns[0].Name = "Nev";
            dgw2.Columns[1].Name = "Mennyiseg";
            dgw2.Columns[2].Name = "Datum";

            dgw2.Columns[0].HeaderText = "Gyógyszer neve";
            dgw2.Columns[1].HeaderText = "Felhasznált mennyiség";
            dgw2.Columns[2].HeaderText = "Feljegyzés dátuma";

            dgw2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
