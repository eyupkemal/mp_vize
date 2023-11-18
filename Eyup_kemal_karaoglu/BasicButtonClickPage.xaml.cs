using System;
using System.Security.Cryptography;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eyup_kemal_karaoglu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicButtonClickPage : ContentPage
    {
        public BasicButtonClickPage()
        {
            InitializeComponent();

        }

        void CheckBoxChanged_1(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Label_BaslangicMetni.FontAttributes |= FontAttributes.Italic;
            }
            else
            {
                Label_BaslangicMetni.FontAttributes &= ~FontAttributes.Italic; 
                Label_BaslangicMetni.FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)); 
            }
        }
        void CheckBoxChanged_2(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Label_BaslangicMetni.TextDecorations |= TextDecorations.Strikethrough;
            }
            else
            {
                Label_BaslangicMetni.TextDecorations &= ~TextDecorations.Strikethrough;
            }
        }

        void CheckBoxChanged_3(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Label_BaslangicMetni.FontAttributes = FontAttributes.Bold;
            }
            else
            {
                Label_BaslangicMetni.FontAttributes = FontAttributes.None;
            }
        }

        void CheckBoxChanged_4(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Label_BaslangicMetni.TextDecorations |= TextDecorations.Underline;
            }
            else
            {
                Label_BaslangicMetni.TextDecorations &= ~TextDecorations.Underline;
            }
        }


        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label_BaslangicMetni.Text = entry.Text;
        }

        private void OnErkekImageTapped(object sender, EventArgs e)
        {
            cinsiyetLabel.Text = "Cinsiyet = Erkek";
        }

        private void OnKadinImageTapped(object sender, EventArgs e)
        {
            cinsiyetLabel.Text = "Cinsiyet = Kadın";
        }

    }
}

