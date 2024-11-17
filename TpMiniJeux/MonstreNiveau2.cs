using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMiniJeux
{
    internal class MonstreNiveau2 : MonstreNiveau1
    {
        private int degatGenerer;
        Boolean estVivant = true;
        public MonstreNiveau2()
        {
        }
        public override void Attaquer(Joueur player)
        {

            do
            {
                base.Attaquer(player);
                De monstreDe2 = new De();
                monstreDe2.LancerDe();
                player.JeterDe();
                if (player.ResultatDe < monstreDe2.ResultatDe)
                {
                    int resultatDeMonstre2 = monstreDe2.ResultatDe;
                    if (resultatDeMonstre2 != 6)
                    {
                        player.PointDeVie = player.PointDeVie - (5 * resultatDeMonstre2);
                    }
                }
                else
                {
                    player.compteurMonstre2 = player.compteurMonstre2 + 1;
                    estVivant = false;
                }
            }
            while (estVivant == true);

            
        }
    }
    
}
