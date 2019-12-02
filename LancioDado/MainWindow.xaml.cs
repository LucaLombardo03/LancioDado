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

namespace LancioDado
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
        private void Lancio_Click(object sender, RoutedEventArgs e)
        { 
            int da = 1;
            int a = 6;
            Random random = new Random();
            int numeroCasuale = random.Next(da, a);
            try
            {
                int n = int.Parse(TxtDado.Text);
                if (n >= 7 || n <= 0)
                { 
                    MessageBox.Show("INSERISCI UN NUMERO DA 1 A 6!!!!");
                }
                else if (numeroCasuale == n)
                {
                    TxtRisultato.Text = ($"Il numero uscito è {numeroCasuale}. Complimenti!Hai vinto!");
                }
                else if (numeroCasuale != n)
                {
                    throw new Exception($"Il numero uscito è {numeroCasuale}. Ritenta!");       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Il numero uscito è {numeroCasuale}. Ritenta!");
            }
        }

        private void Ricomincia_Click(object sender, RoutedEventArgs e)
        {
            TxtDado.Clear();
            TxtRisultato.Clear();
        }
    }
}
