using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Training_Lien
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomTextField: ContentView
    {
        public ICommand ChangedIconCommand { get; set; }
        public CustomTextField ( )
        {
            InitializeComponent( );

            ChangedIconCommand=new Command(ChangedIcon);
        }
        public string TextPlaceholder
        {
            get => (string)GetValue(TextPlaceholderProperty);
            set => SetValue(TextPlaceholderProperty,value);
        }
        public string TextField
        {
            get => (string)GetValue(TextFieldProperty);
            set => SetValue(TextFieldProperty,value);
        }
        public bool IsPasswordField
        {
            get => (bool)GetValue(IsPasswordFieldProperty);
            set => SetValue(IsPasswordFieldProperty,value);
        }
        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty,value);
        }

        public static readonly BindableProperty IconProperty = BindableProperty.Create(
      nameof(Icon),
      typeof(string),
      typeof(CustomTextField));

        public static readonly BindableProperty IsPasswordFieldProperty = BindableProperty.Create(
       nameof(IsPasswordField),
       typeof(bool),
       typeof(CustomTextField));

        public static readonly BindableProperty TextFieldProperty = BindableProperty.Create(
        nameof(TextField),
        typeof(string),
        typeof(CustomTextField),
        string.Empty);

        public static readonly BindableProperty TextPlaceholderProperty = BindableProperty.Create(
        nameof(TextPlaceholder),
        typeof(string),
        typeof(CustomTextField),
        string.Empty);
        public void CustomEntry_Focused (object sender,FocusEventArgs e)
        {
            placeholder.TranslateTo(0,-20);
            placeholder.FontSize=14;
        }

        public void CustomEntry_UnFocused (object sender,FocusEventArgs e)
        {
            placeholder.TranslateTo(0,0);
            placeholder.FontSize=18;
        }

        void ChangedIcon ( )
        {
            IsPasswordField=!IsPasswordField;

            if ( !IsPasswordField )
            {
                Icon=IconFont.LockOpen;
            }
            else
            {
                Icon=IconFont.Lock;
            }
        }
    }
}