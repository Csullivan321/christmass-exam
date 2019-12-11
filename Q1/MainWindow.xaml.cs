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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Players> allPLayers;
        List<Players> selectedPlayers;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            allPLayers = GetPlayers();
            selectedPlayers = new List<Players>();
            allPLayers.Sort();
        }
        private List<Players>GetPlayers()
        {
            List<Players> allPlayers = new List<Players>();

            Players p1 = new Players()
            {
                First_Name = "Chris",
                Surname = "Heally",
                Preferred_Position = Position.Midfielder,
                Date_Of_Birth = new DateTime(1997, 2, 28)

            };
            Players p2 = new Players()
            {
                First_Name = "Mike",
                Surname = "Heally",
                Preferred_Position = Position.Midfielder,
                Date_Of_Birth = new DateTime(1996, 2, 28)

            };
            Players p3 = new Players()
            {
                First_Name = "Chris",
                Surname = "Mathhew",
                Preferred_Position = Position.Midfielder,
                Date_Of_Birth = new DateTime(1995, 1, 28)

            };
            Players p4 = new Players()
            {
                First_Name = "Matt",
                Surname = "Oneill",
                Preferred_Position = Position.Midfielder,
                Date_Of_Birth = new DateTime(1994, 2, 28)

            };
            Players p5 = new Players()
            {
                First_Name = "Rob",
                Surname = "Francis",
                Preferred_Position = Position.Midfielder,
                Date_Of_Birth = new DateTime(1993, 2, 28)

            };
            Players p6 = new Players()
            {
                First_Name = "Matt",
                Surname = "Heally",
                Preferred_Position = Position.Midfielder,
                Date_Of_Birth = new DateTime(1997, 2, 28)

            };
            Players p7 = new Players()
            {
                First_Name = "Chris",
                Surname = "Heally",
                Preferred_Position = Position.Defender,
                Date_Of_Birth = new DateTime(1995, 2, 28)

            };
            Players p8 = new Players()
            {
                First_Name = "Sean",
                Surname = "Sweeney",
                Preferred_Position = Position.Defender,
                Date_Of_Birth = new DateTime(1997, 2, 28)

            };
            Players p9 = new Players()
            {
                First_Name = "Chris",
                Surname = "Heally",
                Preferred_Position = Position.Defender,
                Date_Of_Birth = new DateTime(1993, 2, 28)

            };
            Players p10 = new Players()
            {
                First_Name = "Chris",
                Surname = "Heally",
                Preferred_Position = Position.Defender,
                Date_Of_Birth = new DateTime(1998, 2, 28)

            };
            Players p11 = new Players()
            {
                First_Name = "Luke",
                Surname = "Oreilly",
                Preferred_Position = Position.Defender,
                Date_Of_Birth = new DateTime(1993, 2, 28)

            };
            Players p12 = new Players()
            {
                First_Name = "Lucy",
                Surname = "Beirne",
                Preferred_Position = Position.Defender,
                Date_Of_Birth = new DateTime(1994, 2, 28)

            };
            Players p13 = new Players()
            {
                First_Name = "Michael",
                Surname = "Daly",
                Preferred_Position = Position.Forward,
                Date_Of_Birth = new DateTime(1996, 2, 28)

            };
            Players p14 = new Players()
            {
                First_Name = "Adam",
                Surname = "Doyle",
                Preferred_Position = Position.Forward,
                Date_Of_Birth = new DateTime(1994, 2, 28)

            };
            Players p15 = new Players()
            {
                First_Name = "Ava",
                Surname = "Dunne",
                Preferred_Position = Position.Forward,
                Date_Of_Birth = new DateTime(1997, 2, 28)

            };
            Players p16 = new Players()
            {
                First_Name = "Emily",
                Surname = "Murphy",
                Preferred_Position = Position.Forward,
                Date_Of_Birth = new DateTime(1994, 2, 28)

            };
            Players p17 = new Players()
            {
                First_Name = "Noah",
                Surname = "Walsh",
                Preferred_Position = Position.Goalkeeper,
                Date_Of_Birth = new DateTime(1994, 2, 28)

            };
            Players p18 = new Players()
            {
                First_Name = "Harry",
                Surname = "Murphy",
                Preferred_Position = Position.Goalkeeper,
                Date_Of_Birth = new DateTime(1996, 2, 28)

            };
            allPlayers.Add(p1);
            allPLayers.Add(p2);
            allPLayers.Add(p3);
            allPLayers.Add(p4);
            allPLayers.Add(p5);
            allPLayers.Add(p6);
            allPLayers.Add(p7);
            allPLayers.Add(p8);
            allPLayers.Add(p9);
            allPLayers.Add(p10);
            allPLayers.Add(p12);
            allPLayers.Add(p13);
            allPLayers.Add(p14);
            allPLayers.Add(p15);
            allPLayers.Add(p16);
            allPLayers.Add(p17);
            allPLayers.Add(p18);

            return allPLayers;
        }


        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Players selectedPlayer = lstbx1.SelectedItem as Players;
            if(selectedPlayer != null)
            {
                allPLayers.Add(selectedPlayer);
                //selectedPlayers.Remove;
            }
        }


        private void Lstbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Players selectedplayer = lstbx1.SelectedItem as Players;
            //if (selectedplayer != null)
             
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Players selectedPlayers = lstbx2.SelectedItem as Players;
            if(selectedPlayers != null)
            {
                allPLayers.Remove(selectedPlayers);
                //selectedPlayers.Add;
                
            }
        }
    }
}
