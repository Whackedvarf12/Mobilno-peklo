using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Apisli
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<Slika> VsePsi;
        public MainPage()
        {
            this.InitializeComponent();
            VsePsi = new ObservableCollection<Slika>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mojP.IsActive = true;
            mojP.Visibility = Visibility.Visible;
            await KlicServisa.PopulateVsi(VsePsi);
            mojP.IsActive = false;
            mojP.Visibility = Visibility.Collapsed;
        }
    }
}
