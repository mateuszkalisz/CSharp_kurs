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
            Kolekcje();
            WypisanieKolekcji();
        }

        #region Kolekcje

        int[] tablica = new int[10];
        List<int> lista = new List<int>();

        void Kolekcje()
        {
            for (int i = 0; i < tablica.Length; i=i+2)
            {
                tablica[i] = 1;
            }

            for (int i = 1; i < tablica.Length; i = i + 2)
            {
                tablica[i] = 2;
            }

            for (int i = 5; i < 10; i++)
            {
                lista.Add(i);
            }

        }

        void WypisanieKolekcji()
        {
            ArrayListView.ItemsSource = tablica;
            ListListView.ItemsSource = lista;
        }


        #endregion

    }
}
