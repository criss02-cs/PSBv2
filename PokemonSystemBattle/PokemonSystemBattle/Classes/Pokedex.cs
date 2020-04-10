﻿using PokemonSystemBattle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSystemBattle
{
    public class Pokedex
    {
        //Attributi
        private List<Pokemon> pokedex = new List<Pokemon>();
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
        private Pokemon pokemon;
        private Bitmap front;
        private Bitmap back;
        //Property
        public List<Pokemon> Pokedex_
        {
            get => pokedex;
        }

        public Pokedex()
        {
            tipo = new List<Tipo>();
            mosse = new Mossa[4];
            debolezze = new List<Tipo>();
            dannoNormale = new List<Tipo>();
            resistenze = new List<Tipo>();
            immunita = new List<Tipo>();
            //Bulbasaur
            nome = "Bulbasaur";
            pokedexID = "001";
            tipo.Add(Tipo.ERBA);
            tipo.Add(Tipo.VELENO);
            descrizionePokedex = "Fin dalla nascita questo Pokémon ha sulla schiena un seme che cresce lentamente.";
            mosse[0] = new Mossa("Foglielama", 25, Tipo.ERBA, 95, 55);
            mosse[1] = new Mossa("Semebomba", 15, Tipo.ERBA, 100, 80);
            mosse[2] = new Mossa("Solarraggio", 10, Tipo.ERBA, 100, 120);
            mosse[3] = new Mossa("Sintesi", 5, Tipo.ERBA, 0, 0);
            statistiche = new Statistiche(207, 216, 216, 251, 25);
            debolezze.Add(Tipo.FUOCO);
            debolezze.Add(Tipo.GHIACCIO);
            debolezze.Add(Tipo.PSICO);
            debolezze.Add(Tipo.VOLANTE);
            dannoNormale.Add(Tipo.ACCIAIO);
            dannoNormale.Add(Tipo.BUIO);
            dannoNormale.Add(Tipo.COLEOTTERO);
            dannoNormale.Add(Tipo.DRAGO);
            dannoNormale.Add(Tipo.NORMALE);
            dannoNormale.Add(Tipo.ROCCIA);
            dannoNormale.Add(Tipo.SPETTRO);
            dannoNormale.Add(Tipo.TERRA);
            dannoNormale.Add(Tipo.VELENO);
            resistenze.Add(Tipo.ACQUA);
            resistenze.Add(Tipo.ELETTRO);
            resistenze.Add(Tipo.FOLLETTO);
            resistenze.Add(Tipo.LOTTA);
            resistenze.Add(Tipo.ERBA);
            puntiSalute = 294;
            front = PokemonSystemBattle.Properties.Resources._001;
            back = PokemonSystemBattle.Properties.Resources._001b;
            pokemon = new Pokemon(nome, pokedexID, tipo, descrizionePokedex, mosse, statistiche, debolezze, dannoNormale, resistenze, immunita, strumento, puntiSalute, back, front);
            pokedex.Add(pokemon);
            //Ivysaur
            debolezze = new List<Tipo>();
            dannoNormale = new List<Tipo>();
            resistenze = new List<Tipo>();
            immunita = new List<Tipo>();
            nome = "Ivysaur";
            pokedexID = "002";
            tipo.Clear();
            tipo.Add(Tipo.ERBA);
            tipo.Add(Tipo.VELENO);
            descrizionePokedex = "Il bulbo sulla schiena è cresciuto così tanto da impedirgli di alzarsi in piedi sulle zampe posteriori.";
            mosse = new Mossa[4];
            mosse[0] = new Mossa("Foglielama", 25, Tipo.ERBA, 95, 55);
            mosse[1] = new Mossa("Sdoppiatore", 15, Tipo.NORMALE, 100, 120);
            mosse[2] = new Mossa("Solarraggio", 10, Tipo.ERBA, 100, 120);
            mosse[3] = new Mossa("Sintesi", 5, Tipo.ERBA, 0, 0);
            statistiche = new Statistiche(240, 245, 247, 284, 284);
            debolezze.Clear();
            debolezze.Add(Tipo.FUOCO);
            debolezze.Add(Tipo.GHIACCIO);
            debolezze.Add(Tipo.PSICO);
            debolezze.Add(Tipo.VOLANTE);
            dannoNormale.Clear();
            dannoNormale.Add(Tipo.ACCIAIO);
            dannoNormale.Add(Tipo.BUIO);
            dannoNormale.Add(Tipo.COLEOTTERO);
            dannoNormale.Add(Tipo.DRAGO);
            dannoNormale.Add(Tipo.NORMALE);
            dannoNormale.Add(Tipo.ROCCIA);
            dannoNormale.Add(Tipo.SPETTRO);
            dannoNormale.Add(Tipo.TERRA);
            dannoNormale.Add(Tipo.VELENO);
            resistenze.Clear();
            resistenze.Add(Tipo.ACQUA);
            resistenze.Add(Tipo.ELETTRO);
            resistenze.Add(Tipo.FOLLETTO);
            resistenze.Add(Tipo.LOTTA);
            resistenze.Add(Tipo.ERBA);
            puntiSalute = 324;
            front = PokemonSystemBattle.Properties.Resources._002;
            back = PokemonSystemBattle.Properties.Resources._002b;
            pokemon = new Pokemon(nome, pokedexID, tipo, descrizionePokedex, mosse, statistiche, debolezze, dannoNormale, resistenze, immunita, strumento, puntiSalute, back, front);
            pokedex.Add(pokemon);
            //Venusaur
            debolezze = new List<Tipo>();
            dannoNormale = new List<Tipo>();
            resistenze = new List<Tipo>();
            immunita = new List<Tipo>();
            nome = "Venusaur";
            pokedexID = "003";
            tipo.Clear();
            tipo.Add(Tipo.ERBA);
            tipo.Add(Tipo.VELENO);
            descrizionePokedex = "Il suo fiore emana una fragranza inebriante capace di placare l’animo di chi è impegnato nella lotta.";
            mosse = new Mossa[4];
            mosse[0] = new Mossa("Fiortempesta", 15, Tipo.ERBA, 100, 90);
            mosse[1] = new Mossa("Petalodanza", 10, Tipo.ERBA, 100, 120);
            mosse[2] = new Mossa("Solarraggio", 10, Tipo.ERBA, 100, 120);
            mosse[3] = new Mossa("Sintesi", 5, Tipo.ERBA, 0, 0);
            statistiche = new Statistiche(284, 289, 291, 328, 328);
            debolezze.Clear();
            debolezze.Add(Tipo.FUOCO);
            debolezze.Add(Tipo.GHIACCIO);
            debolezze.Add(Tipo.PSICO);
            debolezze.Add(Tipo.VOLANTE);
            dannoNormale.Clear();
            dannoNormale.Add(Tipo.ACCIAIO);
            dannoNormale.Add(Tipo.BUIO);
            dannoNormale.Add(Tipo.COLEOTTERO);
            dannoNormale.Add(Tipo.DRAGO);
            dannoNormale.Add(Tipo.NORMALE);
            dannoNormale.Add(Tipo.ROCCIA);
            dannoNormale.Add(Tipo.SPETTRO);
            dannoNormale.Add(Tipo.TERRA);
            dannoNormale.Add(Tipo.VELENO);
            resistenze.Clear();
            resistenze.Add(Tipo.ACQUA);
            resistenze.Add(Tipo.ELETTRO);
            resistenze.Add(Tipo.FOLLETTO);
            resistenze.Add(Tipo.LOTTA);
            resistenze.Add(Tipo.ERBA);
            puntiSalute = 364;
            front = PokemonSystemBattle.Properties.Resources._003;
            back = PokemonSystemBattle.Properties.Resources._003b;
            pokemon = new Pokemon(nome, pokedexID, tipo, descrizionePokedex, mosse, statistiche, debolezze, dannoNormale, resistenze, immunita, strumento, puntiSalute, back, front);
            pokedex.Add(pokemon);
            //Charmander
            debolezze = new List<Tipo>();
            dannoNormale = new List<Tipo>();
            resistenze = new List<Tipo>();
            immunita = new List<Tipo>();
            nome = "Charmander";
            pokedexID = "004";
            tipo.Clear();
            tipo.Add(Tipo.FUOCO);
            descrizionePokedex = "Una fiamma gli arde sulla punta della coda fin dalla nascita. Se si spegnesse, per lui sarebbe la fine.";
            mosse = new Mossa[4];
            mosse[0] = new Mossa("Braciere", 25, Tipo.FUOCO, 100, 40);
            mosse[1] = new Mossa("Dragospiro", 20, Tipo.DRAGO, 100, 60);
            mosse[2] = new Mossa("Rogodenti", 15, Tipo.FUOCO, 95, 65);
            mosse[3] = new Mossa("Lanciafiamme", 15, Tipo.FUOCO, 100, 90);
            statistiche = new Statistiche(251, 223, 203, 240, 218);
            debolezze.Clear();
            debolezze.Add(Tipo.ACQUA);
            debolezze.Add(Tipo.ROCCIA);
            debolezze.Add(Tipo.TERRA);
            dannoNormale.Clear();
            dannoNormale.Add(Tipo.BUIO);
            dannoNormale.Add(Tipo.DRAGO);
            dannoNormale.Add(Tipo.NORMALE);
            dannoNormale.Add(Tipo.ROCCIA);
            dannoNormale.Add(Tipo.SPETTRO);
            dannoNormale.Add(Tipo.VOLANTE);
            dannoNormale.Add(Tipo.VELENO);
            resistenze.Clear();
            resistenze.Add(Tipo.GHIACCIO);
            resistenze.Add(Tipo.ACCIAIO);
            resistenze.Add(Tipo.COLEOTTERO);
            resistenze.Add(Tipo.FOLLETTO);
            resistenze.Add(Tipo.FUOCO);
            resistenze.Add(Tipo.ERBA);
            puntiSalute = 282;
            front = PokemonSystemBattle.Properties.Resources._004;
            back = PokemonSystemBattle.Properties.Resources._004b;
            pokemon = new Pokemon(nome, pokedexID, tipo, descrizionePokedex, mosse, statistiche, debolezze, dannoNormale, resistenze, immunita, strumento, puntiSalute, back, front);
            pokedex.Add(pokemon);
            //Charmeleon
            debolezze = new List<Tipo>();
            dannoNormale = new List<Tipo>();
            resistenze = new List<Tipo>();
            immunita = new List<Tipo>();
            nome = "Charmeleon";
            pokedexID = "005";
            tipo.Clear();
            tipo.Add(Tipo.FUOCO);
            descrizionePokedex = "Ha un’indole feroce. Usa la coda fiammeggiante come una frusta e lacera l’avversario con gli artigli affilati.";
            mosse = new Mossa[4];
            mosse[0] = new Mossa("Braciere", 25, Tipo.FUOCO, 100, 40);
            mosse[1] = new Mossa("Dragospiro", 20, Tipo.DRAGO, 100, 60);
            mosse[2] = new Mossa("Marchiatura", 5, Tipo.FUOCO, 50, 100);
            mosse[3] = new Mossa("Lanciafiamme", 15, Tipo.FUOCO, 100, 90);
            statistiche = new Statistiche(284, 249, 236, 284, 251);
            debolezze.Clear();
            debolezze.Add(Tipo.ACQUA);
            debolezze.Add(Tipo.ROCCIA);
            debolezze.Add(Tipo.TERRA);
            dannoNormale.Clear();
            dannoNormale.Add(Tipo.BUIO);
            dannoNormale.Add(Tipo.DRAGO);
            dannoNormale.Add(Tipo.NORMALE);
            dannoNormale.Add(Tipo.ROCCIA);
            dannoNormale.Add(Tipo.SPETTRO);
            dannoNormale.Add(Tipo.VOLANTE);
            dannoNormale.Add(Tipo.VELENO);
            dannoNormale.Add(Tipo.ELETTRO);
            resistenze.Clear();
            resistenze.Add(Tipo.GHIACCIO);
            resistenze.Add(Tipo.ACCIAIO);
            resistenze.Add(Tipo.COLEOTTERO);
            resistenze.Add(Tipo.FOLLETTO);
            resistenze.Add(Tipo.FUOCO);
            resistenze.Add(Tipo.ERBA);
            puntiSalute = 320;
            front = PokemonSystemBattle.Properties.Resources._005;
            back = PokemonSystemBattle.Properties.Resources._005b;
            pokemon = new Pokemon(nome, pokedexID, tipo, descrizionePokedex, mosse, statistiche, debolezze, dannoNormale, resistenze, immunita, strumento, puntiSalute, back, front);
            pokedex.Add(pokemon);
            //Charizard
            debolezze = new List<Tipo>();
            dannoNormale = new List<Tipo>();
            resistenze = new List<Tipo>();
            immunita = new List<Tipo>();
            nome = "Charizard";
            pokedexID = "006";
            tipo.Clear();
            tipo.Add(Tipo.FUOCO);
            tipo.Add(Tipo.VOLANTE);
            descrizionePokedex = "Grazie alle possenti ali può volare fino a 1.400 m d’altezza. Le fiamme che sputa possono raggiungere temperature altissime.";
            mosse = new Mossa[4];
            mosse[0] = new Mossa("Braciere", 25, Tipo.FUOCO, 100, 40);
            mosse[1] = new Mossa("Dragospiro", 20, Tipo.DRAGO, 100, 60);
            mosse[2] = new Mossa("Tifone", 10, Tipo.VOLANTE, 70, 110);
            mosse[3] = new Mossa("Lanciafiamme", 15, Tipo.FUOCO, 100, 90);
            statistiche = new Statistiche(295, 293, 280, 348, 295);
            debolezze.Clear();
            debolezze.Add(Tipo.ACQUA);
            debolezze.Add(Tipo.ROCCIA);
            debolezze.Add(Tipo.ELETTRO);
            dannoNormale.Clear();
            dannoNormale.Add(Tipo.BUIO);
            dannoNormale.Add(Tipo.DRAGO);
            dannoNormale.Add(Tipo.NORMALE);
            dannoNormale.Add(Tipo.ROCCIA);
            dannoNormale.Add(Tipo.SPETTRO);
            dannoNormale.Add(Tipo.VOLANTE);
            dannoNormale.Add(Tipo.VELENO);
            resistenze.Clear();
            resistenze.Add(Tipo.GHIACCIO);
            resistenze.Add(Tipo.ACCIAIO);
            resistenze.Add(Tipo.COLEOTTERO);
            resistenze.Add(Tipo.FOLLETTO);
            resistenze.Add(Tipo.FUOCO);
            resistenze.Add(Tipo.ERBA);
            immunita.Clear();
            immunita.Add(Tipo.TERRA);
            puntiSalute = 360;
            front = PokemonSystemBattle.Properties.Resources._006;
            back = PokemonSystemBattle.Properties.Resources._006b;
            pokemon = new Pokemon(nome, pokedexID, tipo, descrizionePokedex, mosse, statistiche, debolezze, dannoNormale, resistenze, immunita, strumento, puntiSalute, back, front);
            pokedex.Add(pokemon);
        }

    }
}
