using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kielan.ExpertSystem.Core.Data;
using Kielan.ExpertSystem.Core.Models;

namespace Kielan.ExpertSystem.Core
{
    /// <summary>
    /// Silnik systemu eksperckiego.
    /// </summary>
    public class Engine
    {
        private SEDataContext _context { get; set; }

        private IList<Question> Questions { get; set; }

        private IList<Fact> Answers { get; set; }

        private Random _rand {get; set; }

        public Engine()
        {
            _context = new SEDataContext();

            Questions = new List<Question>();
            Answers = new List<Fact>();

            _rand = new Random();
        }
        
        /// <summary>
        /// Wybranie nowego pytania
        /// </summary>
        /// <returns></returns>
        public QuestionModel NextQuestion() 
        {
            QuestionModel model = null;

            var all = _context.Questions.Count();

            if (all > 0 && all > Questions.Count)
            {
                Question question = null;

                do
                {
                    var index = _rand.Next(_context.Questions.Count());

                    question = _context.Questions.ToList()[index];
                }
                while (Questions.Contains(question));

                Questions.Add(question);

                model = new QuestionModel
                {
                    Id = question.QuestionId,
                    Text  = question.Text,
                    Answers = question.Answers.Select(
                        answer => 
                            new AnswerModel { 
                                Id = answer.FactId,
                                Text = answer.Fact.Text
                            }
                        ).ToList()
                };
            }

            return model;
        }

        /// <summary>
        /// Odłożenie odpowiedzi do ostatniej odpowiedzi.
        /// Sprawdza, też czy jest już spełniony jakaś konkluzja (Action),
        /// na podstawie reguł (Rules) oraz wszystkich przesłanek (Facts).
        /// Jeśli jest spełniona jakaś konkluzja to jest zwracana.
        /// </summary>
        /// <param name="fact"></param>
        public ConclusionModel Answer(Fact fact)
        {
            Answers.Add(fact);

            var rules = new List<RuleModel>();

            //przeszukiwanie, aby znaleźć regułę spełniającą przesłanki
            foreach (var rule in _context.Rules.Where(r => r.Patterns.Count() <= Answers.Count))
            {
                var sum = 0;
                var cfs = new List<double>();

                foreach (var p in rule.Patterns)
                {
                    if(Answers.Select(ans => ans.FactId).Contains(p.FactId)) {
                        sum += 1;
                        cfs.Add(p.Fact.Cf);
                    }
                }
                
                //gdy w odpowiedziach odnaleziono tyle przesłanek ile jest w regule 
                if(sum == rule.Patterns.Count) {
                    var cf_min = cfs.Min();
                    var conclusion = _context.Conclusions.FirstOrDefault(c => c.ConclusionId == rule.ConclusionId);
                    var cf_konk = conclusion.Cf * cfs.Aggregate((c1, c2) => c1 * c2);

                    rules.Add(new RuleModel { Id = rule.RuleId, Cf = cf_konk });
                }
            }

            // wybranie najpewniejszej
            if (rules.Count() > 0)
            {
                var maxCf = rules.Max(r => r.Cf);
                var rule = rules.FirstOrDefault(r => r.Cf == maxCf).Id;

                var conclusionId = _context.Rules.FirstOrDefault(cc => cc.RuleId == rule).ConclusionId;

                return new ConclusionModel
                {
                    Cf = maxCf,
                    Text = _context.Conclusions.FirstOrDefault(c => c.ConclusionId == conclusionId).Name
                };
            }
            //przypadek gdy wszystkie sprawdzone, ale żadna reguła nie spełniona
            else if (rules.Count() == 0 && Questions.Count == _context.Questions.Count())
            {
                return Answer(_context.Facts.FirstOrDefault(f => f.FactId == 17));
            }

            return null;
        }
        
        public ConclusionModel Answer(long id)
        {
            var fact = _context.Facts.FirstOrDefault(f => f.FactId == id);
            return Answer(fact);
        }

        public void Clear()
        {
            Questions.Clear();
            Answers.Clear();
        }
    }
}
