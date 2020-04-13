using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonSystemBattle.Forms
{
    public partial class Form5 : Form
    {
        private List<Pokemon> squadra;
        public Form5(List<Pokemon> squadra)
        {
            InitializeComponent();
            this.squadra = squadra;
            try
            {
                btnPrimo.Text = squadra[0].Nome;
                progressBar1.Value = squadra[0].PuntiSalute;
            }
            catch (ArgumentOutOfRangeException e)
            {
                
            }
        }
    }
}
