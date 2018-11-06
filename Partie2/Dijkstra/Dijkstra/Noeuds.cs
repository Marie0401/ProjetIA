using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    // classe abstraite, il est donc impératif de créer une classe qui en hérite
    // pour résoudre un problème particulier en y ajoutant des infos liées au contexte du problème
    abstract class Noeuds
    {
        // protected string Name;                      // DOIT ETRE UNIQUE POUR CHAQUE genericnode !!
        protected double coutDepuisInit;               //coût du chemin du noeud initial jusqu'à ce noeud
        protected double coutJusquFinal;               //estimation heuristique du coût pour atteindre le noeud final
        protected double coutTotal;                    //coût total (g+h)
        protected Noeuds noeudParent;                  // noeud parent
        protected List<Noeuds> enfants;                // noeuds enfants

        // Constructeurs
        public Noeuds()
        {
            noeudParent = null;
            enfants = new List<Noeuds>();
        }
        // Accesseurs
        public double CoutDepuisInit { get { return coutDepuisInit; } set { coutDepuisInit = value; } }
        public double Cout_Total { get { return coutTotal; } set { coutTotal = value; } }
        public List<Noeuds> Enfants { get { return enfants; } }
        public Noeuds Parent { get { return noeudParent; } }
        // Autres méthodes
        public double Estimation()
        {
            return coutJusquFinal;
        }
        public void Definir_Comme_Parent(Noeuds g)
        {
            noeudParent = g;
            g.Enfants.Add(this);
        }
        public void Supprime_Liens_Parent()
        {
            if (noeudParent == null) return; // le return sert à sortir de la méthode
            noeudParent.Enfants.Remove(this);
            noeudParent = null;
        }
        public void calculCoutTotal()
        {
            coutTotal = coutDepuisInit + coutJusquFinal;
        }
        
        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public abstract bool EtreEgalA(Noeuds N2);
        public abstract double CoutDeArcAvec(Noeuds N2);
        public abstract bool AtteintNoeudFinal();
        public abstract List<Noeuds> ListeSuccesseur();
        public abstract double CalculerCoutVersNoeudFinal();
        // On peut aussi penser à surcharger ToString() pour afficher correctement un état
        // c'est utile pour l'affichage du treenode
    }
}
