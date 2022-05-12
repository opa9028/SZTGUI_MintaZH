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
using System.Windows.Shapes;
using SZTGUI_MintaZH.Model;

namespace SZTGUI_MintaZH
{
    /// <summary>
    /// Interaction logic for AddOrEditVersenyzoWindow.xaml
    /// </summary>
    public partial class AddOrEditVersenyzoWindow : Window
    {

        public Versenyzo Versenyzo { get => (this.DataContext as Versenyzo); }

        public AddOrEditVersenyzoWindow()
        {
            InitializeComponent();
        }

        public AddOrEditVersenyzoWindow(Versenyzo v) : this()
        {
            this.DataContext = v;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
