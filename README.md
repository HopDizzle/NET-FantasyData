# NET-FantasyData
.NET client wrapper for the FantasyData API


___


## usage
In order to begin using the FantasyData client library, you must start by configuring your application with your FantasyData.com API keys. If you don't have these, you can start by logging into your [fantasydata.com](http://fantasydata.com) account and locating the API keys under the **subscriptions** tab.

Once you have your API keys, you'll need to update your application's config file ( App.config or Web.config ). Add a new **section** element to the **configSections** element as follows.

```xml
  <configSections>
    <section name="fantasyData" type="FantasyData.Configuration.FantasyDataSubscriptionRetrieverSection, FantasyData"/>
  </configSections>
```

Next, you'll need to add a **fantasyData** section to your config file.

```xml
<fantasyData defaultSubscription="Trial">
    <subscriptions>
      <add name="Trial" baseUrl="http://api.nfldata.apiphany.com/trial/" primarySubscriptionKey="***primarySubscriptionKey***" secondarySubscriptionKey="***secondarySubscriptionKey***"/>
      <add name="Developer" baseUrl="http://api.nfldata.apiphany.com/developer/" primarySubscriptionKey="***primarySubscriptionKey***" secondarySubscriptionKey="***secondarySubscriptionKey***"/>
    </subscriptions>
</fantasyData>
```

You'll need at least the one subscription under the subscriptions element. 

**Note: Make sure the defaultSubscription attribute of value correlates with the subscription you're intending the application to use.**
