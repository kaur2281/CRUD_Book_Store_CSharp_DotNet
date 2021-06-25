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
        List<Books> bookArr = new List<Books>() { new Books() { Title="Harry Potter" , Genre="Fiction", Isbn=5652, Price= 11.2  }, new Books(){ Title = "Harry Potter2", Genre = "Fiction", Isbn = 5653, Price = 15.5 } };
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

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            Books b1 = new Books();
            b1.Title = txtTitle.Text;
            if (rbtnFiction.IsChecked == true) b1.Genre = rbtnFiction.Content.ToString();
            else if (rbtnScifi.IsChecked == true) b1.Genre = rbtnScifi.Content.ToString();
            else b1.Genre = rbtnSports.Content.ToString();
            b1.Isbn = Convert.ToInt32(txtIsbn.Text);
            b1.Price = Convert.ToDouble(txtPrice.Text);

            bookArr.Add(b1);
            MessageBox.Show("Book Added!");
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = bookArr;
        }

        private void dataGrid_Unloaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
        }
    }
}
