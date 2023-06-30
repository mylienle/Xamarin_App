using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Training_Lien
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButton: ContentView
    {

        public CustomButton ( )
        {
            InitializeComponent( );
        }
        public string ButtonTitle
        {
            get => (string)GetValue(CustomButton.ButtonTitleProperty);
            set => SetValue(CustomButton.ButtonTitleProperty,value);
        }
        public ICommand ButtonCommand
        {
            get => (ICommand)GetValue(CustomButton.ButtonCommandProperty);
            set => SetValue(CustomButton.ButtonCommandProperty,value);
        }

        public static readonly BindableProperty ButtonTitleProperty = BindableProperty.Create(
        nameof(ButtonTitle),
        typeof(string),
        typeof(CustomButton),
        string.Empty);

        public static readonly BindableProperty ButtonCommandProperty = BindableProperty.Create(
        nameof(ButtonCommand),
        typeof(ICommand),
        typeof(CustomButton))
        ;
    }
}