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
using System.Diagnostics;

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
        Button course_button;
        TextBlock course_name;
        String[] courses = { "Big Data", "Python", "Linux Administration", "Machine Learning", "Image Processing", "GSM Architecture", "Java", "C#", "C++", "Bash", "MySQL", "Artificial Intelligence", "JavaScript", "Perl", "php", "Linux Programming", "Web Architecture", "Cloud Computing" ,"Database Administration"};
        public static List<String> selected_course;
        public static List<String> sorted_course;
        public static List<Boolean> selected_course_bool;

        public Register()
        {
            
            InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {


            if (MainPage.is_NewInstance)
            {
                selected_course = new List<String>();
                selected_course_bool = new List<Boolean>();
                
            }
            string result;
            if (MainPage.is_NewInstance)
            {
                if (NavigationContext.QueryString.TryGetValue("index", out result))
                {
                    int selectedIndex = Convert.ToInt32(result);
                    selected_course.Add(courses[selectedIndex]);
                    selected_course_bool.Add(true);
                }
            }
            else
            {
          
               
                foreach (listcourse course in course_list.course_from_list)
                {
                    if(!selected_course.Contains(course.coursename)){
                        selected_course.Add(course.coursename);
                        selected_course_bool.Add(true);
                    }
                   
                }
            }
            course_added();
            base.OnNavigatedTo(e);
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
            if (Name.Text != "" && Email.Text != "" && Phone_num.Text != "" && (Password.Password == Confirm_password.Password) && Password.Password != "")
                {
                if(is_RegisteredCourse(selected_course)){
                
                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        AssignUserData();
                        Confirm_Dismiss();
                    }else{
                        MessageBoxResult result = MessageBox.Show("Please check your internet connection", "Error", MessageBoxButton.OK);
                    }
                }
                else{
                     MessageBoxResult result = MessageBox.Show("Please select atleast a course to register", "Error", MessageBoxButton.OK);
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
            password = Password.Password;
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
            MessageBoxResult result = MessageBox.Show("Email: "+email+"\n"+"Msisdn: "+Phone_num+"\n"+"Amount: "+price+"("+sorted_course.Count+" Courses)", "Confirmation", MessageBoxButton.OKCancel);
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

            for (int i = 0; i<selected_course.Count; i++)
            {

                if(selected_course_bool.ElementAt(i)){
                    course_name = new TextBlock();
                    course_name.Name = "course_"+i;
                    course_name.Text = selected_course.ElementAt(i);
                    course_name.Height = 72;
                    course_name.FontSize = 25;
                    course_text.Children.Add(course_name);
                    course_button = new Button();
                    course_button.Name = "button_"+i;
                    course_button.Content = "Remove";
                    course_button.Background = new SolidColorBrush(Color.FromArgb(100, 32, 165, 218));
                    course_button.Foreground = new SolidColorBrush(Colors.White);
                    course_button.Click += new RoutedEventHandler(RemoveCourse);
                    course_button.Height = 72;
                    course_button.Width = 150;
                    coursebutton.Children.Add(course_button);
                    selected_course_bool.RemoveAt(i);
                    selected_course_bool.Insert(i, false);
                    
                }
                else
                {

                }
            }
        }

        void RemoveCourse(object sender, RoutedEventArgs e)
        {
           
                String name = (sender as Button).Name;
                Debug.WriteLine(name.Substring(name.IndexOf("_") + 1)+"print");
                int position = Convert.ToInt32( name.Substring(name.IndexOf("_")+1));
                coursebutton.Children.Remove((UIElement)this.FindName((sender as Button).Name));
                course_text.Children.Remove((UIElement)this.FindName("course_" + position));
                selected_course.RemoveAt(position);
                selected_course.Insert(position, "invalid");
        }
        bool is_RegisteredCourse(List<String> sorted)
        {
            sorted_course = new List<String>();
            for (int i = 0; i < sorted.Count; i++)
            {
                sorted_course.Add(sorted.ElementAt(i));
            }
          
          sorted_course.RemoveAll(EndWithInvalid);
          if (sorted_course.Count >= 1)
          {
              return true;
          }
          else
          {
              return false;
          }
        }

        private static bool EndWithInvalid(String course)
        {
            return course.ToLower().EndsWith("invalid");
        }
    }
}