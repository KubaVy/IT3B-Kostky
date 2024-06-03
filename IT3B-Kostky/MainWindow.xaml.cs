using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IT3B_Kostky
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
  public MainWindow()
  {
   InitializeComponent();
  }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kostka kostka1 = new Kostka();
            Kostka kostka2 = new Kostka();
            Kostka kostka3 = new Kostka();
            Kostka kostka4 = new Kostka();
            Kostka kostka5 = new Kostka();
            Kostka kostka6 = new Kostka();

            Lab1.Content = kostka1.Hod.ToString();
            Lab2.Content = kostka2.Hod.ToString();
            Lab3.Content = kostka3.Hod.ToString();
            Lab4.Content = kostka4.Hod.ToString();
            Lab5.Content = kostka5.Hod.ToString();
            Lab6.Content = kostka6.Hod.ToString();
        }
    }
}