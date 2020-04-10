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
    public partial class Form4 : Form
    {
        private Pokedex p = new Pokedex();
        private List<Pokemon> squadra;
        private List<Pokemon> avversario;
        public Form4()
        {
            InitializeComponent();
            squadra = new List<Pokemon>();
            avversario = new List<Pokemon>();
            //Inserisco tutti i pokemon all'interno della combo box
            foreach (var e in p.Pokedex_)
            {
                cmbPokemon.Items.Add(e.Nome);
            }
            lstSquadra.Items.Clear();
            avversario.Add(p.Pokedex_[2]);
        }
        private void cmbPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSquadra.Items.Add(cmbPokemon.SelectedItem.ToString());
            foreach (var i in p.Pokedex_)
            {
                if(i.Nome == cmbPokemon.SelectedItem.ToString())
                    squadra.Add(i);
            }
        }
        public List<Pokemon> Squadra
        {
            get => squadra;
            set => squadra = value;
        }
        public List<Pokemon> Avversario
        {
            get => avversario;
            set => avversario = value;
        }
        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
