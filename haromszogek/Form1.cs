using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haromszogek
{
    public partial class frmFo : Form
    {
        private int aOldal;
        private int bOldal;
        private int cOldal;
        public frmFo()
        {
            aOldal = 0;
            bOldal = 0;
            cOldal = 0;
            InitializeComponent();
            tbAoldal.Text= aOldal.ToString();
            tbBoldal.Text = bOldal.ToString();
            tbColdal.Text = cOldal.ToString();
            lbHaromszogLista.Items.Clear();
        }



        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            aOldal = int.Parse(tbAoldal.Text);
            bOldal = int.Parse(tbBoldal.Text);
            cOldal = int.Parse(tbColdal.Text);

            if (aOldal == 0 || bOldal==0 || cOldal==0)
            {
                MessageBox.Show("Nem lehet 0 a háromszög oldala","Figyelmeztetés",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var h = new Haromszog(aOldal,bOldal,cOldal);
                List<string> adatok = h.AdatokSzoveg();
                foreach (var a in adatok)
                {
                    lbHaromszogLista.Items.Add(a);
                }


            }
            

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHaromszogLista.Items.Count >0)
            {
                lbHaromszogLista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs mit törölni");
            }
        }
    }
}
