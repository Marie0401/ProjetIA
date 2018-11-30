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

namespace Partie2
{
    public partial class Examen_IA_partie2 : Form
    {
        static public double[,] matrice; // donne les relations entre les noeuds 
        static public int nbreNoeuds;
        string L_Ouverts_Donnes_Uti;
        string L_Fermes_Donnes_Uti;
        static public int numfinal;
        List<int> fermes = new List<int>();
        List<int> ouverts = new List<int>();
        bool correctOuv;
        bool correctFerm;

        public Examen_IA_partie2()
        {
            InitializeComponent();
            InitialiserGraphe();
            txtBox_reponseOuverts.Text = "{" + NoeudInit_textBox.Text + "}";
            txtBox_reponseFermes.Text = "{}";
            solutionFerme_textBox.Text = "{}\r\n";
            solutionOuvert_textBox1.Text = "{" + NoeudInit_textBox.Text + "}\r\n";
            numfinal = Convert.ToInt32(NoeudFinal_textBox.Text);
        }

        protected void btn_Valider_Click(object sender, EventArgs e)
        {
            if ((txtBox_reponseFermes.Text == "") || (txtBox_reponseOuverts.Text == ""))
            {
                if (txtBox_reponseFermes.Text == "{}")
                    txtBox_reponseFermes.Text = "Il faut remplir cette case. ";
                if (txtBox_reponseOuverts.Text == "{" + NoeudInit_textBox.Text + "}")
                    txtBox_reponseOuverts.Text = "Il faut remplir cette case. ";
            }
            else
            {
                L_Ouverts_Donnes_Uti = txtBox_reponseOuverts.Text;
                L_Fermes_Donnes_Uti = txtBox_reponseFermes.Text;
                Solution();
                string L_solution_fermes = solutionFerme_textBox.Text;
                string L_solution_ouverts = solutionOuvert_textBox1.Text;

                // On corrige les fermes 
                correctOuv = CorrectionChaine(L_Ouverts_Donnes_Uti, L_solution_ouverts, txtBox_reponseOuverts);
                // On corrige les fermés
                correctFerm = CorrectionChaine(L_Fermes_Donnes_Uti, L_solution_fermes, txtBox_reponseFermes);
            }
        }
        protected void Reinitialiser_button_Click(object sender, EventArgs e)
        {
            solutionFerme_textBox.Text = "{}";
            solutionOuvert_textBox1.Text = "{" + NoeudInit_textBox.Text + "}";
            txtBox_reponseOuverts.Text = "{" + NoeudInit_textBox.Text + "}\r\n";
            txtBox_reponseFermes.Text = "{}\r\n";
            ouverts = new List<int>();
            fermes = new List<int>();
        }
        protected void versGraphe_button_Click(object sender, EventArgs e)
        {
            EvaluationArbre EvalArbre = new EvaluationArbre(matrice, nbreNoeuds, solutionFerme_textBox.Text, solutionOuvert_textBox1.Text);
            EvalArbre.ShowDialog();
        }

        public void InitialiserGraphe()
        {
            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // On cherche le combre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strNbreNoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strNbreNoeuds = strNbreNoeuds + ligne[i];
                i++;
            }
            nbreNoeuds = Convert.ToInt32(strNbreNoeuds);


            matrice = new double[nbreNoeuds, nbreNoeuds];
            for (i = 0; i < nbreNoeuds; i++)
                for (int j = 0; j < nbreNoeuds; j++)
                    matrice[i, j] = -1;

