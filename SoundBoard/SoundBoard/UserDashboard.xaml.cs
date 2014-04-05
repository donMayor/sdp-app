using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SoundBoard.ViewModels;
namespace SoundBoard
{
    public partial class UserDashboard : PhoneApplicationPage
    {
        public UserDashboard()
        {

            InitializeComponent();
        }

       protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var weekdesc = new MainWeekModel();
            DataContext = weekdesc;
 	         base.OnNavigatedTo(e);
        }
    }
}