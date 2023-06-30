using System.ComponentModel;

namespace Training_Lien
{
    public class Person: INotifyPropertyChanged
    {
        string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName=value;
                OnPropertychanged(nameof(FirstName));
            }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName=value; OnPropertychanged(nameof(LastName)); }
        }
        string email;
        public string Email
        {
            get => email;
            set
            {
                email=value; OnPropertychanged(nameof(Email));
            }
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

        public void SetProperty (string prop,string val)
        {

        }
        public void ClearFields ( )
        {
            FirstName=string.Empty;
            LastName=string.Empty;
            Email=string.Empty;
            Password=string.Empty;
        }
    }
}
