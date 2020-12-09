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
    public partial class Kezdolap : Form
    {
        public Kezdolap()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        String[] Users = { "User1", "User2", "User3" };
        String[] Passwords = { "1111", "2222", "3333" };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Users.Contains(txtUser.Text) && Passwords.Contains(txtPass.Text) && Array.IndexOf(Users, txtUser.Text) == Array.IndexOf(Passwords, txtPass.Text))
            {
                Bejelentkezes ke = new Bejelentkezes();
                ke.ShowDialog();         
            }
            else
            {
                MessageBox.Show("Rossz felhasználónév vagy jelszó!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrompt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felhasználónév és jelszó beírása után kattintson a bejelelntkezés gombra a program eléréséhez!");
        }
    }
}
