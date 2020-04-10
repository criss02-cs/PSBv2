using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonSystemBattle.Forms;
using SplashScreen;

namespace PokemonSystemBattle
{
    public partial class Form1 : Form
    {
        //Attributi
        private Pokemon[] squadra = new Pokemon[6];
        private Pokemon[] avversario = new Pokemon[6];
        private SoundPlayer player;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            string str = string.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString();
            }
            t.Abort();
            player = new SoundPlayer(PokemonSystemBattle.Properties.Resources.ost);
        }

        private void Splash()
        {
            SplashForm frm = new SplashForm();
            frm.AppName = Application.ProductName;
            frm.Icon = PokemonSystemBattle.Properties.Resources.Poke_Ball1;
            frm.ShowInTaskbar = true;
            frm.ShowIcon = true;
            Application.Run(frm);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            player.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*Form2 frm = new Form2();
            frm.ShowDialog();
            this.Close();*/
            MessageBox.Show("Questa parte è ancora in sviluppo");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (Form4 frm = new Form4())
            {
                frm.ShowDialog();
                squadra = frm.Squadra.ToArray();
                avversario = frm.Avversario.ToArray();
            }
            Form3 frm3 = new Form3(squadra, avversario);
            frm3.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
        }
    }
}
