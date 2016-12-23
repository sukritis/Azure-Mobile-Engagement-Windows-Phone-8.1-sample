# AzMEWP81sample
Azure Mobile Engagement sample for Windows Phone 8.1 with all basic features of AzME including error, crash, job, event reporting as well as Reach

Features:
1. This Sample has a basic UI consisting of 3-page navigation.
2. You can connect to your mobile engagement service and view all the data.
3. Simulate Crashes to view instantaneously on the Azure Mobile Engagement portal
4. Simulate Errors as well as custom errors with specific Events.
5. Capture Job durations - can be used to identify how long the user spent in the app finishing a particular activity.
6. View USer Path on portal with each page navigation as a new "Activity" recorded as well as starting your custom activity on the same page.

What you need to do to get this sample working:
You will need to copy the connection string from Connection Info in your Mobile Engagement App on the Azure portal and paste it in the Resources\EngagementConfiguration.xml file, between the <connectionString> and </connectionString> tags.


To ensure you don't miss how to connect your app to the Store and how to create a Mobile Engagement app on Azure see this link: https://azure.microsoft.com/en-in/documentation/articles/mobile-engagement-windows-store-dotnet-get-started/
