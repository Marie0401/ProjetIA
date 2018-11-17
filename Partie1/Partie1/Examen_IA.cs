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
        public Examen_IA()
        {
            InitializeComponent();
        }

        private void numQuestionSur20_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;     
            Console.Write("Question n°" + i + "/20"); 
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

            // Essai d'afficher le numéro de question
            //numQuestionSur20.(question.numeroQuestion);

        }
    }
}
