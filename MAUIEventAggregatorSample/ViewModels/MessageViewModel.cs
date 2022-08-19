using Bertuzzi.MAUI.EventAggregator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIEventAggregatorSample.ViewModels
{
    public class MessageViewModel : BaseViewModel
    {
        public Commands.Command SendTextCommand { get; }
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

        public MessageViewModel()
        {
            _text = string.Empty;

            SendTextCommand = new Commands.Command(async () => await SendTextCommandExecute());
        }


        private async Task SendTextCommandExecute()
        {

            var TextMessage = new MAUIEventAggregatorSample.Events.TextMessage
            {
                Text = Text
            };

            //Send Message
            EventAggregator.Instance.SendMessage(TextMessage);

            await Application.Current.MainPage.Navigation.PopAsync();

        }
    }
}
