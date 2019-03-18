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
using WpfRPGGenerator.Model;
using WpfRPGGenerator.ViewModel;

namespace WpfRPGGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModelRPG vmRPG;
        RPG rpg;

        public MainWindow()
        {
            InitializeComponent();
            rpg = new RPG();
            vmRPG = new ViewModelRPG(rpg);
        }

        private void UserControlRPG1_Loaded(object sender, RoutedEventArgs e)
        {
            UserControlRPG1.DataContext = vmRPG;
        }
    }
}
