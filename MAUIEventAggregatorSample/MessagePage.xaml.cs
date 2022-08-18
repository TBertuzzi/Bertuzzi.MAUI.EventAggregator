using MAUIEventAggregatorSample.ViewModels;

namespace MAUIEventAggregatorSample;

public partial class MessagePage : ContentPage
{
	public MessagePage()
	{
		InitializeComponent();

        this.BindingContext = new MessageViewModel();
    }
}