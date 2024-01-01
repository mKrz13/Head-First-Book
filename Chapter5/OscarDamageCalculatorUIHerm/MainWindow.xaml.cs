using System;
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

namespace OscarDamageCalculatorUIHerm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SwordDamage swordDamage;
        static Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            swordDamage = new SwordDamage(RollDice());
            DisplayDamage();
        }



        private static int RollDice()
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            swordDamage.Roll = RollDice();
            DisplayDamage();
        }

        private void DisplayDamage()
        {
            damage.Text = $"Rzut: {swordDamage.Roll}, punkty obrażen: {swordDamage.Damage}";

        }

        private void flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = true;
            DisplayDamage();
        }

        private void flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = false;
            DisplayDamage();
        }

        private void magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = true;
            DisplayDamage();
        }

        private void magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = false;
            DisplayDamage();
        }
    }
}