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
        Button[] btn = new Button[6];
        ProgressBar[] progress = new ProgressBar[6];
        private int index;
        public Form5(List<Pokemon> squadra, int index)
        {
            InitializeComponent();
            this.squadra = squadra;
            //Inizializzo un array di bottoni
            btn[0] = btnPrimo;
            btn[1] = btnSecondo;
            btn[2] = btnTerzo;
            btn[3] = btnQuarto;
            btn[4] = btnQuinto;
            btn[5] = btnSesto;
            //Inizializzo un array di progress bar
            progress[0] = progressBar1;
            progress[1] = progressBar2;
            progress[2] = progressBar3;
            progress[3] = progressBar4;
            progress[4] = progressBar5;
            progress[5] = progressBar6;
            for (int i = 0; i < squadra.Count; i++)
            {
                btn[i].Text = squadra[i].Nome;
                progress[i].Maximum = squadra[i].PuntiSalute;
                progress[i].Value = squadra[i].PuntiSalute;
                if (squadra[i].PuntiSalute == 0)
                {
                    btn[i].BackColor = Color.Red;
                }
                else
                {
                    btn[i].BackColor = Color.Green;
                }
            }
            switch (squadra.Count)
            {
                case 1:
                    btnSecondo.Visible = false;
                    btnTerzo.Visible = false;
                    btnQuarto.Visible = false;
                    btnQuinto.Visible = false;
                    btnSesto.Visible = false;
                    progressBar2.Visible = false;
                    progressBar3.Visible = false;
                    progressBar4.Visible = false;
                    progressBar5.Visible = false;
                    progressBar6.Visible = false;
                    break;
                case 2:
                    btnTerzo.Visible = false;
                    btnQuarto.Visible = false;
                    btnQuinto.Visible = false;
                    btnSesto.Visible = false;
                    progressBar3.Visible = false;
                    progressBar4.Visible = false;
                    progressBar5.Visible = false;
                    progressBar6.Visible = false;
                    break;
                case 3:
                    btnQuarto.Visible = false;
                    btnQuinto.Visible = false;
                    btnSesto.Visible = false;
                    progressBar4.Visible = false;
                    progressBar5.Visible = false;
                    progressBar6.Visible = false;
                    break;
                case 4:
                    btnQuinto.Visible = false;
                    btnSesto.Visible = false;
                    progressBar5.Visible = false;
                    progressBar6.Visible = false;
                    break;
                case 5:
                    btnSesto.Visible = false;
                    progressBar6.Visible = false;
                    break;
            }
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {

        }
    }
}
