using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMiniJeux
{
    internal class MonstreNiveau1
    {
        private int  degatGen;
        private bool estVivant= true;

        
        public virtual void Attaquer(Joueur player)
        {
            do {
                if (estVivant == true)
                {
                    De monstreDe = new De();
                    monstreDe.LancerDe();
                    int resultatDeMonstre = monstreDe.ResultatDe;
                    int resultatDeJoueur = player.ResultatDe;
                    if (resultatDeMonstre > resultatDeJoueur)
                    {
                        player.JeterDe();
                        int resultatDeJoueur2 = player.ResultatDe;
                        if (resultatDeJoueur2 <= 2)
                        {
                            return;
                        }
                        else
                        {
                            player.PointDeVie -= resultatDeMonstre;
                        }
                    }
                    else
                    {
                        player.compteurMonstre1 = player.compteurMonstre1 + 1;
                        estVivant = false;
                        
                    }
                }

            } while (estVivant == true);
        }
    }
}
