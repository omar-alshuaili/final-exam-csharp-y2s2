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

namespace OmarAlshuaili_s00190262
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameData db = new GameData();
        List<Game> Filtergame = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //display all games
            var q = from g in db.games
                    select g;
            gameListBox.ItemsSource = q.ToList();
        }

        private void gameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get the selected item
            var selectedItem = gameListBox.SelectedItem as Game;
            //check if null
            if (selectedItem != null)
            {
                priceTBL.Text = selectedItem.Price.ToString();
                DesTBL.Text = selectedItem.Description.ToString();
                PlatTBL.Text = selectedItem.Platform.ToString();
              
            }
        
        }

        private void allRB_Checked(object sender, RoutedEventArgs e)
        {
            //get all games
            var q = from g in db.games
                    select g;
            gameListBox.ItemsSource = q.ToList();

        }

        private void PsRB_Checked(object sender, RoutedEventArgs e)
        {
            //update list box
            update("Ps");

        }

        private void XboxRB_Checked(object sender, RoutedEventArgs e)
        {
            //update list box
            update("Xbox");

            

        }

        private void PcRB_Checked(object sender, RoutedEventArgs e)
        {
            //update list box
            update("Pc");
        }

        private void SwitchRB_Checked(object sender, RoutedEventArgs e)
        {
            //update list box
            update("Switch");
           
        }
        public void update(string platform)
        {
            gameListBox.ItemsSource = null;
            //clear the filtered list
            Filtergame.Clear();

            var q = from Pc in db.games
                    where Pc.Platform.Contains(platform)
                    select Pc;
            var result = q.ToList();

            foreach (var item in result)
            {
                Filtergame.Add(item);
            }
            //display the filtered list
            gameListBox.ItemsSource = Filtergame;
        }
    }
}
