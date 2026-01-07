using System.Security.Cryptography.X509Certificates;
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

namespace _6TTI_Limet_Maxence_DamChSerpC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] button = new Button[10, 10];
        public MainWindow()
        {
            InitializeComponent();
            prepareInterface();
        }
        public void prepareInterface()
        {
            //Instancier variables et tableau
            int indicateurC = 0;
            int indicateurL = 0;
            ColumnDefinition[] colDef = new ColumnDefinition[10];
            RowDefinition[] rowDef = new RowDefinition[10];

            //Faire la grille
            for (int i = 0; i < 10; i++)
            {
                colDef[i] = new ColumnDefinition();
                rowDef[i] = new RowDefinition();
                grdMain.ColumnDefinitions.Add(colDef[i]);
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            for (int iColonne = 0; iColonne < button.GetLength(0); iColonne++)
            {
                for (int iLigne = 0; iLigne < button.GetLength(1); iLigne++)
                {

                    button[iColonne, iLigne] = new Button();
                    button[iColonne, iLigne].FontSize = 50;

                    if (indicateurL % 2 == indicateurC % 2)
                    {
                        button[iColonne, iLigne].Background = Brushes.White;

                    }
                    else
                    {
                        button[iColonne, iLigne].Background = Brushes.Black;

                    }
                    button[iColonne, iLigne].Content = Num(iLigne,iColonne);
                    button[iColonne, iLigne].Foreground = Brushes.Red;
                    button[iColonne, iLigne].HorizontalContentAlignment = HorizontalAlignment.Center;
                    button[iColonne, iLigne].VerticalContentAlignment = VerticalAlignment.Center;
                    button[iColonne, iLigne].FontSize = 20;
                    button[iColonne, iLigne].FontWeight = FontWeights.Bold;
                    Grid.SetColumn(button[iColonne, iLigne], indicateurC);
                    grdMain.Children.Add(button[iColonne, iLigne]);
                    indicateurC += 1;
                    Grid.SetRow(button[iColonne, iLigne], indicateurL);
                }
                indicateurC = 0;
                indicateurL += 1;
            }
        }
            public int Num(int iLigne, int iColonne)
            {
            int num;
            if (iColonne % 2 == 0)
            {
                num = iLigne + 1 + (10 * iColonne);
            }
            else
            {
                num = (10 * iColonne) + 10 - iLigne;
            }
            return num;
        }
    }
}
    
