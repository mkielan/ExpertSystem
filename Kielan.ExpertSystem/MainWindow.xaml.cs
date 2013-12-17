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
using Kielan.ExpertSystem.Core.Models;

namespace Kielan.ExpertSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Engine _engine;

        private QuestionModel _question;
        public QuestionModel Question { 
            get { return _question; }
            set { 
                _question = value;

                txbQuestionField.Text = (value == null) ? "" : value.Text;

                Refresh(value);
            }
        }

        public bool ContextEnable {
            get { return lvAnswers.IsEnabled; }
            set {
                lvAnswers.IsEnabled = value;
                btnNext.IsEnabled = value;
                txbQuestionField.IsEnabled = value;

                btnRun.IsEnabled = !value;
            } 
        }

        public MainWindow()
        {
            InitializeComponent();
            _engine = new Engine();

            ContextEnable = false;
        }

        public void Refresh(QuestionModel question)
        {
            lvAnswers.Items.Clear();

            if (question != null)
            {
                foreach (var a in question.Answers)
                {
                    lvAnswers.Items.Add(a);
                }
            }
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            _engine.Clear();
            LoadNext();

            if (lvAnswers.Items.Count > 0)
            {
                ContextEnable = true;
            }
            else
            {
                MessageBox.Show("Nie ma dostępnych pytań!");
            }
        }

        /// <summary>
        /// Ładuje nowe pytanie
        /// </summary>
        private void LoadNext()
        {
            Question = _engine.NextQuestion();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var item = GetChecked();

            if (item == null)
            {
                MessageBox.Show("Zaznacz jedną z odpowiedzi!");
            }
            else
            {
                var conclusion = _engine.Answer(item.Id);

                if (conclusion != null)
                {
                    MessageBox.Show("Wybrano: " + conclusion.Text + "\nZ niepewnością: " + conclusion.Cf, "Wynik");

                    Question = null;
                    ContextEnable = false;
                }
                else
                {
                    //nie ma jeszcze odpowiedzi
                    LoadNext();
                }
            }
        }

        private AnswerModel GetChecked()
        {
            foreach(var item in lvAnswers.Items) {
                var answer = (item as AnswerModel);

                if (answer.IsChecked) return answer;
            }

            return null;
        }
    }
}
