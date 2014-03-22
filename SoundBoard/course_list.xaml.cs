using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SDP.ViewModels;

namespace SDP
{
    public partial class course_list : PhoneApplicationPage
    {
        public course_list()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var viewModel = new Listmodel();
            DataContext = viewModel;
        }


        private void cour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}