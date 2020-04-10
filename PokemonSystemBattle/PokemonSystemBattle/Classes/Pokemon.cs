using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSystemBattle
{
    public class Pokemon
    {
        //Attributi
        private string nome;
        private string pokedexID;
        private List<Tipo> tipo;
        private string descrizionePokedex;
        private Mossa[] mosse;
        private Statistiche statistiche;
        private List<Tipo> debolezze;
        private List<Tipo> dannoNormale;
        private List<Tipo> resistenze;
        private List<Tipo> immunita;
        private Strumento strumento;
        private int puntiSalute;
        private Image back;
        private Image front;
        public Pokemon(string nome, string pokedexId, List<Tipo> tipo, string descrizionePokedex, Mossa[] mosse, Statistiche statistiche, List<Tipo> debolezze, List<Tipo> dannoNormale, List<Tipo> resistenze, List<Tipo> immunita, Strumento strumento, int puntiSalute, Bitmap b, Bitmap f)
        {
            this.nome = nome;
            this.pokedexID = pokedexId;
            this.puntiSalute = puntiSalute;
            this.tipo = tipo;
            this.descrizionePokedex = descrizionePokedex;
            this.mosse = mosse;
            this.statistiche = statistiche;
            this.debolezze = debolezze;
            this.dannoNormale = dannoNormale;
            this.resistenze = resistenze;
            this.immunita = immunita;
            this.strumento = strumento;
            this.back = b;
            this.front = f;
        }

        public string Nome { get => nome; }
        public string PokedexID { get => pokedexID;}
        public List<Tipo> Tipo
        {
            get => tipo;
        }
        public string DescrizionePokedex
        {
            get => descrizionePokedex;
        }
        public Mossa[] Mosse
        {
            get => mosse;
        }
        public int PuntiSalute
        {
            get => puntiSalute;
            set => puntiSalute = value;
        }
        public Image Front
        {
            get => front;
            set => front = value;
        }
        public Image Back
        {
            get => back;
            set => back = value;
        }

        public List<Tipo> Debolezze
        {
            get => debolezze;
            set => debolezze = value;
        }

        public List<Tipo> Resistenze
        {
            get => resistenze;
            set => resistenze = value;
        }

        public List<Tipo> Immunita
        {
            get => immunita;
            set => immunita = value;
        }

        public List<Tipo> DannoNormale
        {
            get => dannoNormale;
            set => dannoNormale = value;
        }
    }
}
