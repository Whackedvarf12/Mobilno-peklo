using System;
using System.Collections.Generic;
using System.IO;
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

namespace Povezovanje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Podatki> VsiPodatki = new List<Podatki>();
        CollectionViewSource podatkiViewSource;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            podatkiViewSource =(CollectionViewSource)FindResource("podatkiViewSource");
            StreamReader st = new StreamReader(@"D:\mobilno-peklo\vaja.csv");
            string Vrstica = st.ReadLine();
            while(Vrstica!=null){
                string[] p = Vrstica.Split(';');
                Podatki po = new Podatki();
                po.Id = int.Parse(p[0]);
                po.Datum = DateTime.Parse(p[1]);
                po.Ime = p[2];
                po.Znesek = double.Parse(p[3]);
                VsiPodatki.Add(po);
                Vrstica = st.ReadLine();
            }
            st.Close();
            DataContext = this;
            podatkiViewSource.Source = VsiPodatki;
        }
    }
}
