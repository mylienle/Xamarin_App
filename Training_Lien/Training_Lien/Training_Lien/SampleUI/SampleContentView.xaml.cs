using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Training_Lien
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleContentView: ContentView
    {

        public SampleContentView ( )
        {
            InitializeComponent( );
        }

        public string CardTitle
        {
            get => (string)GetValue(SampleContentView.CardTitleProperty);
            set => SetValue(SampleContentView.CardTitleProperty,value);
        }
        public string CardDescription
        {
            get => (string)GetValue(SampleContentView.CardDescriptionProperty);
            set => SetValue(SampleContentView.CardDescriptionProperty,value);
        }

        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(
        nameof(CardTitle),        // the name of the bindable property
        typeof(string),     // the bindable property type
        typeof(SampleContentView),   // the parent object type
        string.Empty);      // the default value for the propertyk

        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(
            nameof(CardDescription),
            typeof(string),
            typeof(SampleContentView)
            );
    }
}