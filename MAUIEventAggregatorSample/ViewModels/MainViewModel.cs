using Bertuzzi.MAUI.EventAggregator;
using MAUIEventAggregatorSample.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIEventAggregatorSample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public Commands.Command TextViewCommand { get; }

        string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                SetProperty(ref _text, value);
            }
        }

        public MainViewModel()
        {
            _text = string.Empty;

            //Register EventHandler
            EventAggregator.Instance.RegisterHandler<TextMessage>(
       TextHandler);

            TextViewCommand = new Commands.Command(async () => await SendTextViewCommandExecute());
        }



        private void TextHandler(
    TextMessage message)
        {
            Text = message.Text;
        }


        private async Task SendTextViewCommandExecute()
        {
            await Application.Current.
            MainPage.Navigation.PushAsync(new MessagePage());
        }
    }
}
