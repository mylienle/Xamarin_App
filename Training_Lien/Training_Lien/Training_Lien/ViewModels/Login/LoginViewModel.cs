using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Training_Lien
{
    public class LoginViewModel: INotifyPropertyChanged
    {
        public LoginModel Login { get; set; } = new LoginModel( );
        public ICommand LoginCommand { get; set; }
        public LoginViewModel ( )
        {
            LoginCommand=new Command(AddUserName);
        }

        public void AddUserName ( )
        {
            Login.ClearFields( );
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertychanged (string name) =>
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));


    }
}
