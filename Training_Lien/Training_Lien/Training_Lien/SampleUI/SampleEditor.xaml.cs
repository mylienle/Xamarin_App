using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Training_Lien
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleEditor: ContentView
    {
        public static readonly BindableProperty TBProperty =
            BindableProperty.Create(nameof(TB),typeof(string),typeof(SampleEditor));

        public string TB
        {
            get { return (string)GetValue(TBProperty); }
            set { SetValue(TBProperty,value); }
        }


        public SampleEditor ( )
        {
            InitializeComponent( );
        }
    }
}