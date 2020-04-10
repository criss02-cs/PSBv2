using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSystemBattle
{
    public class Statistiche
    {
        //Attributi
        private int velocita;
        private int attacco;
        private int difesa;
        private int attaccoSpeciale;
        private int difesaSpeciale;
        private int tot;

        public Statistiche(int v, int a, int d, int aS, int ds)
        {
            this.attacco = a;
            this.attaccoSpeciale = aS;
            this.difesa = d;
            this.difesaSpeciale = ds;
            this.velocita = v;
            tot = attacco + velocita + difesa + attaccoSpeciale + difesaSpeciale;
        }

        public int Velocita
        {
            get => velocita;
            set => velocita = value;
        }

        public int AttaccoSpeciale
        {
            get => attaccoSpeciale;
            set => attaccoSpeciale = value;
        }

        public int Attacco
        {
            get => attacco;
            set => attacco = value;
        }

        public int DifesaSpeciale
        {
            get => difesaSpeciale;
            set => difesaSpeciale = value;
        }

        public int Difesa
        {
            get => difesa;
            set => difesa = value;
        }


    }
}
