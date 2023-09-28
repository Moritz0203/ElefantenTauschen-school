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

namespace ElefantenTauschen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Elefant ersterElefant, zweiterElefant, ZwischenspeicherElefant;
        bool oneTime = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_ersterElefant_Click(object sender, RoutedEventArgs e)
        {
            if (ersterElefant == null)
            {
                ersterElefant = new Elefant("Ermir", 80);
                bt_ersterElefant.Content = ersterElefant.Name;
                bt_Wachsen.IsEnabled = true;
            }
            else
            {
                MessageBox.Show(ersterElefant.WerBinIch());
            }

            if (ersterElefant != null && zweiterElefant != null && oneTime == false)
            {
                bt_Tauschen.IsEnabled = true;
                oneTime = true;
            }
        }

        private void bt_zweiterElefant_Click(object sender, RoutedEventArgs e)
        {
            if (zweiterElefant == null)
            {
                zweiterElefant = new Elefant("Jonas", 60);
                bt_zweiterElefant.Content = zweiterElefant.Name;
            }
            else
            {
                MessageBox.Show(zweiterElefant.WerBinIch());
            }

            if (ersterElefant != null && zweiterElefant != null && oneTime == false)
            {
                bt_Tauschen.IsEnabled = true;
                oneTime = true;
            }
        }

        private void bt_Wachsen_Click(object sender, RoutedEventArgs e)
        {
            ersterElefant.ElefantenGröße += 5;
            TextBlockStatus.Text = ersterElefant.WieGroßBinIch();
        }

        private void bt_Tauschen_Click(object sender, RoutedEventArgs e)
        {
            ZwischenspeicherElefant = ersterElefant;
            ersterElefant = zweiterElefant;
            zweiterElefant = ZwischenspeicherElefant;
            TextBlockStatus.Text = "";
            bt_Name();
        }

        private void bt_Name()
        {
            bt_ersterElefant.Content = ersterElefant.Name;
            bt_zweiterElefant.Content = zweiterElefant.Name;
        }

    }
}
