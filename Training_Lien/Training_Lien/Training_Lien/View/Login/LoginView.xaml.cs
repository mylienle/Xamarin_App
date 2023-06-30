using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Training_Lien
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView: ContentView
    {
        public LoginView ( )
        {
            InitializeComponent( );

            BindingContext=new LoginViewModel( );
        }
    }
}