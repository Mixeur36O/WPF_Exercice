using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _6TTI_Limet_Maxence_Event1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextA.PreviewTextInput += new TextCompositionEventHandler(VerifTextEntree);
            TextB.PreviewTextInput += new TextCompositionEventHandler(VerifTextEntree);
            TextC.PreviewTextInput += new TextCompositionEventHandler(VerifTextEntree);
            btnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click);
        }




        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double b;
            double c;
            string message;

            if (double.TryParse(TextA.Text, out a) && double.TryParse(TextA.Text, out b) && double.TryParse(TextA.Text, out c))
            {
                ResoudTrinome(a, b, c, out message);
            }
  
        }
        private void ResoudTrinome(double a, double b, double c, out string message)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }
        }

        private void VerifTextEntree(object sender, TextCompositionEventArgs e)
        {
            if (e.Text !="," && !EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private bool EstEntier(string texteUser)
        {
            if (!int.TryParse(texteUser, out int valeur))
            {
                return false;
            }
            return true;
        }
    }
}