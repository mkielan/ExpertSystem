using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kielan.ExpertSystem.Core.Models
{
    public class AnswerModel
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public bool IsChecked { get; set; }
    }
}
