using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Kielan.ExpertSystem.Core;

namespace Kielan.ExpertSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Question _question;
        public Question Question { 
            get { return _question; }
            set { 
                _question = value;
                txbQuestionField.Text = value.Text;

                Refresh(value);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            var q = new Question { Text = "Test Question" };
            q.Answers.Add(new Answer { Text = "Item1" });
            q.Answers.Add(new Answer { Text = "Item2" });
            q.Answers.Add(new Answer { Text = "Item3" });
            q.Answers.Add(new Answer { Text = "Item4" });

            Question = q;
        }

        public void Refresh(Question question)
        {
            lvAnswers.Items.Clear();

            foreach (var a in question.Answers)
            {
                lvAnswers.Items.Add(a);
            }
        }
    }
}
