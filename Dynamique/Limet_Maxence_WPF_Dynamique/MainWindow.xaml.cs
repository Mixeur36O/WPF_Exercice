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

namespace Limet_Maxence_WPF_Dynamique
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
            //Céation des objets
            TextBlock textB1 = new TextBlock();
            TextBlock textB2 = new TextBlock();
            TextBox textBox1 = new TextBox();
            ComboBox comboBox1 = new ComboBox();
            StackPanel stkBloc1 = new StackPanel();
            ColumnDefinition[] colDef = new ColumnDefinition[3];
            RowDefinition[] rowDef = new RowDefinition[3];
            Button[] buttons = new Button[3];
            for (int i = 0; i < 3; i++)
            {
                colDef[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(colDef[i]);
            }

            for (int i = 0;i < 3; i++)
            {
                rowDef[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef[i]);
            }

            //Première ligne
            textB1.Text = "TextBlock créé dynamiquement";
            textB1.Foreground = Brushes.Red;
            textB1.Background = Brushes.Yellow;
            grdMain.Children.Add(textB1);
            Grid.SetColumnSpan(textB1, 3);

            //Deuxième Ligne
            //Boutons
            for (int i = 0; i < 3; i++) 
            {
                buttons[i] = new Button();
                buttons[i].Height = 100;
                buttons[i].Width = 100;
                buttons[i].HorizontalAlignment = HorizontalAlignment.Center;
                buttons[i].VerticalAlignment = VerticalAlignment.Center;
                grdMain.Children.Add(buttons[i]);
            }

            buttons[0].Content = "BOUTON 1";
            Grid.SetColumn(buttons[0], 0);
            Grid.SetRow(buttons[0], 1);
            buttons[1].Content = "BOUTON 2";
            Grid.SetColumn(buttons[1], 1);
            Grid.SetRow(buttons[1], 1);
            buttons[2].Content = "BOUTON 3";
            Grid.SetColumn(buttons[2], 2);
            Grid.SetRow(buttons[2], 1);

            //Troisième ligne
            //TextBlock
            textB2.Text = "Infos :";
            textB2.Background = Brushes.Yellow;

            //TextBox
            textBox1.Text = "J'attends vos infos";

            //StackPanel
            stkBloc1.Children.Add(textB2);
            stkBloc1.Children.Add(textBox1);
            grdMain.Children.Add(stkBloc1);
            Grid.SetColumnSpan(stkBloc1, 1);
            Grid.SetRow(stkBloc1, 2);

            //ComboBox
            grdMain.Children.Add(comboBox1);
            Grid.SetColumn(comboBox1, 2);
            Grid.SetRow(comboBox1, 2);

        }
    }
}