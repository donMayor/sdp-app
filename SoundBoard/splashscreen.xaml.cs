using Microsoft.Phone.Controls;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;

namespace SDP
{
    public partial class splashscreen : PhoneApplicationPage
    {
        private Popup popup;
        private BackgroundWorker backroungWorker;
        public splashscreen()
        {
            InitializeComponent();
            ShowSplash();
        }

        private void StartLoadingData()
        {
            backroungWorker = new BackgroundWorker();
            backroungWorker.DoWork += new DoWorkEventHandler(backroungWorker_DoWork);
            backroungWorker.RunWorkerCompleted +=
          new RunWorkerCompletedEventHandler(backroungWorker_RunWorkerCompleted);
            backroungWorker.RunWorkerAsync();
        }
        void backroungWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }
        void backroungWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(() =>
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
            });
        }

        private void ShowSplash()
        {
            this.popup = new Popup();
          //  this.popup.Child = new SplashScreenControl();
            this.popup.IsOpen = true;
            StartLoadingData();
        }
    }
}