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
        public int compteur = 0;
        public int score = 0; 

        

        public Examen_IA()
        {
            InitializeComponent();            
            questions = serializeQuestions();
            deserializeQuestions(questions); 
            choixQuestionAuHasard();
            lblNumQuestion.Text = numQuestionSur20_Affichage();
            lblAffichageQuestion.Text = question.ToString();
            methodePourAfficherlesReponses(question);
        }

        public string numQuestionSur20_Affichage ()                        // Affiche la progression sur les 20 questions posées
        {
            string numQuest = ("Question n°" + compteur + "/20");
            return numQuest; 
        }


        private void Examen_IA_Load(object sender, EventArgs e)            // Erreur de clic 
        {
            // affichageQuestion.Items.Add(question.ToString());            // Façon d'afficher dans des listBox 
        }

        // Méthodes 
        public List<Question> serializeQuestions()                         // On crée toutes les réponses, on crée toutes les questions, on les met dans la liste et on sérialise le tout. 
        {
            string[] reponsesQ1 = new string [] { "3", "6", "7" };
            string[] reponsesQ2 = new string[] { "La cinématique inverse est l’ensemble des rotations d’axes de liberté 𝜶, β, Ɣ … permettant de\n passer d’une position M(x,y,z) à une position M’(x’,y’,z’) dont les coordonnées et l’orientation\n sont préalablement choisies.", "Il s’agit du positionnement en face de l’objet suite à un mouvement de la base autour d’un axe\n vertical.", "La cinématique inverse est une méthode mathématique qui permet de calculer la position dans\n l’espace de l’extrémité d’un « bras » articulé à partir de la position dans laquelle se trouve\n chacune de ses articulations." };
            string[] reponsesQ3 = new string[] { "C’est l’ensemble des fonctions mentales ayant pour objet la connaissance conceptuelle\n et rationnelle.", "C’est l’ensemble des techniques et algorithmes permettant de résoudre des problèmes à l’aide\n d’un ordinateur.", "C’est un ensemble de règles opératoires visant à expliciter les étapes d’un raisonnement." };
            string[] reponsesQ4 = new string[] { "La reconnaissance visuelle, vision par ordinateur.", "Les systèmes experts.", "L’étude des facultés mentales humaines. ", "Les algorithmes génétiques." };
            string[] reponsesQ5 = new string[] { "L’IA forte.", "L’IA faible.", "Une forme d’IA intermédiaire." };
            string[] reponsesQ6 = new string[] { "Le nombre de noeuds ou de sommets qu’il possède (graphe orienté > graphe non orienté).", "Qu’il soit caractérisé par des arcs (graphe orienté) ou par des arêtes (graphe non orienté).", "Qu’à chaque relation soit obligatoirement associée une valeur (graphe orienté) ou non\n (graphe non orienté)." };
            string[] reponsesQ7 = new string[] { "Il permet de calculer des probabilités conditionnelles. En fonction des observations observées,\n on calcule la probabilité des informations non observées. ", "Il permet de représenter l’ensemble des concepts propres à un domaine ainsi que les relations\n entre ces concepts pour pouvoir raisonner à propos de ces objets.", "Il permet de décrire une forme physique et les liens entre les différents éléments qui la compose." };
           

            Question question1 = new Question("Combien de degrés de liberté sont nécessaires pour permettre à un bras UR3 de se positionner,\n de s’orienter et d’attraper un objet ?", 2, reponsesQ1);
            Question question2 = new Question("Comment peut-on définir la cinématique inverse ?", 0, reponsesQ2);
            Question question3 = new Question("Qu’est-ce que l’intelligence artificielle ?", 1, reponsesQ3);
            Question question4 = new Question("Laquelle de ces propositions ne constitue pas un sous-domaine de l’IA ?", 2, reponsesQ4);
            Question question5 = new Question("Quel type d’intelligence artificielle (IA) avons nous atteint aujourd’hui ?", 2, reponsesQ5);
            Question question6 = new Question("Dans le cadre de la modélisation des graphes, qu’est-ce qui distingue un graphe orienté\n d’un graphe non orienté ?", 1, reponsesQ6);
            Question question7 = new Question(" Quel intérêt présente l’usage d’un réseau bayésien ?", 0, reponsesQ7);
            
            List<Question> questions = new List<Question>();
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);
            questions.Add(question6);
            questions.Add(question7);  

            QuestionXML.Serialisation("ceciEstUnFichierXML.xml", questions);
            return questions;  
        }

        public void deserializeQuestions(List<Question> questions)
        {
            questions = QuestionXML.CreerAPartirDuFichier("ceciEstUnFichierXML.xml");
        }


        public void choixQuestionAuHasard()                                   // A revérifier une fois toutes les questions rentrées mais CA Y EST CA FONCTIONNE   
        {
            bool boucle = true;
            Random aleatoire = new Random();
            int numQuest = 0;
            while (boucle == true)
            {
                numQuest = aleatoire.Next(0, questions.Count());               
                                                                               
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

        public void methodePourAfficherlesReponses(Question question)      // Cette fonction permet d'afficher les propositions de réponses qu'il y en ait 1, 2, 3 ou 4 associées à la question.
        {                                                                  //Cela permet de diversifier les types de réponses (mettre un vrai/faux n'impliquant que deux réponses possibles par ex)
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

        public void CalculeScore ()                                            // Cette fonction permet de calculer le score mais on l'utilise également pour afficher la bonne  
                                                                               // réponse en vert quand l'élève a bien répondu, afin de l'encourager. Il n'y a pas de mise en 
        {                                                                      // couleur particulière quand il se trompe (remise en gris clair). 
            if ((question.bonneReponse == 0) && (radioButton0.Checked == true))
            {
                score++;
                lblBonneReponse.BackColor = Color.LightGreen; 
            }
            else if ((question.bonneReponse == 1) && (radioButton1.Checked == true))
            {
                score++;
                lblBonneReponse.BackColor = Color.LightGreen;
            }
            if ((question.bonneReponse == 2) && (radioButton2.Checked == true))
            {
                score++;
                lblBonneReponse.BackColor = Color.LightGreen;
            }
            if ((question.bonneReponse == 3) && (radioButton3.Checked == true))
            {
                score++;
                lblBonneReponse.BackColor = Color.LightGreen;
            }

            lblScoreTotal.Text = "Score : " + score + "/20";
        }

        public void AssocieBonneReponse ()
        {
            if (question.bonneReponse == 0)
                lblBonneReponse.Text = radioButton0.Text;

            if (question.bonneReponse == 1)
                lblBonneReponse.Text = radioButton1.Text;

            if (question.bonneReponse == 2)
                lblBonneReponse.Text = radioButton2.Text;

            if (question.bonneReponse == 3)
                lblBonneReponse.Text = radioButton3.Text;
        }

        // Boutons 
        private void validerRep_Click(object sender, EventArgs e)
        {
            if (radioButton0.Checked == false && radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {

                lblPasDeRepSelectionnee.Visible = true;
            }
            else
            {
                lblPasDeRepSelectionnee.Visible = false;
                gpbxReponse.Visible = true;
                btnQuestionSuivante.Visible = true;
                btnValiderRep.Visible = false;
                radioButton0.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                AssocieBonneReponse(); 
                CalculeScore(); 
            }
        }

        private void btnQuestionSuivante_Click(object sender, EventArgs e)
        {
            gpbxReponse.Visible = false;
            lblBonneReponse.BackColor = Color.WhiteSmoke;  
            btnQuestionSuivante.Visible = false;
            btnValiderRep.Visible = true;

            radioButton0.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;

            radioButton0.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            choixQuestionAuHasard();            
            lblNumQuestion.Text = numQuestionSur20_Affichage();
            lblAffichageQuestion.Text = question.ToString();
            methodePourAfficherlesReponses(question);

            if (compteur == 7)
            {
                AffichageFinal AffichageFinal = new AffichageFinal();
                AffichageFinal.Show();
                this.Hide();
            }


        }
    }
}
