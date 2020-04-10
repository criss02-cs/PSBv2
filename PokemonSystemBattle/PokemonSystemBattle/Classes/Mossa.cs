using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSystemBattle
{
    public class Mossa
    {
        //Attributi
        private string nome;
        private int pp;
        private Tipo tipo;
        private int precisione;
        private int potenza;

        public Mossa(string nome, int pp, Tipo tipo, int precisione, int potenza)
        {
            this.nome = nome;
            this.pp = pp;
            this.tipo = tipo;
            this.precisione = precisione;
            this.potenza = potenza;
        }

        public int Punti { get => pp; }
        public Tipo Tipo
        {
            get => tipo;
        }
        public int Potenza
        {
            get => potenza;
        }
        public string Nome { get => nome; }
    }
}
