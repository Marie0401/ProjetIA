using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie1bis
{
    public partial class Examen_IA : Form
    {
        int compteur = 0;

        public Examen_IA()
        {
            InitializeComponent();
            lblNumQuestion.Text = numQuestionSur20_Affichage(); 

        }

        public string numQuestionSur20_Affichage ()                                                     // Affiche la progression sur les 20 questions posées
        {
            string numQuest = ("Question n°" + compteur + "/20");
            return numQuest; 
        }



        private void Examen_IA_Load(object sender, EventArgs e)
        {

        }

        private void validerRep_Click(object sender, EventArgs e)
        {
            // Faire une sorte de clear all puis afficher la question selon la liste XML de questions 
            List<string> rep = new List<string>();
            rep.Add("1"); rep.Add("2"); rep.Add("3");
            Question question = new Question("test", 2, rep);

            affichageQuestion.Items.Add(question.ToString());

        }
    }
}
