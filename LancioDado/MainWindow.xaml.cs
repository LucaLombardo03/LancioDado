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
            TxtCrediti.MaxLength = 4;
            TxtDado.MaxLength = 1;
        }
        Random random = new Random();
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int da = 1;
            int a = 6;
            int numeroCasuale = random.Next(da, a);
            int crediti = int.Parse(TxtCrediti.Text);
            if (crediti <= 0)
                MessageBox.Show("INSERISCI UN NUMERO DI CREDITI POSITIVO");
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
                    crediti += 40;
                    TxtCrediti.Text = ($"{crediti}");
                    dado.Source = new BitmapImage(new Uri($@"Dadi\dado{numeroCasuale}.png", UriKind.Relative));
                }
                else if (numeroCasuale != n)
                {
                    TxtRisultato.Text = ($"Il numero uscito è {numeroCasuale}. Ritenta!");
                    crediti -= 10;
                    TxtCrediti.Text = ($"{crediti}");
                    dado.Source = new BitmapImage(new Uri($@"Dadi\dado{numeroCasuale}.png", UriKind.Relative));
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Il numero uscito è {numeroCasuale}. Ritenta!");
            }
        }
        private void Image_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            TxtDado.Clear();
            TxtRisultato.Clear();
            TxtCrediti.Clear();
            dado.Source = null;
        }
    }
}
