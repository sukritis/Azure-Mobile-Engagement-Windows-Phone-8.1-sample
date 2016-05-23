using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MobileEngagementDemo.Resources;
using Microsoft.Azure.Engagement;



namespace MobileEngagementDemo
{
    public partial class MainPage : EngagementPage 
    {
        MethodsList obj = new MethodsList();

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override string GetEngagementPageName()
        {
            /* By default, the class name of the page is reported as the activity name, with no extra. If the class uses the "Page" suffix, Engagement will also remove it.
               If you want to override the default behavior for the name, simply add this to your code: */
            return "App Launched Page 1";
        }

        private void CrashButton_Click(object sender, RoutedEventArgs e)
        {
            obj.DivideByZero();
            //EngagementAgent.Instance.SendCrash(aCatchedException);
            /*You can also use an optional parameter to terminate the engagement session at the same time than
             * sending the crash. To do so, call :*/
        }

        private void Page2Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SecondPage.xaml", UriKind.Relative));
        }

        private void Page3Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ThirdPage.xaml", UriKind.Relative));
        }

        private void JobButton_Click(object sender, RoutedEventArgs e)
        {
            //You can use the job to track certains tasks over a period of time

            // An upload begins...

            EngagementAgent.Instance.StartJob(JobTextbox.Text, obj.ReturnExtrasValue());

            //EngagementAgent.Instance.StartJob("uploadData", extras);

            //report Event for Start of the Job with the name that the user entered
            EngagementAgent.Instance.SendJobEvent("Job Started", JobTextbox.Text, obj.ReturnExtrasValue());
        }


        private void EndJobBtn_Click(object sender, RoutedEventArgs e)
        {
            /* As soon as a task tracked by a job has been terminated, you should call the EndJob method for this job,
             * by supplying the job name*/

            // In the previous section, we started an upload tracking with a job
            // Then, the upload ends

            EngagementAgent.Instance.EndJob(JobTextbox.Text);
            //EngagementAgent.Instance.EndJob("uploadData");

        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}