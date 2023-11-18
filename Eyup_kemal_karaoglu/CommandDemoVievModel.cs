using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Eyup_kemal_karaoglu
{
    class CommandDemoViewModel : INotifyPropertyChanged
    {
        double number = 1;

        public event PropertyChangedEventHandler PropertyChanged;

        public CommandDemoViewModel()
        {
            MultiplyBy2Command = new Command(() => Number += 5);

            DivideBy2Command = new Command(() => Number -= 10);

        }

        public double Number
        {
            set
            {
                if (number != value)
                {
                    number = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));
                }
            }
            get
            {
                return number;
            }
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            if (sender is Button button)
            {
            
                await button.RelRotateTo(360, 1000);
            }
        }


        public ICommand MultiplyBy2Command { private set; get; }

        public ICommand DivideBy2Command { private set; get; }

    }
}