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

        public EvaluationArbre(double[,] mat, int nNoeuds, string ferm, string ouv)
        {
            InitializeComponent();
            matrice = mat;
            nbreNoeuds = nNoeuds;
            solutionFerme_textBox.Text = ferm;
            solutionOuvert_textBox.Text = ouv;
            DessinerGraphe();
        }

        private void Graphe_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GrapheReponse_treeView.SelectedNode.BeginEdit();
            //MessageBox.Show(treeView1.SelectedNode.Text);
        }
        private void Valider_button_Click(object sender, EventArgs e)
        {
            GrapheSolution_treeView.Visible = true;
            CompareTreeNodes(GrapheReponse_treeView, GrapheSolution_treeView);
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
        void CompareTreeNodes(TreeView tv1, TreeView tv2)
        {
            int compare = Math.Min(tv1.Nodes.Count, tv2.Nodes.Count);
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tv1.Nodes[i], tv2.Nodes[i]);
            }

        }
        void CompareRecursiveTree(TreeNode tn1, TreeNode tn2)
        {
            if (tn1.Text != tn2.Text)
            {
                tn1.ForeColor = Color.Red;
                tn2.ForeColor = Color.Red;
            }
            else
            {
                tn1.ForeColor = Color.Green;
                tn2.ForeColor = Color.Green;
            }
            int compare = tn1.Nodes.Count;  // Les deux arbres sont forcément de même taille
            for (int i = 0; i < compare; i++)
            {
                CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i]);
            }
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
