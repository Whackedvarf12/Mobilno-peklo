using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace stili
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffe : Page
    {
        public Coffe()
        {
            this.InitializeComponent();
            this.c[0] = "";
            this.c[1] = "";
            this.c[2] = "";
        }
        string[] c = new string[3];
        
        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.c[0] = "Brez";
            UpdateCoffee();
        }
        private void UpdateCoffee()
        {
            if(this.c[0].Equals("")||this.c[0].Equals("Brez"))
            {
                cof.Text = "Coffee: Brez";
            }
            else
            {
                cof.Text = "Coffee: " + this.c[0] + " " + this.c[1] + " " + this.c[2];
            }
        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.c[0] = "Črna";
            UpdateCoffee();
        }

        private void MenuFlyoutItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.c[0] = "Srednja";
            UpdateCoffee();
        }

        private void MenuFlyoutItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.c[1] = "Brez";
            UpdateCoffee();
        }

        private void MenuFlyoutItem_Click_5(object sender, RoutedEventArgs e)
        {
            this.c[1] = "Sladkor";
            UpdateCoffee();
        }

        private void MenuFlyoutItem_Click_6(object sender, RoutedEventArgs e)
        {
            this.c[2] = "Brez";
            UpdateCoffee();
        }

        private void MenuFlyoutItem_Click_7(object sender, RoutedEventArgs e)
        {
            this.c[2] = "1,5% Mleko";
            UpdateCoffee();
        }

        private void MenuFlyoutItem_Click_8(object sender, RoutedEventArgs e)
        {
            this.c[2] = "Mleko";
            UpdateCoffee();
        }
    }
}
