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
            EnumGetValue();
        }

        #region enumy

        enum CharacterConditions 
        {
            Run,
            Jump,
            Swim
        }

        void EnumGetValue()
        {
            CharacterConditions enumix = CharacterConditions.Run;

            switch (enumix)
            {
                case CharacterConditions.Run:
                    break;
                case CharacterConditions.Jump:
                    break;
                case CharacterConditions.Swim:
                    break;
                default:
                    break;
            }

            var enumvalues = Enum.GetValues(typeof(CharacterConditions));
            enumListView.ItemsSource = enumvalues;
            enumTextBlock.Text = enumix.ToString();
        }

        #endregion

    }
}
