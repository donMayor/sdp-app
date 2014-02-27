using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SoundBoard.Resources;
using SoundBoard.ViewModels;
using Coding4Fun.Toolkit.Controls;

namespace SoundBoard
{
    public partial class Courses : PhoneApplicationPage
    {

        
        public Courses()
        {
           
     
             InitializeComponent();
      //      BuildLocalizedApplicationBar();
        }

        
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton loginAppBar =
                new ApplicationBarIconButton();
            loginAppBar.IconUri =
                new Uri("/Assets/images/profile.png", UriKind.Relative);
            loginAppBar.Text = AppResources.AppBarRecord;

            loginAppBar.Click += RegisterClick;

            ApplicationBarIconButton helpAppBar =
                new ApplicationBarIconButton();
            helpAppBar.IconUri =
                new Uri("/Assets/images/profile.png", UriKind.Relative);
            helpAppBar.Text = AppResources.AppBarRecord;

           

            ApplicationBarIconButton aboutAppBar =
                new ApplicationBarIconButton();
            aboutAppBar.IconUri =
                new Uri("/Assets/images/profile.png", UriKind.Relative);
            aboutAppBar.Text = AppResources.AppBarRecord;

            

            ApplicationBarMenuItem aboutMenuAppBar =
                new ApplicationBarMenuItem();
            aboutMenuAppBar.Text = AppResources.AppBarAbout;

            aboutAppBar.Click += AboutClick;

          //  ApplicationBar.Buttons.Add(loginAppBar);
          //  ApplicationBar.Buttons.Add(helpAppBar);
         //   ApplicationBar.Buttons.Add(aboutAppBar);
         //   ApplicationBar.MenuItems.Add(aboutMenuAppBar);
        }


        private void AboutClick(object sender, EventArgs e)
        {
            AboutPrompt aboutMe = new AboutPrompt();

            aboutMe.Show("Channel 9", "@ch9", "ch9@microsoft.com", "http://channel9.msdn.com");
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.RelativeOrAbsolute));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var weekdesc = new MainWeekModel();
            DataContext = weekdesc;
            string strItemIndex;
            if (NavigationContext.QueryString.TryGetValue("index", out strItemIndex))
            {

                courses.SelectedIndex = Convert.ToInt32(strItemIndex);

            }
            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        private void Registration_form(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
        }
    }
}