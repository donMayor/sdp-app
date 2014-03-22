using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Navigation;


namespace SDP
{
    public partial class PaymentSuccessful : PhoneApplicationPage
    {
        public PaymentSuccessful()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
            }
        }
    }
}