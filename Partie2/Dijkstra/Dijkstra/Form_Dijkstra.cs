using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class Form_Dijkstra : Form
    {

        static public double[,] matrice;  // la matrice qui donne la distance entre les noeuds
        static public int nbnodes = 10;  // nombre de noeuds dans le graphe
        static public int numinitial;
        static public int numfinal;

        public Form_Dijkstra()
        {
            InitializeComponent();
        }

        private void btn_InitGrapheDefaut_Click(object sender, EventArgs e)
        {
            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = 3;    matrice[1, 0] = 3;
            matrice[0, 2] = 5;    matrice[2, 0] = 5;
            matrice[0, 3] = 7;    matrice[3, 0] = 7;
            matrice[1, 4] = 8;    matrice[4, 1] = 8;
            matrice[2, 4] = 3;    matrice[4, 2] = 3;
            matrice[4, 5] = 7;    matrice[5, 4] = 7;
            matrice[5, 6] = 4;    matrice[6, 5] = 4;
        }

        private void btn_InitGrapheFichier_Click(object sender, EventArgs e)
        {

        }

        private void btn_RechercheCheminLPCourt_Click(object sender, EventArgs e)
        {/*
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(treeView1);*/
        }
    }
}
