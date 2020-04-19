using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonSystemBattle.Forms
{
    public partial class Form5 : Form
    {
        private List<Pokemon> squadra;
        Button[] btn = new Button[6];
        ProgressBar[] progress = new ProgressBar[6];
        private int index;
        public int Index { get => index; set => index = value; }
        public Form5(List<Pokemon> squadra, int index)
        {
            InitializeComponent();
            this.squadra = squadra;
            this.index = index;
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
            Scegli(0);
        }

        private void Scegli(int pos)
        {
            if (squadra[pos].PuntiSalute == 0)
            {
                MessageBox.Show("Il pokemon non è in grado di combattere");
            }
            else if(pos != index)
            {
                if (MessageBox.Show("Sei sicuro di voler mandare in campo questo pokemon?", "Conferma il Pokemon",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    index = pos;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Il pokemon selezionato è già in campo");
            }
        }

        private void btnSecondo_Click(object sender, EventArgs e)
        {
            Scegli(1);
        }

        private void btnTerzo_Click(object sender, EventArgs e)
        {
            Scegli(2);
        }

        private void btnQuarto_Click(object sender, EventArgs e)
        {
            Scegli(3);
        }

        private void btnQuinto_Click(object sender, EventArgs e)
        {
            Scegli(4);
        }

        private void btnSesto_Click(object sender, EventArgs e)
        {
            Scegli(5);
        }
    }
}
