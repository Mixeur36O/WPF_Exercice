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

namespace _6TTI_Limet_Maxence_Damier
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
            BitmapImage imageButton1 = new BitmapImage();
            BitmapImage imageButton2 = new BitmapImage();
            BitmapImage imageButton3 = new BitmapImage();
            BitmapImage imageButton4 = new BitmapImage();
            BitmapImage imageButton5 = new BitmapImage();
            imageButton.BeginInit();
            imageButton.UriSource = new Uri("assets/p.png", UriKind.Relative);
            imageButton.EndInit();
            imageButton1.BeginInit();
            imageButton1.UriSource = new Uri("assets/k.png", UriKind.Relative);
            imageButton1.EndInit();
            imageButton2.BeginInit();
            imageButton2.UriSource = new Uri("assets/b.png", UriKind.Relative);
            imageButton2.EndInit();
            imageButton3.BeginInit();
            imageButton3.UriSource = new Uri("assets/kn.png", UriKind.Relative);
            imageButton3.EndInit();
            imageButton4.BeginInit();
            imageButton4.UriSource = new Uri("assets/q.png", UriKind.Relative);
            imageButton4.EndInit();
            imageButton5.BeginInit();
            imageButton5.UriSource = new Uri("assets/t.png", UriKind.Relative);
            imageButton5.EndInit();

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
                    Image imButton1 = new Image();
                    Image imButton2 = new Image();
                    Image imButton3 = new Image();
                    Image imButton4 = new Image();
                    Image imButton5 = new Image();
                    imButton.Width = 60;
                    imButton.Height = 60;
                    imButton.HorizontalAlignment = HorizontalAlignment.Center;
                    imButton.VerticalAlignment = VerticalAlignment.Top;
                    imButton.Source = imageButton;
                    imButton1.Source = imageButton1;
                    imButton2.Source = imageButton2;
                    imButton3.Source = imageButton3;
                    imButton4.Source = imageButton4;
                    imButton5.Source = imageButton5;
                    button[iColonne, iLigne] = new Button();
                    button[iColonne, iLigne].FontSize = 50;
                    button[iColonne, iLigne].Height = 100;
                    button[iColonne, iLigne].Width = 100;
                    if (indicateurL == 1 || indicateurL == 6)
                    {
                        button[iColonne, iLigne].Content = imButton;
                    }
                    if (indicateurL == 0 && indicateurC == 0 || indicateurL == 7 && indicateurC == 0 || indicateurL == 0 && indicateurC == 7 || indicateurL == 7 && indicateurC == 7)
                    {

                        button[iColonne, iLigne].Content = imButton5;
                    }
                    if (indicateurL == 0 && indicateurC == 1 || indicateurL == 7 && indicateurC == 1 || indicateurL == 0 && indicateurC == 6 || indicateurL == 7 && indicateurC == 6)
                    {

                        button[iColonne, iLigne].Content = imButton3;
                    }
                    if (indicateurL == 0 && indicateurC == 2 || indicateurL == 7 && indicateurC == 2 || indicateurL == 0 && indicateurC == 5 || indicateurL == 7 && indicateurC == 5)
                    {

                        button[iColonne, iLigne].Content = imButton2;
                    }
                    if (indicateurL == 0 && indicateurC == 3 || indicateurL == 7 && indicateurC == 3 )
                    {

                        button[iColonne, iLigne].Content = imButton1;
                    }
                    if (indicateurL == 0 && indicateurC == 4 || indicateurL == 7 && indicateurC == 4 )
                    {

                        button[iColonne, iLigne].Content = imButton4;
                    }
                    if (indicateurL % 2 == indicateurC % 2)
                    {
                        button[iColonne, iLigne].Background = Brushes.White;
                    }
                    else
                    {
                        button[iColonne, iLigne].Background = Brushes.Black;
                    }
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