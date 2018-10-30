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
            Instrukcje();
        }

        #region Instrukcje

        private void Instrukcje()
        {
            
            #region ify

            //var warunek = false;
            ////TestowyTextBlock.Text = (warunek) ? "Prawda" : "Fałsz";

            //if(!warunek)
            //{
            //    TestowyTextBlock.Text = "Falsz";
            //}
            //else
            //{
            //    TestowyTextBlock.Text = "Prawda";
            //}
            #endregion

            #region switche

            var liczba = 1; //0 nie dziala // 2 moze dziala // 1 dziala
            switch (liczba)
            {
                case 0: TestowyTextBlock.Text = "Nie działa"; break;
                case 1: TestowyTextBlock.Text = "Działa"; break;
                case 2: TestowyTextBlock.Text = "Moze dziala"; break;
                default:
                    break;
            }
            #endregion


        }

        #endregion

    }
}
