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

namespace LImet_Maxence_Dynamique_Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            ColumnDefinition[] colDef = new ColumnDefinition[4];
            RowDefinition[] rowDef = new RowDefinition[4];
            TextBlock[,] textBlock = new TextBlock[4,4];

            //Faire la grille
            for (int i = 0; i < 4; i++)
            {
                colDef[i] = new ColumnDefinition();
                rowDef[i] = new RowDefinition();
                grdMain.ColumnDefinitions.Add(colDef[i]);
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            //Faire apparaître les cases de ?
            for (int iColonne = 0; iColonne < textBlock.GetLength(0); iColonne++)
            {
                for (int iLigne = 0; iLigne < textBlock.GetLength(1); iLigne++)
                {
                    textBlock[iColonne, iLigne] = new TextBlock();
                    textBlock[iColonne, iLigne].Text = "?";
                    textBlock[iColonne, iLigne].HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock[iColonne,iLigne].VerticalAlignment = VerticalAlignment.Center;
                    textBlock[iColonne, iLigne].FontSize = 50;
                    Grid.SetColumn(textBlock[iColonne, iLigne],indicateurC);
                    grdMain.Children.Add(textBlock[iColonne,iLigne]);
                    indicateurC += 1;
                    Grid.SetRow(textBlock[iColonne, iLigne], indicateurL);
                }
                indicateurC = 0;
                indicateurL += 1;
            }




        }
    }
}