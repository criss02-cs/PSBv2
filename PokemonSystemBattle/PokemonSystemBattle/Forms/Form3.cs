using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using PokemonSystemBattle.Forms;
using Newtonsoft.Json;
using System.IO;

namespace PokemonSystemBattle
{
    public partial class Form3 : Form
    {
        //Attributi
        private List<Pokemon> squadra;      //Lista dei pokemon dell'utente
        private List<Pokemon> avversario;   //Lista dei pokemon del PC
        private SoundPlayer player;         //Oggetto per far partire l'ost
        private int myPokemon;              //Contatore pokemon attuale utente
        private int enemyPokemon;           //Contatore pokemon attuale PC
        private int rimasti;
        private int secondi;
        public Form3(Pokemon[] squadra, Pokemon[] avversario)
        {
            InitializeComponent();
            player = new SoundPlayer(PokemonSystemBattle.Properties.Resources.battleOst);
            this.squadra = squadra.ToList();
            this.avversario = avversario.ToList();
            myPokemon = 0;
            enemyPokemon = 0;
            rimasti = avversario.Length;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblNome.Text = squadra[myPokemon].Nome;
            lblAvversario.Text = avversario[enemyPokemon].Nome;
            progressAvversario.Maximum = avversario[enemyPokemon].PuntiSalute;
            progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
            progressSquadra.Maximum = squadra[myPokemon].PuntiSalute;
            progressSquadra.Value = squadra[myPokemon].PuntiSalute;
            txtLog.Text = "Che cosa vuoi fare?";
            player.PlayLooping();
            picPrimo.Image = squadra[myPokemon].Back;
            picPrimo.SizeMode = PictureBoxSizeMode.StretchImage;
            picSecondo.Image = avversario[enemyPokemon].Front;
            picSecondo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            if (btn1.Text.Equals("Lotta"))
            {
                btn1.Text = squadra[myPokemon].Mosse[0].Nome;
                btn2.Text = squadra[myPokemon].Mosse[1].Nome;
                btn3.Text = squadra[myPokemon].Mosse[2].Nome;
                btn4.Text = squadra[myPokemon].Mosse[3].Nome;
                txtLog.Text = "Che mossa vuoi usare?";
            }
            else
            {
                try
                {
                    txtLog.Text = squadra[myPokemon].Nome + " usa " + squadra[myPokemon].Mosse[0].Nome + "!\n";
                    if (avversario[enemyPokemon].Debolezze.Contains(squadra[myPokemon].Mosse[0].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[0].Potenza*2;
                        txtLog.Text = "É superefficace!\n";
                    }
                    else if (avversario[enemyPokemon].Resistenze.Contains(squadra[myPokemon].Mosse[0].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[0].Potenza / 2;
                        txtLog.Text = "Non è molto efficace!\n";
                    }
                    else if (avversario[enemyPokemon].Immunita.Contains(squadra[myPokemon].Mosse[0].Tipo))
                    {
                        txtLog.Text = avversario[enemyPokemon].Nome + " è immune!\n";
                    }
                    else
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[0].Potenza;
                    }
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    avversario[enemyPokemon].PuntiSalute = 0;
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                    ChangePokemon();
                }

                if (avversario[enemyPokemon].PuntiSalute == 0)
                {
                    txtLog.Text = avversario[enemyPokemon].Nome + " è esausto!\n";
                    foreach (var i in avversario)
                    {
                        if (i.PuntiSalute == 0)
                            rimasti--;
                    }

                    if (rimasti <= 0)
                    {
                        txtLog.Text = "Complimenti hai vinto!";
                        timer1.Start();
                    }
                }
                else
                    EnemyMove();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            if (btn4.Text.Equals("Esci"))
            {
                Application.Exit();
            }
            else
            {
                try
                {
                    txtLog.Text = squadra[myPokemon].Nome + " usa " + squadra[myPokemon].Mosse[3].Nome + "!\n";
                    if (avversario[enemyPokemon].Debolezze.Contains(squadra[myPokemon].Mosse[3].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[3].Potenza * 2;
                        txtLog.Text = "É superefficace!\n";
                    }
                    else if (avversario[enemyPokemon].Resistenze.Contains(squadra[myPokemon].Mosse[3].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[3].Potenza / 2;
                        txtLog.Text = "Non è molto efficace!\n";
                    }
                    else if (avversario[enemyPokemon].Immunita.Contains(squadra[myPokemon].Mosse[3].Tipo))
                    {
                        txtLog.Text = avversario[enemyPokemon].Nome + " è immune!\n";
                    }
                    else
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[3].Potenza;
                    }
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    avversario[enemyPokemon].PuntiSalute = 0;
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                    ChangePokemon();
                }

                if (avversario[enemyPokemon].PuntiSalute == 0)
                {
                    txtLog.Text = avversario[enemyPokemon].Nome + " è esausto!\n";
                    foreach (var i in avversario)
                    {
                        if (i.PuntiSalute == 0)
                            rimasti--;
                    }

                    if (rimasti <= 0)
                    {
                        txtLog.Text = "Complimenti hai vinto!";
                        timer1.Start();
                    }
                }
                else
                    EnemyMove();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            if (btn2.Text.Equals("Borsa"))
            {
                
            }
            else
            {
                try
                {
                    txtLog.Text = squadra[myPokemon].Nome + " usa " + squadra[myPokemon].Mosse[1].Nome + "!\n";
                    if (avversario[enemyPokemon].Debolezze.Contains(squadra[myPokemon].Mosse[1].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[1].Potenza * 2;
                        txtLog.Text = "É superefficace!\n";
                    }
                    else if (avversario[enemyPokemon].Resistenze.Contains(squadra[myPokemon].Mosse[1].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[1].Potenza / 2;
                        txtLog.Text = "Non è molto efficace!\n";
                    }
                    else if (avversario[enemyPokemon].Immunita.Contains(squadra[myPokemon].Mosse[1].Tipo))
                    {
                        txtLog.Text = avversario[enemyPokemon].Nome + " è immune!\n";
                    }
                    else
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[1].Potenza;
                    }
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    avversario[enemyPokemon].PuntiSalute = 0;
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                    ChangePokemon();
                }

                if (avversario[enemyPokemon].PuntiSalute == 0)
                {
                    txtLog.Text = avversario[enemyPokemon].Nome + " è esausto!\n";
                    foreach (var i in avversario)
                    {
                        if (i.PuntiSalute == 0)
                            rimasti--;
                    }
                    
                    if (rimasti <= 0)
                    {
                        txtLog.Text = "Complimenti hai vinto!";
                        timer1.Start();
                    }
                }
                else
                    EnemyMove();
            }
        }

        public void ChangePokemon()
        {
            using (Form5 frm = new Form5(squadra, myPokemon))
            {
                frm.ShowDialog(this);
                myPokemon = frm.Index;
                picPrimo.Image = squadra[myPokemon].Back;
                lblNome.Text = squadra[myPokemon].Nome;
                progressSquadra.Maximum = squadra[myPokemon].PuntiSalute;
                progressSquadra.Value = squadra[myPokemon].PuntiSalute;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            if (btn3.Text.Equals("Pokémon"))
            {
                ChangePokemon();
            }
            else
            {
                try
                {
                    txtLog.Text = squadra[myPokemon].Nome + " usa " + squadra[myPokemon].Mosse[2].Nome + "!\n";
                    if (avversario[enemyPokemon].Debolezze.Contains(squadra[myPokemon].Mosse[2].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[2].Potenza * 2;
                        txtLog.Text = "É superefficace!\n";
                    }
                    else if (avversario[enemyPokemon].Resistenze.Contains(squadra[myPokemon].Mosse[2].Tipo))
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[2].Potenza / 2;
                        txtLog.Text = "Non è molto efficace!\n";
                    }
                    else if (avversario[enemyPokemon].Immunita.Contains(squadra[myPokemon].Mosse[2].Tipo))
                    {
                        txtLog.Text = avversario[enemyPokemon].Nome + " è immune!\n";
                    }
                    else
                    {
                        avversario[enemyPokemon].PuntiSalute -= squadra[myPokemon].Mosse[2].Potenza;
                    }
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    avversario[enemyPokemon].PuntiSalute = 0;
                    progressAvversario.Value = avversario[enemyPokemon].PuntiSalute;
                    ChangePokemon();
                }

                if (avversario[enemyPokemon].PuntiSalute == 0)
                {
                    txtLog.Text = avversario[enemyPokemon].Nome + " è esausto!\n";
                    foreach (var i in avversario)
                    {
                        if (i.PuntiSalute == 0)
                            rimasti--;
                    }

                    if (rimasti <= 0)
                    {
                        txtLog.Text = "Complimenti hai vinto!";
                        timer1.Start();
                    }
                }
                else
                    EnemyMove();
            }
        }

        public void EnemyMove()
        {
            Random x = new Random();
            int move = x.Next(0, 4);
            try
            {
                txtLog.Text = avversario[enemyPokemon].Nome + " nemico usa " + avversario[enemyPokemon].Mosse[move].Nome + "!\n";
                if (squadra[myPokemon].Debolezze.Contains(avversario[enemyPokemon].Mosse[move].Tipo))
                {
                    squadra[myPokemon].PuntiSalute -= avversario[enemyPokemon].Mosse[move].Potenza * 2;
                    txtLog.Text = "É superefficace!\n";
                }
                else if (squadra[myPokemon].Resistenze.Contains(avversario[enemyPokemon].Mosse[move].Tipo))
                {
                    squadra[myPokemon].PuntiSalute -= avversario[enemyPokemon].Mosse[move].Potenza * 2;
                    txtLog.Text = "Non è molto efficace!\n";
                }
                else if(squadra[myPokemon].Immunita.Contains(avversario[enemyPokemon].Mosse[move].Tipo))
                {
                    txtLog.Text = avversario[enemyPokemon].Nome + " è immune\n";
                }
                else
                {
                    squadra[myPokemon].PuntiSalute -= avversario[enemyPokemon].Mosse[move].Potenza;
                }
                progressSquadra.Value = squadra[myPokemon].PuntiSalute;
            }
            catch (ArgumentOutOfRangeException e)
            {
                squadra[myPokemon].PuntiSalute = 0;
                progressSquadra.Value = squadra[myPokemon].PuntiSalute;
            }

            if (squadra[myPokemon].PuntiSalute == 0)
            {
                txtLog.Text = squadra[myPokemon].Nome + " è esausto!\n";
                ChangePokemon();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondi++;
            if (secondi == 5)
            {
                Application.Exit();
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Vuoi salvare la tua squadra?", "Salvataggio della squadra", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string file = JsonConvert.SerializeObject(myPokemon);
                if (File.Exists("squadra.txt"))
                    File.Create("squadra.txt");
                File.WriteAllText("squadra.txt", file);
                MessageBox.Show("Salvataggio completato!");
            }
        }
    }
}
