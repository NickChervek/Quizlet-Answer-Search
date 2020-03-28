using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Models;

namespace WebScraper.SetDownload
{
    public class XmlGenerator
    {

        /// <summary>
        /// Constructs xml that holds all question and answers about a set.
        /// </summary>
        /// <param name="setName"></param>
        /// <param name="questions"></param>
        public void GenerateXML(String setName, List<QuestionInfo> questions)
        {
            XElement element = new XElement("Set", new XAttribute("Name", setName));

            foreach(QuestionInfo question in questions)
            {
                XElement questionAnswer = new XElement("QuestionAnswer");
                questionAnswer.Add(new XElement("Question", question.Question));
                questionAnswer.Add(new XElement("Answer"), question.Answer);
                element.Add(questionAnswer);

            }

            
            Console.WriteLine(element.ToString());

        }

    }
}
