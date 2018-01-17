using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_Hibabejelento_14S
{
    public partial class Form1 : Form
    {

        String nev;
        DateTime datum;
        String leiras;
        List<Hiba> Hibak = new List<Hiba>();

        public Form1()
        {
            InitializeComponent();
        }

        class Hiba {
            String nev;
            DateTime datum;
            String leiras;

            public Hiba(String nev, DateTime datum, String leiras) {
                this.nev = nev;
                this.datum = datum;
                this.leiras = leiras;
            }

        }

        private void hibabejelento_nevTB_TextChanged(object sender, EventArgs e)
        {
            this.nev = hibabejelento_nevTB.Text;
        }

        private void hibabejelento_datumTB_ValueChanged(object sender, EventArgs e)
        {
            this.datum = hibabejelento_datumTB.Value;
        }

        private void hibabejelento_leirasTB_TextChanged(object sender, EventArgs e)
        {
            this.leiras = hibabejelento_leirasTB.Text;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            
            if (hibabejelento_nevTB.Text == String.Empty && hibabejelento_datumTB.Text == String.Empty && hibabejelento_leirasTB.Text == String.Empty) {
                MessageBox.Show("Nem töltött ki minden adatot!", "Hiba!");
            }
            else {
                Hiba hibajelentes = new Hiba(nev, datum, leiras);
                Hibak.Add(hibajelentes);

                hibabejelento_nevTB.Text = String.Empty;
                hibabejelento_datumTB.Text = String.Empty;
                hibabejelento_leirasTB.Text = String.Empty;
            }
        }
    }
}
