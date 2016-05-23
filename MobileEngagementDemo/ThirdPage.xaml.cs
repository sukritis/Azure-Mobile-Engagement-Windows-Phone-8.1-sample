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
    public partial class ThirdPage : EngagementPage
    {
        MethodsList obj = new MethodsList();

        public ThirdPage()
        {
            InitializeComponent();
        }

        private void BackToMainBtnPage3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }

        protected override string GetEngagementPageName()
        {
            /* By default, the class name of the page is reported as the activity name, with no extra. If the class uses the "Page" suffix, Engagement will also remove it.
               If you want to override the default behavior for the name, simply add this to your code: */
            return "Page 3 navigation";
        }

        private void StandaloneErrorBtn_Click(object sender, RoutedEventArgs e)
        {
            //Contrary to session errors, standalone errors can occur outside of the context of a session
            EngagementAgent.Instance.SendError(StandaloneErrorText.Text, obj.ReturnExtrasValue());
        }

        private void StandaloneEventBtn_Click(object sender, RoutedEventArgs e)
        {
            //Standalone events can occur outside of the context of a session
            EngagementAgent.Instance.SendEvent(StandaloneEventText.Text, obj.ReturnExtrasValue());
        }

        private void SessionEventsBtn_Click(object sender, RoutedEventArgs e)
        {
            //Session events are usually used to report the actions performed by a user during his session.
            // With data :
            EngagementAgent.Instance.SendSessionEvent(SessionEventsText.Text, obj.ReturnExtrasValue());

            /*Without Data
             * EngagementAgent.Instance.SendSessionEvent("sessionEvent");
             * or
             * EngagementAgent.Instance.SendSessionEvent("sessionEvent", null);
             */
        }

        private void JobEventsBtn_Click(object sender, RoutedEventArgs e)
        {
            //Job events are usually used to report the actions performed by a user during a Job.
            EngagementAgent.Instance.SendJobEvent(JobEventsText.Text, "Job Event", obj.ReturnExtrasValue());
        }

        private void SessionErrorBtn_Click(object sender, RoutedEventArgs e)
        {
            // Session errors are usually used to report the errors impacting the user during his session
            EngagementAgent.Instance.SendSessionError(SessionErrorText.Text, obj.ReturnExtrasValue());
        }

        private void JobErrorBtn_Click(object sender, RoutedEventArgs e)
        {
            //Errors can be related to a running job instead of being related to the current user session
            EngagementAgent.Instance.SendJobError(JobErrorText.Text, "Failed Job - Error", obj.ReturnExtrasValue());
        }

    }
}