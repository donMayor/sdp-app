using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using SDP.Resources;
using SDP.ViewModels;
using System;
using System.Windows.Controls;
using System.Windows.Navigation;
namespace SDP
{
    public partial class MainPage : PhoneApplicationPage
    {
        public Image src = null;
        public static int selectedindex = -1;
        public static bool is_NewInstance = true;
        public static int header = -1;
        public int index = -1;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
         //  var viewModel = new imageViewModel();
            
          
            BuildLocalizedApplicationBar();
            Console.WriteLine("MainPage Loaded");
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {    
            var viewModel = new imageViewModel();
            DataContext = viewModel; 
        }

        private void LongListSelector_SelectionChanged(object sender, 
            SelectionChangedEventArgs e)
        {
       
            LongListSelector selector = sender as LongListSelector;
            if (selector == null)
                return;
            Photo data = selector.SelectedItem as Photo;
            if (data == null)
            {
                return;
            }
            if (data.Title=="Courses")
            {
                header = 0;
                if (data.label == "Big Data")
                {
                    selectedindex = 0;
                }
                else if (data.label == "Python")
                {

                    selectedindex = 1;
                }
                else if (data.label == "Linux Admistration")
                {

                    selectedindex = 2;
                }
                else if (data.label == "Machine Learning")
                {

                    selectedindex = 3;
                }
                else if (data.label == "Image Processing")
                {

                    selectedindex = 4;
                }
                else if (data.label == "GSM Architecture")
                {

                    selectedindex = 5;
                }
                else if (data.label == "Java")
                {

                    selectedindex = 6;
                }
                else if (data.label == "C#")
                {

                    selectedindex = 7;
                }
                else if (data.label == "C++")
                {

                    selectedindex = 8;
                }

                else if (data.label == "Bash")
                {

                    selectedindex = 9;
                }
                else if (data.label == "MySQL")
                {

                    selectedindex = 10;
                }
                else if (data.label == "Artificial Intelligence")
                {

                    selectedindex = 11;
                }
                else if (data.label == "JavaScript")
                {

                    selectedindex = 12;
                }
                else if (data.label == "Perl")
                {

                    selectedindex = 13;
                }
                else if (data.label == "PHP")
                {

                    selectedindex = 14;
                }
                else if (data.label == "Linux Programming")
                {

                    selectedindex = 15;
                }
                else if (data.label == "Web Architecture")
                {

                    selectedindex = 16;
                }

                else if (data.label == "Cloud Computing")
                {

                    selectedindex = 17;
                }
                else if (data.label == "Database Admistration")
                {

                    selectedindex = 18;
                }

                selector.SelectedItem = null;
                if (!(selectedindex == 3 || selectedindex == 4 || selectedindex == 5 || selectedindex == 7 || selectedindex == 8 || selectedindex == 10 || selectedindex == 11 || selectedindex == 15 || selectedindex == 16 || selectedindex == 17 || selectedindex == 18))
                NavigationService.Navigate(new Uri("/course_details.xaml", UriKind.RelativeOrAbsolute));
            }

            else if (data.Title == "Testimonials")
            {
                header = 1;
                if (data.label == "Detan")
                {
                  
                    selectedindex = 0;
                }
                else if (data.label == "Francis")
                {
         
                    selectedindex = 1;
                }
                else if (data.label == "Mayowa")
                {

                    selectedindex = 2;
                }
                else if (data.label == "Emeka")
                {

                    selectedindex = 3;
                }
                else if (data.label == "Tope")
                {

                    selectedindex = 4;
                }
                else if (data.label == "Wale")
                {

                    selectedindex = 5;
                }
                selector.SelectedItem = null;
                NavigationService.Navigate(new Uri("/Testimonial.xaml?index=" + selectedindex, UriKind.RelativeOrAbsolute));
            }
            else if (data.Title == "How we Mentor")
            {
                header = 2;
                if (data.label == "About SDP")
                {
                    selectedindex = 0;
                }
                else if (data.label == "What we offer")
                {

                    selectedindex = 1;
                }
                else if (data.label == "Requirements")
                {

                    selectedindex = 2;
                }
                else if (data.label == "Duration")
                {

                    selectedindex = 3;
                }
                selector.SelectedItem = null;
                NavigationService.Navigate(new Uri("/Mentor.xaml?index=" + selectedindex, UriKind.RelativeOrAbsolute));
            }
            else if (data.Title == "Contacts")
            {
                header = 3;
                if (data.label == "Email")
                {
                    SendEmail();
                }
                else if (data.label == "Facebook")
                {

                    selectedindex = 1;
                }
                else if (data.label == "twitter")
                {

                    selectedindex = 2;
                }
                else if (data.label == "Msisdn")
                {

                    MakeCall();
                }
                selector.SelectedItem = null;
            }
           
        }


        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton recordAudioAppBar = 
                new ApplicationBarIconButton();
            recordAudioAppBar.IconUri = 
                new Uri("/Assets/images/profile.png", UriKind.Relative);
            recordAudioAppBar.Text = "Login";
            recordAudioAppBar.Click += LoginClick;

            ApplicationBarMenuItem aboutAppBar =
                new ApplicationBarMenuItem();
            aboutAppBar.Text = AppResources.AppBarAbout;
            aboutAppBar.Click += AboutClick;


            ApplicationBarIconButton helpAppBar =
                new ApplicationBarIconButton();
            helpAppBar.IconUri =
                new Uri("/Assets/images/help.png", UriKind.Relative);
            helpAppBar.Text = "Help";


            ApplicationBarIconButton abtAppBar =
                new ApplicationBarIconButton();
            abtAppBar.IconUri =
                new Uri("/Assets/images/about.png", UriKind.Relative);
            abtAppBar.Text ="About";
            abtAppBar.Click += About_Click;


            ApplicationBar.MenuItems.Add(aboutAppBar);
            ApplicationBar.Buttons.Add(recordAudioAppBar);
            ApplicationBar.Buttons.Add(helpAppBar);
            ApplicationBar.Buttons.Add(abtAppBar);

        }

        private void About_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Mentor.xaml", UriKind.RelativeOrAbsolute));
        }

        private void AboutClick(object sender, EventArgs e)
        {
            AboutPrompt aboutMe = new AboutPrompt();

            aboutMe.Show("Channel 9", "@ch9", "ch9@microsoft.com", "http://channel9.msdn.com");
        }

        private void LoginClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.RelativeOrAbsolute));
        }
    

    public void SendEmail(){
        try
        {
            EmailComposeTask emailcomposer = new EmailComposeTask();
            emailcomposer.To = "fowe.ade@gmail.com";
            emailcomposer.Cc = "detan.oyedele@gmail.com";
            emailcomposer.Subject = "Skill development Platform";
            emailcomposer.Body = "";

            emailcomposer.Show();
        }catch(SystemException e){
            Console.WriteLine(e.Message);
        }
        }
    public void MakeCall()
    {
        try
        {
            PhoneCallTask callTask = new PhoneCallTask();
            callTask.PhoneNumber = "08034074979";
            callTask.DisplayName = "SDP Client";
            callTask.Show();
        }
        catch (SystemException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private void Register_click(object sender, System.Windows.RoutedEventArgs e)
    {
        NavigationService.Navigate(new Uri("/Register.xaml", UriKind.RelativeOrAbsolute));
    }
    

    }
}