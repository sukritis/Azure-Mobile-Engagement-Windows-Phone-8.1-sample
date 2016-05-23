using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileEngagementDemo
{
    class MethodsList
    {
        //Method to simulate App Crash scenario
        public void DivideByZero()
        {
            int a = 10;
            int b = 0;
            int c = a / b;
        }

        //To return a Dictionary type object for sample data to be uploaded
        public Dictionary<object,object> ReturnExtrasValue()
        {   // Set the extras
            var extras = new Dictionary<object, object>();
            extras.Add("title", "Mobile Engagement");
            extras.Add("type", "image");
            extras.Add("date", "today");
            extras.Add("place", "Mumbai");
            extras.Add("event", "Future Unleashed");
            return (extras);
        }
    
    }
}
