using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization; 

namespace Partie1bis
{
    public class Question                            // Seules les classes public ainsi que leurs champs et propriétés publics sont sérializables en XML.  
    {                                                // Donc pour tester le XML je mets tout en public 
        // ATTRIBUTS
        public static int id;
        public string intitule;
        public int bonneReponse;                     // entier compris entre 0 et 3 et associé à une bonne réponse a, b, c, ou d.  
        public List<string> reponses;

        // CONSTRUCTEURS
        public Question()                            // Constructeur public et sans argument : permet la désérialisation 
        {        }

        public Question(string intituleQuestion, int bonneRep, List<string> reps)   // Comment faire en sorte que l'identifiant s'ajoute ? 
        {
            this.intitule = intituleQuestion;
            this.bonneReponse = bonneRep;
            this.reponses = reps;
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
