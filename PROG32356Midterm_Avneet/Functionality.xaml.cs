using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROG32356Midterm_Avneet
{
    /// <summary>
    /// Interaction logic for Functionality.xaml
    /// </summary>
    public partial class Functionality : Window
    {
        public Functionality()
        {
            InitializeComponent();
        }

        private void btnGotoLandingPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m1 = new MainWindow();
            m1.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
