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

namespace UserProject.View.GestionEvenement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MAJEvenement : Page
    {
        public MAJEvenement()
        {
            this.InitializeComponent();
            txttype.Items.Add("Anniversaire");
            txttype.Items.Add("Marriage");
            txttype.Items.Add("Conférence");
        }

        private void txtnom_LostFocus_1(object sender, RoutedEventArgs e)
        {
            if ( txtnom.Text != "")
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

        private void txtdescription_LostFocus(object sender, RoutedEventArgs e)
        {
            if ( txtdescription.Text != "")
            {
                txtdescription.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtdescription.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtdescription.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtdescription.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtlieu_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtlieu.Text.All(Char.IsLetter) && txtnom.Text != "")
            {
                txtlieu.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtlieu.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtlieu.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtlieu.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }

        private void txtdatec_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            if (txtdatec.Date>DateTime.Now.Date)
            {
                txtdatec.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                txtdatec.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
            else
            {
                txtdatec.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                txtdatec.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }
    }
}
