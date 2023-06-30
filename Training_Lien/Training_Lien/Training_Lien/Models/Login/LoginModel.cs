using System.ComponentModel;

namespace Training_Lien
{
    public class LoginModel: INotifyPropertyChanged
    {
        private string userName;
        public string UserName
        {
            get => userName;
            set { userName=value; OnPropertychanged(nameof(UserName)); }
        }
        string password;
        public string Password
        {
            get => password;
            set
            {
                password=value; OnPropertychanged(nameof(Password));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertychanged (string name) =>
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        public void ClearFields ( )
        {
            UserName=string.Empty;
            Password=string.Empty;
        }
    }
}
