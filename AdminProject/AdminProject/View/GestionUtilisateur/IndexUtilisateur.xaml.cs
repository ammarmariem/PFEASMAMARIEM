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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace AdminProject.View.GestionUtilisateur
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class IndexUtilisateur : Page
    {
        public IndexUtilisateur()
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
            if(txtprenom.Text.all(char.IsLetter)&& txtprenom.Text!="")
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

        private void txtemail_LostFocus(object sender, RoutedEventArgs e)
        {
            if(txtemail.Text.Contains(".")==true && txtemail.Text.Contains("@")==true)
            {
                txtnom.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtnom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
               else { 
                txtnom.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtnom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtmotdepasse_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtmotdepasse.Password.Length>8)
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
    }
}
