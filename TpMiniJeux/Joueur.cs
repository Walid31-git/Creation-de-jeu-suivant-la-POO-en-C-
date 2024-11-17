using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMiniJeux
{
    internal class Joueur
    {
        public string NomJoueur;
        public int PointDeVie = 100;
        public int ResultatDe;
        public int compteurMonstre1=0;
        public int compteurMonstre2=0;

        public string NomJoueur1 { get => NomJoueur; set => NomJoueur = value; }

        public Joueur(String NomJoueur) 
        { 
            this.NomJoueur = NomJoueur;
        }

        // ---------------------------------------
        public int EstVivant(int PointDeVie)
        {
            return PointDeVie;
        }
        public void JeterDe()
        {
            De joueurDe = new De();
            joueurDe.LancerDe();
            ResultatDe = joueurDe.ResultatDe;
        }
    }
}
