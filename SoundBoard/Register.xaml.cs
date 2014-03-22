using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Quickteller.Sdk.Wp8;
using SDP.ViewModels;
using System.Collections;
using System.Net.NetworkInformation;
using System.Windows.Media;

namespace SDP
{
    public partial class Register : PhoneApplicationPage
    {

        private const string CLIENT_ID = "IKIA2AE2267493C005F1625472D0E5D5DD0442FB5771";
        private const string CLIENT_SECRET = "cbcOEyWpdpvuG4T7exu2PRfpj0ahWLlJ+E7wkP9Gw6o=";

        private string name;
        private string email;
        private string mobile_num;
        private string password;
        private bool course_selected = false;
        private IList selectedItems;
        string selected;
        bool is_NewInstance = false;
     //   private IList<String> selectedItems;

        public Register()
        {
            
            InitializeComponent();
            is_NewInstance = true;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            base.OnNavigatedTo(e);
            if(is_NewInstance)
                course_added();

            is_NewInstance = false;
        }
        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
           //selectedItems= course_list.SelectedItems;
           // selected= course_list.SelectedItems.ToString();
           //if (selectedItems.Count >= 1)
           //{
           //    course_selected = true;
           //}
           //else
           //{
           //    course_selected = false;
           //}
        }

        private void btnTechQuest_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != "" && Email.Text != "" && Phone_num.Text != "" && (Password.Text == Confirm_password.Text) && Password.Text != "")
            {
              
                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        AssignUserData();
                        Confirm_Dismiss();
                    }else{
                        MessageBoxResult result = MessageBox.Show("Please check your internet connection", "Error", MessageBoxButton.OK);
                    }
               
            }
            else{
                MessageBoxResult result = MessageBox.Show("Some fields are still empty, ensure to fill in all fields appropriately","Error", MessageBoxButton.OK);
            }
        }

        private void PerformPaymentOperation(long amount)
        {
            var quicktellerPayment = new QuicktellerPayment(this, "41924", amount, "0000000001", CLIENT_ID, CLIENT_SECRET);

            quicktellerPayment.OnPaymentCompleted += (e) =>
            {
                //where e is a type of PaymentCompletedEventArgs
                NavigationService.Navigate(new Uri("/PaymentSuccessful.xaml", UriKind.Relative));
            };
            quicktellerPayment.OnPaymentException += (e) =>
            {
                //where e is a type of PaymentExceptionEventArgs
                NavigationService.Navigate(new Uri("/PaymentFailed.xaml?error=" + e.PaymentException.Message, UriKind.Relative));
            };

            quicktellerPayment.DoPayment();
        }

        public void AssignUserData(){
            name = Name.Text;
            email = Email.Text;
            mobile_num = Phone_num.Text;
            password = Password.Text;
        }

        public long Amount()
        {
         // int  count = selectedItems.Count;
          long amount = 3000;
          return amount;
        }

        

        public void Confirm_Dismiss()
        {
            long price = Amount();
            MessageBoxResult result = MessageBox.Show("Email: "+email+"\n"+"Msisdn: "+Phone_num+"\n"+"Amount: "+price+"("+" Courses)"+selected, "Confirmation", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                PerformPaymentOperation(price);
            }
            else
            {
               
            }
                
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/course_list.xaml", UriKind.RelativeOrAbsolute));
        }

        public void course_added()
        {
            TextBlock course_name = new TextBlock();
            course_name.Name = "course_text";
            course_name.Text = "Big Data";
            course_name.Height = 72;
            course_name.FontSize = 25;
            course_text.Children.Add(course_name);
            Button course_button= new Button();
            course_button.Name = "course_button";
            course_button.Content="Remove";
            course_button.Background= new SolidColorBrush(Color.FromArgb(100, 32,165,218));
            course_button.Foreground = new SolidColorBrush(Colors.White);
            course_button.Height = 72;
            course_button.Width = 150;
            coursebutton.Children.Add(course_button);

        }
    }
}