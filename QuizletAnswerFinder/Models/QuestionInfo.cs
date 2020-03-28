using System;
using System.Collections.Generic;
using System.Text;
using StringComparion;
namespace Models
{

    public class QuestionInfo
    {
        public String Question { get; set; }
        public String Answer { get; set; }

        public FoundType Matches(String question)
        {

            JaccardDistance jaccardDistance = new JaccardDistance();

            decimal d = jaccardDistance.Distance(Question, question);

            if(d >= 50)
            {
                return FoundType.POSSIBLE;
            }

            return FoundType.NONE;


        }

    }

    public enum FoundType
    {
        CORRECT, POSSIBLE, NONE,
    }

}
