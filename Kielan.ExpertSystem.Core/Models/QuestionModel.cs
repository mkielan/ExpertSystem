using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kielan.ExpertSystem.Core.Models
{
    public class QuestionModel
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public IList<AnswerModel> Answers { get; set; }

        public QuestionModel()
        {
            Answers = new List<AnswerModel>();
        }
    }
}
