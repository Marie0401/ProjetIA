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
        private List<Question> questions = new List<Question>();
        private Question question = new Question(); 
        int compteur = 1;

        

        public Examen_IA()
        {
            InitializeComponent();
            lblNumQuestion.Text = numQuestionSur20_Affichage();
            questions = serializeQuestions();
            deserializeQuestions(questions); 
            choixQuestionAuHasard();
            lblAffichageQuestion.Text = question.ToString();
            methodePourAfficherlesReponses(question); 

        }

        public string numQuestionSur20_Affichage ()                                // Affiche la progression sur les 20 questions posées
        {
            string numQuest = ("Question n°" + compteur + "/20");
            return numQuest; 
        }



        private void Examen_IA_Load(object sender, EventArgs e)             // Erreur de clic 
        {
            // affichageQuestion.Items.Add(question.ToString());            // Façon d'afficher dans des listBox 
        }

        public List<Question> serializeQuestions()            // On commence tranquillou avec deux questions pour voir si ça fonctionne 
        {
            string[] reponsesQ1 = new string [] { "3", "6", "7" };
            string[] reponsesQ2 = new string[] { "rep", "rep2", "rep3" };
            string[] reponsesQ3 = new string[] { "reponse1", "reponse2", "reponse3" };
            


            Question question1 = new Question("Combien de degrés de liberté sont nécessaires pour permettre à un bras UR3 de se positionner,\n de s’orienter et d’attraper un objet ?", 2, reponsesQ1);
            Question question2 = new Question("Comment peut-on définir la cinématique inverse ?", 0, reponsesQ2);
            Question question3 = new Question("Qu’est-ce que l’intelligence artificielle ?", 1, reponsesQ3); 
            

            List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question2);

            QuestionXML.Serialisation("ceciEstUnFichierXML.xml", questions);
            return questions;  
        }


        public void deserializeQuestions(List<Question> questions)
        {
            questions = QuestionXML.CreerAPartirDuFichier("ceciEstUnFichierXML.xml");
        }


        public void choixQuestionAuHasard()                                   // A revérifier une fois toutes les questions rentrées mais ça à l'air de fonctionner  
        {
            bool boucle = true;
            Random aleatoire = new Random();
            int numQuest = 0;
            while (boucle == true)
            {
                numQuest = aleatoire.Next(0, questions.Count());              // Pas de changement entre le question.Count et le question.Count + 1,
                                                                              // il a l'air de ne jamais afficher la dernière question de la liste
                if (questions[numQuest].dejaChoisie == true)
                {
                    numQuest = aleatoire.Next(0, questions.Count());
                }
                else
                {
                    boucle = false;
                    question = questions[numQuest];
                    question.dejaChoisie = true;
                    compteur++;

                }
            }

        }



        private void validerRep_Click(object sender, EventArgs e)
        {
            if (radioButton0.Checked == false || radioButton1.Checked == false || radioButton2.Checked == false || radioButton3.Checked == false)
            {

                lblPasDeRepSelectionnee.Visible = true;
            }
            else
            {
                lblPasDeRepSelectionnee.Visible = false;


            }
        }



        public void methodePourAfficherlesReponses (Question question)          // Ce n'est peut-être pas optimal mais ça permet d'utiliser les  
        {                                                                       // radioButton (une seule bonne réponse possible)
            radioButton0.Visible = true; 
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;


            if (question.reponses.Length == 1)
            {
                radioButton0.Text = question.reponses[0];
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }

            else if (question.reponses.Length == 2)
            {
                radioButton0.Text = question.reponses[0];
                radioButton1.Text = question.reponses[1];
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
            else if (question.reponses.Length == 3)
            {
                radioButton0.Text = question.reponses[0];
                radioButton1.Text = question.reponses[1];
                radioButton2.Text = question.reponses[2];
                radioButton3.Visible = false;
            }

            else if (question.reponses.Length == 4)
            {
                radioButton0.Text = question.reponses[0];
                radioButton1.Text = question.reponses[1];
                radioButton2.Text = question.reponses[2];
                radioButton3.Text = question.reponses[3];
            }
            
        }
    }
}
