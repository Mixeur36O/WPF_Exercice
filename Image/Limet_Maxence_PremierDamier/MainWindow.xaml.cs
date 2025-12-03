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

namespace Limet_Maxence_PremierDamier2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] button = new Button[8, 8];
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
            ColumnDefinition[] colDef = new ColumnDefinition[8];
            RowDefinition[] rowDef = new RowDefinition[8];
            BitmapImage imageButton = new BitmapImage();
            imageButton.BeginInit();
            imageButton.UriSource = new Uri("assets/p.png", UriKind.Relative);
            imageButton.EndInit();


            //Faire la grille
            for (int i = 0; i < 8; i++)
            {
                colDef[i] = new ColumnDefinition();
                rowDef[i] = new RowDefinition();
                grdMain.ColumnDefinitions.Add(colDef[i]);
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            //Faire apparaître les cases de ?
            for (int iColonne = 0; iColonne < button.GetLength(0); iColonne++)
            {

                for (int iLigne = 0; iLigne < button.GetLength(1); iLigne++)
                {
                    Image imButton = new Image();
                    imButton.Source = imageButton;
                    button[iColonne, iLigne] = new Button();
                    button[iColonne, iLigne].Background = Brushes.Black;
                    button[iColonne, iLigne].HorizontalAlignment = HorizontalAlignment.Center;
                    button[iColonne, iLigne].VerticalAlignment = VerticalAlignment.Center;
                    button[iColonne, iLigne].FontSize = 50;
                    button[iColonne, iLigne].Height = 67;
                    button[iColonne, iLigne].Width = 67;
                    button[iColonne, iLigne].Content = imButton;
                    Grid.SetColumn(button[iColonne, iLigne], indicateurC);
                    grdMain.Children.Add(button[iColonne, iLigne]);
                    indicateurC += 1;
                    Grid.SetRow(button[iColonne, iLigne], indicateurL);
                }
                indicateurC = 0;
                indicateurL += 1;
            }

        }
    }
}