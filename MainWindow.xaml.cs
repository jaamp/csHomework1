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

namespace homework1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool uxNameBool = true;
        bool uxPassBool = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (uxName.Text == "")
            {
                uxNameBool = true;
            }
            else uxNameBool = false;

            ChangeSubmit();
        }

        private void UxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (uxPassword.Text == "")
            {
                uxPassBool = true;
            }
            else uxPassBool = false;

            ChangeSubmit();
        }

        private void ChangeSubmit()
        {
            if (!uxNameBool && !uxPassBool)
            {
                uxSubmit.IsEnabled = true;
            }
            else uxSubmit.IsEnabled = false;
        }
    }
}
