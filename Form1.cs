using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuisBerekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float BerekenOppervlakte(float lengte, float breedte)
        {
            return lengte * breedte;
        }

        private float BerekenTotaleOppervlakte(float lengte, float breedte, int verdiepingen)
        {
            return lengte * breedte * verdiepingen;
        }

        private float BerekenInhoud(float lengte, float breedte, float hoogte)
        {
            return lengte * breedte * hoogte;
        }

        private float BerekenTotaleInhoud(float lengte, float breedte, float hoogte, int verdiepingen)
        {
            return (lengte * breedte * hoogte) * verdiepingen;
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultaatOppervlakte.Text = BerekenOppervlakte(float.Parse(txbLengte.Text), float.Parse(txbBreedte.Text)).ToString();
                lblResultaatTotaleOppervlakte.Text = BerekenTotaleOppervlakte(float.Parse(txbLengte.Text), float.Parse(txbBreedte.Text), int.Parse(txbVerdiepingen.Text)).ToString();
                lblResultaatInhoud.Text = BerekenInhoud(float.Parse(txbLengte.Text), float.Parse(txbBreedte.Text), float.Parse(txbHoogte.Text)).ToString();
                lblResultaatTotaleInhoud.Text = BerekenTotaleInhoud(float.Parse(txbLengte.Text), float.Parse(txbBreedte.Text), float.Parse(txbHoogte.Text), int.Parse(txbVerdiepingen.Text)).ToString();
            } catch (Exception exception) {
                MessageBox.Show("Er is een fout opgetreden. De melding is: " + exception.Message);
            } }
            
        } 


}
