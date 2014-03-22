using Microsoft.Phone.Controls;
using SDP.ViewModels;
using System.Windows.Navigation;
namespace SDP
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