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
        List<Question> questions = new List<Question>(); 
        int compteur = 1;

        

        public Examen_IA()
        {
            InitializeComponent();
            lblNumQuestion.Text = numQuestionSur20_Affichage();
            questions = serializeQuestions();
            deserializeQuestions(questions);
            lblAffichageQuestion.Text = methodeTestPourAvoirUneQuestion(); 



        }

        public string numQuestionSur20_Affichage ()                                // Affiche la progression sur les 20 questions posées
        {
            string numQuest = ("Question n°" + compteur + "/20");
            return numQuest; 
        }



        private void Examen_IA_Load(object sender, EventArgs e)
        {

        }

        public List<Question> serializeQuestions()
        {
            List<string> reponsesQ1 = new List<string> { "3", "6", "7" };
            List<string> reponsesQ2 = new List<string> { "rep", "rep2", "rep3" };
            

            Question question1 = new Question("Combien de degrés de liberté sont nécessaires pour permettre à un bras UR3 de se positionner,\n de s’orienter et d’attraper un objet ?", 2, reponsesQ1);
            Question question2 = new Question("Comment peut-on définir la cinématique inverse ?", 0, reponsesQ2);
            

            List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question2);

            QuestionXML.Serialisation("ceciEstUnFichierXML.xml", questions);
            return questions;  
        }


        public void deserializeQuestions(List<Question> questions)  // Ca c'est bon, permet de déserializer le fichier XML et de mettre le résultat dans une liste de questions
        {
            questions = QuestionXML.CreerAPartirDuFichier("ceciEstUnFichierXML.xml");
        }


        private void validerRep_Click(object sender, EventArgs e)
        {
            // Faire une sorte de clear all puis afficher la question selon la liste XML de questions 
            List<string> rep = new List<string>();
            rep.Add("1"); rep.Add("2"); rep.Add("3");
            Question question = new Question("Combien de degrés de liberté sont nécessaires pour permettre à un bras UR3 de se positionner, de s’orienter et d’attraper un objet ?", 2, rep);

            // affichageQuestion.Items.Add(question.ToString());

        }

        public string methodeTestPourAvoirUneQuestion()         // Ceci est une méthode test vouée à disparaitre 
        {
            List<string> rep = new List<string> { "3", "6", "7" };
            Question question = new Question("Combien de degrés de liberté sont nécessaires pour permettre à un bras UR3 de se positionner, de s’orienter et d’attraper un objet ?", 2, rep);

            return question.ToString(); 
        }


    }
}