            // Ensuite on a la structure suivante : 
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

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }
        public void Solution()
        {
            solutionFerme_textBox.Text += "{" + NoeudInit_textBox.Text + "}\r\n";
            int noeudInit = Convert.ToInt32(NoeudInit_textBox.Text);
            int noeudFinal = Convert.ToInt32(NoeudFinal_textBox.Text);
            fermes.Add(noeudInit);

            CalculOuverts(noeudInit);

            while (!fermes.Contains(noeudFinal))
            {
                noeudInit = ouverts[0];
                fermes.Add(ouverts[0]);             // les fermés sont triés dans l'ordre croissant
                ouverts.Remove(ouverts[0]);
                CalculOuverts(noeudInit);
                AfficherListes(solutionFerme_textBox, fermes);
            }

        }
        protected void CalculOuverts(int noeudInit)
        {
            // Ce qu'il y a avant dans la liste des fermés, que l'on veut rajouté à la fin 
            List<int> ouvertsAnciens = new List<int>();
            for (int i = 0; i < ouverts.Count; i++)
                ouvertsAnciens.Add(ouverts[i]);
            // On récupère tous les noeuds qui sont en liens avec noeudInit
            List<int> ouvertsNonTries = new List<int>();
            for (int i = 0; i < nbreNoeuds; i++)
            {
                if ((matrice[noeudInit, i] != -1)&&(!fermes.Contains(i)) && (!ouverts.Contains(i)))      // si il y a un lien entre ces deux noeuds et s'il n'est pas dans les fermes ni dans les fermés
                    ouvertsNonTries.Add(i);                                                                       // on rajoute ce noeud aux fermés
            }
            // On les trie par ordre croissant de valeur d'arc
            int j = 0;
            int placeNoeudTest = 0;
            while (j < ouvertsNonTries.Count)
            {
                int noeudTest = ouvertsNonTries[j];
                for (int i = j; i < ouvertsNonTries.Count; i++)
                {
                    if (matrice[noeudInit, ouvertsNonTries[i]] < matrice[noeudInit, noeudTest])
                    {
                        int test = ouvertsNonTries[i];
                        ouvertsNonTries[i] = ouvertsNonTries[placeNoeudTest];
                        ouvertsNonTries[placeNoeudTest] = test;
                        placeNoeudTest = i;
                    }
                }
                j++;
            }
            // On remet en première position dans la liste des fermés
            ouverts = new List<int>();
            for (int i = 0; i < ouvertsNonTries.Count; i++)
                ouverts.Add(ouvertsNonTries[i]);
            // On rajoute les noeuds qu'il y avait après le noeud que l'on vient d'étudier
            for (int i = 0; i < ouvertsAnciens.Count; i++)
                ouverts.Add(ouvertsAnciens[i]);
            // On l'affiche dans la textbox
            AfficherListes(solutionOuvert_textBox1, ouverts);
        }
        protected void AfficherListes(TextBox tB, List<int> liste)
        {
            tB.Text += "{";
            for (int i = 0; i < liste.Count; i++)
                tB.Text += Convert.ToString(liste[i]);
            tB.Text += "}\r\n";
        }
        protected string NettoyerChaine(string chaine)
        {
            List<char> chaineNettoyee = new List<char>();
            int long1 = chaine.Count();
            for (int i = 0; i < long1; i++)
            {
                // On ne garde que les caractères qui nous intéressent, en supposant qu'il n'y a jamais plus de 10 noeuds
                if ((chaine[i] == '0') || (chaine[i] == '1') || (chaine[i] == '2') || (chaine[i] == '3') || (chaine[i] == '4') || (chaine[i] == '5') || (chaine[i] == '6') || (chaine[i] == '7') || (chaine[i] == '8') || (chaine[i] == '9') || (chaine[i] == '{') || (chaine[i] == '}'))
                    chaineNettoyee.Add(chaine[i]);
            }
            long1 = chaineNettoyee.Count();
            chaine = "";
            for (int i = 0; i < long1; i++)
                chaine += chaineNettoyee[i];
            return chaine;
        }
        protected bool CorrectionChaine(string utilisateur, string solution, TextBox txtbox)
        {
            string utilisateurNettoye = NettoyerChaine(utilisateur);
            string solutionNettoyer = NettoyerChaine(solution);
            bool correct;

            // On teste ensuite ces chaines entre elles, si elles ne sont pas identiques, alors l'utilisateur a eu faux.
            if (utilisateurNettoye != solutionNettoyer)
            {
                correct = false;
                txtbox.Text += "\r\n  Ce n'est pas la bonne réponse, voyez la solution à droite.";
            }
            else
            {
                correct = true;
                txtbox.Text += "\r\n  Bonne réponse !";
            }
            return correct;
        }
    }
}
