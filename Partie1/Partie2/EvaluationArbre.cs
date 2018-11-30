using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie2
{
    public partial class EvaluationArbre : Form
    {
        static public double[,] matrice;
        int nbreNoeuds;
        int score;

        public EvaluationArbre(double[,] mat, int nNoeuds, string ferm, string ouv, int sc)
        {
            InitializeComponent();
            matrice = mat;
            nbreNoeuds = nNoeuds;
            solutionFerme_textBox.Text = ferm;
            solutionOuvert_textBox.Text = ouv;
            score = sc;
            DessinerGraphe();
        }

        private void Graphe_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GrapheReponse_treeView.SelectedNode.BeginEdit();
        }
        private void Valider_button_Click(object sender, EventArgs e)
        {
            Valider_button.Visible = false;
            GrapheSolution_treeView.Visible = true;
            questionSuivante_button.Visible = true;
            int faux = 0;
            faux = CompareTreeNodes(GrapheReponse_treeView, GrapheSolution_treeView, faux);
            if (faux == 0)
                score++;
        }
        private void questionSuivante_button_Click(object sender, EventArgs e)
        {
            AffichageFinal AffichageFinal = new AffichageFinal(score);
            AffichageFinal.Show();
            this.Hide();
        }

        public void DessinerGraphe()
        {
            int numinitial = Convert.ToInt32(NoeudInit_textBox.Text);
            int numfinal = Convert.ToInt32(NoeudFinal_textBox.Text);
            ConstructionArbre g = new ConstructionArbre();
            Noeud N0 = new Noeud();
            N0.numero = numinitial;
            List<Noeuds> solution = g.RechercheSolutionAEtoile(N0);

            Noeud N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Noeud N2 = (Noeud)solution[i];
                N1 = N2;
            }

            g.ConstruireArbre(GrapheReponse_treeView, "?");
            g.ConstruireArbre(GrapheSolution_treeView);
        }
        int CompareTreeNodes(TreeView tv1, TreeView tv2, int faux)
        {
            int compare = Math.Min(tv1.Nodes.Count, tv2.Nodes.Count);
            for (int i = 0; i < compare; i++)
            {
                faux = CompareRecursiveTree(tv1.Nodes[i], tv2.Nodes[i], faux);
            }
            return faux;
        }
        int CompareRecursiveTree(TreeNode tn1, TreeNode tn2, int faux)
        {
            if (tn1.Text != tn2.Text)
            {
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Red;
                faux++;
            }
            else
            {
                tn1.ForeColor = Color.Green;
                tn2.ForeColor = Color.Green;
            }
            int compare = tn1.Nodes.Count;  // Les deux arbres sont forcément de même taille
            for (int i = 0; i < compare; i++)
            {
                faux = CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i], faux);
            }
            return faux;
        }
        protected void AfficherListes(TextBox tB, List<int> liste)
        {
            tB.Text += "{";
            for (int i = 0; i < liste.Count; i++)
                tB.Text += Convert.ToString(liste[i]);
            tB.Text += "}\r\n";
        }
    }
}
