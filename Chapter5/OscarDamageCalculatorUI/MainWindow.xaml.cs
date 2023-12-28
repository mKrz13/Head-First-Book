using System.ComponentModel.DataAnnotations;
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

namespace OscarDamageCalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        SwordDamage swordDamage = new SwordDamage();

        public MainWindow()
        {
            InitializeComponent();
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(false);
            RollDice();



        }

        private void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            swordDamage.SetMagic(magic.IsChecked.Value);
            swordDamage.SetFlaming(flaming.IsChecked.Value);

            DisplayDamage();
        }

        private void DisplayDamage()
        {
            damage.Text = $"Rzut: {swordDamage.Roll}, punkty obrażen: {swordDamage.Damage}";
        
        }

        private void flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(true);
            DisplayDamage();
        }

        private void magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(true);
            DisplayDamage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }

        private void flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(false);
            DisplayDamage();

        }

        private void magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(false);
            DisplayDamage();

        }
    }
}