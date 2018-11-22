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


        // CONSTRUCTEURS
        public Question()                            // Constructeur public et sans argument : permet la désérialisation 
        { }

        public Question(string intituleQuestion, int bonneRep, List<string> reps)   
        {
            this.intitule = intituleQuestion;
            this.bonneReponse = bonneRep;
            this.reponses = reps;
        }


        // AUTRES METHODES
        //Une méthode d'affichage de la question = > son intitulé 
        public override string ToString()
        {
            string questionAffichee = "Question : " + intitule;
            return questionAffichee;
        }


    }
}
