using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Navigation;

namespace SDP
{
    public partial class PaymentFailed : PhoneApplicationPage
    {
        private string Message = "Failure erorr message...";

        public PaymentFailed()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NavigationContext.QueryString.TryGetValue("error", out Message);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
            }
        }
    }
}