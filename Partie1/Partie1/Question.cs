using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1bis
{
    class Question
    {
        // ATTRIBUTS
        protected static int id;
        protected string intitule;
        protected int bonneReponse;                 // entier compris entre 0 et 3 et associé à une bonne réponse a, b, c, ou d.  
        protected List<string> reponses;

        // CONSTRUCTEURS
        public Question(string intituleQuestion, int bonneRep, List<string> reps)
        {
            intitule = intituleQuestion;
            bonneReponse = bonneRep;
            reponses = reps;
        }

        // ACCESSEURS
        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }

        public int BonneReponse
        {
            get { return BonneReponse; }
        }

        public List<String> Reponses
        {
            get { return reponses; }
            set { reponses = value; }
        }

        // AUTRES METHODES
        //Une méthode d'affichage de la question = > son intitulé 
        public override string ToString()
        {
            string questionAffichee = "Question : " + intitule;
            return questionAffichee;
        }

        // Une méthode d'affichage des réponses                         // VOIR AVEC LE XML 
        // Pb de cohérence Azi, tu n'utilises pas la liste reponses  
        public void ReponsesAffichees(List<String> reponses)
        {
            List<string> ReponsesAffichees = new List<string>();

            foreach (string rep in ReponsesAffichees)
            {
                Console.WriteLine(rep);
            }
        }

        // Methode qui affiche le numéro de la question 
        public void numeroQuestion(int i)
        {
            Console.Write("Question n°" + i + "/20");
        }


        /*
        Question question1 = new Question("Combien de degrés de liberté sont nécessaires pour permettre à un bras UR3 de se positionner, de s’orienter et d’attraper un objet ?", 2, List<String> reps)
            rep.Add("3") ; 
            rep.Add("6") ; 
            rep.Add("7") ; */


    }
}
