using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Azure.Engagement;

namespace MobileEngagementDemo
{
    public partial class SecondPage : PhoneApplicationPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void BacktoMainBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }

        /*If you cannot or do not want to overload your PhoneApplicationPage classes, you can instead start your activities by calling 
         * EngagementAgent methods directly.
         * We recommend to call StartActivity inside your OnNavigatedTo method of your PhoneApplicationPage
         */
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            EngagementAgent.Instance.StartActivity("Manual Activity Start Page 2");
        }

        /*You need to call StartActivity() each time the user activity changes. 
         * The first call to this function starts a new user session
         * The Windows Phone SDK automatically call the EndActivity method when the application is closed. 
         * Thus, it is HIGHLY recommended to call the StartActivity method whenever the activity of the user change,
         * and to NEVER call the EndActivity method, since calling this method forces the current session to be ended.
         */
        private void ActivityBtn1_Click(object sender, RoutedEventArgs e)
        {
            EngagementAgent.Instance.StartActivity(Activity1Text.Text);
            //EngagementAgent.Instance.StartActivity("Page 2 Activity 1");
        }

        private void ActivityBtn2_Click(object sender, RoutedEventArgs e)
        {
            EngagementAgent.Instance.StartActivity(Activity2Text.Text);
            //EngagementAgent.Instance.StartActivity("Page 2 Activity 2");

        }

        //protected override string GetEngagementPageName()
        //{
        //    /* By default, the class name of the page is reported as the activity name, with no extra. If the class uses the "Page" suffix, Engagement will also remove it.
        //       If you want to override the default behavior for the name, simply add this to your code: */
        //    return "Page 2 navigation";
        //}
    }
}