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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Licznik licznik = new Licznik();
            var result = licznik.AddTwoNumbers(1, 3);
            ResultTextBlock.Text = result.ToString();

            Human human1 = new Human("Mateusz", Helps.Gender.male, new DateTime(1994, 05, 04));
            //human1.BirthDate = new DateTime(1994, 05, 04);
            //human1.Job = "enineer";
            //human1.Name = "Mateusz";
            //human1.Gender = "male";

            Human human2 = new Human("Maja", Helps.Gender.famale, new DateTime(1994, 09, 25));
            //human2.BirthDate = new DateTime(1994, 09, 25);
            //human2.Job = "logistics";
            //human2.Name = "Maja";
            //human2.Gender = "female";

            List<Human> list1 = new List<Human>();
            list1.Add(human1);
            list1.Add(human2);
            List1ListView.ItemsSource = list1;

        }
    }
}
