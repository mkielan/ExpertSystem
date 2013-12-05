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

namespace Kielan.ExpertSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<String> Questions;

        public MainWindow()
        {
            InitializeComponent();
            Questions = new List<string>();

            Questions.Add("Item1");
            Questions.Add("Item2");
            Questions.Add("Item3");
            Questions.Add("Item4");
        }
    }
}
