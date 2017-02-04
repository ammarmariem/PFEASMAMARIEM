using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AdminProject.View.GestionCompte
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CompteAdmin : Page
    {
        public CompteAdmin()
        {
            this.InitializeComponent();
        }

        private async void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                FileOpenPicker openPicker = new FileOpenPicker();
                openPicker.ViewMode = PickerViewMode.Thumbnail;
                openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
                openPicker.FileTypeFilter.Add(".jpg");
                openPicker.FileTypeFilter.Add(".jpeg");
                openPicker.FileTypeFilter.Add(".png");
                StorageFile file = await openPicker.PickSingleFileAsync();
                BitmapImage img = new BitmapImage();
                var stream = await file.OpenAsync(FileAccessMode.Read);

                var reader = new DataReader(stream.GetInputStreamAt(0));
                var bytes = new byte[stream.Size];
                await reader.LoadAsync((uint)stream.Size);
                reader.ReadBytes(bytes);
                //chaine pour sauvgarder 
                String sc = Convert.ToBase64String(bytes);
                String chimg = sc.ToString();
                String imgch = "";
                byte[] byteBuffer = Convert.FromBase64String(chimg);
                MemoryStream memoryStream = new MemoryStream(byteBuffer, 0, byteBuffer.Length);
                memoryStream.Position = 0;

                BitmapImage bitmapImage = new BitmapImage();
                await bitmapImage.SetSourceAsync(memoryStream.AsRandomAccessStream());
                imgAdmin.Source = bitmapImage;
            }
            catch (Exception ex)
            {
                await new MessageDialog(ex.Message).ShowAsync();
            }
        }

        private void txtnom_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtnom.Text.All(Char.IsLetter) && txtnom.Text != "")
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

        private void txtemail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtemail.Text.Contains(".") == true && txtemail.Text.Contains("@") == true)
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
            if (txtmp.Password.Length > 8)
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
    }
}