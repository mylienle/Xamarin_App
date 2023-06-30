using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Training_Lien
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomIcon: ContentView
    {
        public CustomIcon ( )
        {
            InitializeComponent( );
        }
        public Color ColorBackgroud
        {
            get => (Color)GetValue(CustomIcon.ColorBackgroudProperty);
            set => SetValue(CustomIcon.ColorBackgroudProperty,value);
        }
        public FontImageSource Icon
        {
            get => (FontImageSource)GetValue(CustomIcon.IconProperty);
            set => SetValue(CustomIcon.IconProperty,value);
        }
        public string IconTitle
        {
            get => (string)GetValue(CustomIcon.IconTitleProperty);
            set => SetValue(CustomIcon.IconTitleProperty,value);
        }
        public int CornerRadius
        {
            get => (int)GetValue(CustomIcon.CornerRadiusProperty);
            set => SetValue(CustomIcon.CornerRadiusProperty,value);
        }

        public static readonly BindableProperty ColorBackgroudProperty = BindableProperty.Create(
        nameof(ColorBackgroud),        // the name of the bindable property
        typeof(Color),     // the bindable property type
        typeof(ContentView)   // the parent object type
        );      // the default value for the propertyk

        public static readonly BindableProperty IconProperty = BindableProperty.Create(
        nameof(Icon),
        typeof(FontImageSource),
        typeof(CustomIcon));

        public static readonly BindableProperty IconTitleProperty = BindableProperty.Create(
        nameof(IconTitle),
        typeof(string),
        typeof(CustomIcon));

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
       nameof(CornerRadius),
       typeof(int),
       typeof(CustomIcon));
    }
}