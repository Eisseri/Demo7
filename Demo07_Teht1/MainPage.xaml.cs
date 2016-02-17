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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo07_Teht1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void trucksButton_Click(object sender, RoutedEventArgs e)
        {
            // haetaan käyttöliittymästä trucksTextBlock teksti
            string trucksString = trucksTextBlock.Text; // "0"
            int trucks = int.Parse(trucksString); // muuttui numeroksi
            // lisätään yksi
            trucks++; // trucks = trucks +1;
            // näytetään uusi lukumäärä
            trucksTextBlock.Text = trucks.ToString();
        }


        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            string carString = carTextBlock.Text;
            int car = int.Parse(carString);
            car++;
            carTextBlock.Text = car.ToString();

        }
    }
}
