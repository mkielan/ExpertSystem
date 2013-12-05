using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kielan.ExpertSystem.Core
{
    public class Question
    {
        public string Text { get; set; }

        public IList<Answer> Answers { get; set; }

        public Question()
        {
            Answers = new List<Answer>();
        }
    }
}
