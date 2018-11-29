using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Noeud : Noeuds  // sans s car ce noeud en particulier
    {
        public int numero;

        public override bool EtreEgalA(Noeuds N2)
        {
            Noeud N2bis = (Noeud)N2;
            return numero == N2bis.numero;
        }
        public override double CoutDeArcAvec(Noeuds N2)
        {
            Noeud N2bis = (Noeud)N2;
            return Form_Dijkstra.matrice[numero, N2bis.numero];
        }
        public override bool AtteintNoeudFinal()
        {
            return (numero == Form_Dijkstra.numfinal);
        }
        public override List<Noeuds> ListeSuccesseur()
        {
            List<Noeuds> listeSuccesseur = new List<Noeuds>();

            for (int i = 0; i < Form_Dijkstra.nbnoeuds; i++)
            {
                if (Form_Dijkstra.matrice[numero, i] != -1)
                {
                    Noeud newnode2 = new Noeud();
                    newnode2.numero = i;
                    listeSuccesseur.Add(newnode2);
                }
            }
            return listeSuccesseur;
        }
        public override double CalculerCoutVersNoeudFinal()
        {
            return (0);
        }
        public override string ToString()
        {
            return Convert.ToString(numero);
        }
    }
}
