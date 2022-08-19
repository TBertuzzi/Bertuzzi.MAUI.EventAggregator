# Bertuzzi.MAUI.EventAggregator

The EventAggregator provides multicast publish/subscribe functionality. This means there can be multiple publishers that raise the same event and there can be multiple subscribers listening to the same event.

###### This is the component, works on iOS, Android and UWP.

![](https://github.com/TBertuzzi/Bertuzzi.MAUI.EventAggregator/blob/master/Resources/eventAggregator.png?raw=true)

![](https://github.com/TBertuzzi/Bertuzzi.MAUI.EventAggregator/blob/master/Resources/aggregator.gif?raw=true)

**NuGet**

|Name|Info|
| ------------------- | :------------------: |
|Bertuzzi.MAUI.EventAggregator|[![NuGet](https://buildstats.info/nuget/Bertuzzi.MAUI.EventAggregator)](https://www.nuget.org/packages/Bertuzzi.MAUI.EventAggregator/)|

*Platform Support**

Bertuzzi.MAUI.EventAggregator is a MAUI library.

## Setup / Usage

Does not require additional configuration. Just install the package in the shared project and use.

**Sample**

Create a Sample Message

```csharp
    public class TextMessage
    {
        public string Text { get; set; }
    }
```

Register Handler to listen to the event

```csharp

  private void TextHandler(
    TextMessage message)
        {
            Text = message.Text;
        }
        
   //Register Event Handler
            EventAggregator.Instance.RegisterHandler<TextMessage>(
       TextHandler);
```

Send Message 

```csharp
   //Register Event
          
EventAggregator.Instance.SendMessage(TextMessage);
```


The complete example can be downloaded here: <https://github.com/TBertuzzi/Bertuzzi.MAUI.EventAggregator/tree/master/MAUIEventAggregatorSample>

BaseViewModel and Commands used of : https://github.com/jamesmontemagno/mvvm-helpers/tree/master/MvvmHelpers

Based on my package : https://github.com/TBertuzzi/Xamarin.Forms.EventAggregator
