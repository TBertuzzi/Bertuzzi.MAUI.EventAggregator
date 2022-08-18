using MAUIEventAggregatorSample.ViewModels;

namespace MAUIEventAggregatorSample
{
    public partial class MainPage : ContentPage
    {
   
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

    }
}