using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using System.Xml;
using System.Xml.Serialization; 

namespace Partie1bis
{
    public class QuestionXML
    {
        public static void Serialisation (string nomDuFichier, List<Question> questions)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            using (FileStream fStream = new FileStream(nomDuFichier, FileMode.Create))
            {
                serializer.Serialize(fStream, questions); 
            }
        }

        public static List <Question> CreerAPartirDuFichier(string nomDuFichier)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            List<Question> questions = null;
            using (FileStream fStream = new FileStream(nomDuFichier, FileMode.Open))
            {
                questions = (List<Question>)serializer.Deserialize(fStream); 
            }
            return questions; 
        }
    }
}
