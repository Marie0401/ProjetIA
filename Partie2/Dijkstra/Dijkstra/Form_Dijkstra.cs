using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dijkstra
{
    public partial class Form_Dijkstra : Form
    {

        static public double[,] matrice;  // la matrice qui donne la distance entre les noeuds
        static public int nbnoeuds = 10;  // nombre de noeuds dans le graphe
        static public int numinitial;
        static public int numfinal;

        public Form_Dijkstra()
        {
            InitializeComponent();
        }

        private void btn_InitGrapheDefaut_Click(object sender, EventArgs e)
        {
            matrice = new double[nbnoeuds, nbnoeuds];
            for (int i = 0; i < nbnoeuds; i++)
                for (int j = 0; j < nbnoeuds; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = 3;    matrice[1, 0] = 3;
            matrice[0, 2] = 5;    matrice[2, 0] = 5;
            matrice[0, 3] = 7;    matrice[3, 0] = 7;
            matrice[1, 4] = 8;    matrice[4, 1] = 8;
            matrice[2, 4] = 3;    matrice[4, 2] = 3;
            matrice[4, 5] = 7;    matrice[5, 4] = 7;
            matrice[5, 6] = 4;    matrice[6, 5] = 4;
        }
        private void btn_RechercheCheminLPCourt_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(txtbx_NoeudInit.Text);
            numfinal = Convert.ToInt32(txtbx_NoeudFinal.Text);
            ConstructionArbre g = new ConstructionArbre();
            Noeud N0 = new Noeud();
            N0.numero = numinitial;
            List<Noeuds> solution = g.RechercheSolutionAEtoile(N0);

            Noeud N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Noeud N2 = (Noeud)solution[i];
                listBox_AffichageChemin.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }
            
            g.ConstruireArbre(tV_AffichageArbre);
        }
        private void btn_InitGrapheFichier_Click(object sender, EventArgs e)
        {
            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnoeuds = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnoeuds, nbnoeuds];
            for (i = 0; i < nbnoeuds; i++)
                for (int j = 0; j < nbnoeuds; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                lstbx_AffichageGrapheFichier.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }
        
    }
}
