using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
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
            return Examen_IA_partie2.matrice[numero, N2bis.numero];
        }
        public override bool AtteintNoeudFinal()
        {
            return (numero == Examen_IA_partie2.numfinal);
        }
        public override List<Noeuds> ListeSuccesseur()
        {
            List<Noeuds> listeSuccesseur = new List<Noeuds>();

            for (int i = 0; i < Examen_IA_partie2.nbreNoeuds; i++)
            {
                if (Examen_IA_partie2.matrice[numero, i] != -1)
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
