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

namespace UserProject.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Inscription : Page
    {
        public Inscription()
        {
            this.InitializeComponent();
        }

        private void txtnom_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtnom.Text.All(Char.IsLetter) && txtnom.Text!="")
            {
                txtnom.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtnom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtnom.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtnom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtprenom_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtprenom.Text.All(Char.IsLetter) && txtprenom.Text != "")
            {
                txtprenom.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtprenom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtprenom.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtprenom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txttel_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txttel.Text.All(Char.IsNumber) && txttel.Text.Length ==8)
            {
                txttel.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txttel.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txttel.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txttel.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtcin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtcin.Text.All(Char.IsNumber) && txtcin.Text.Length == 8)
            {
                txtcin.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtcin.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtcin.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtcin.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtdate_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            if (txtdate.Date.Year+18<DateTime.Now.Date.Year)
            {
                txtdate.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtdate.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtdate.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtdate.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtemail_LostFocus(object sender, RoutedEventArgs e)
        {
            if ((txtemail.Text.Contains("@") && txtemail.Text.Contains("."))|| txtemail.Text.Contains(" ")==false)
            {
                txtemail.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtemail.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtemail.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtemail.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtmp_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtmp.Password.Length>8)
            {
                txtmp.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtmp.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtmp.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtmp.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtcmp_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtcmp.Password==txtmp.Password)
            {
                txtcmp.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtcmp.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtcmp.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtcmp.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void btnretour_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Connexion));
        }
    }
}
