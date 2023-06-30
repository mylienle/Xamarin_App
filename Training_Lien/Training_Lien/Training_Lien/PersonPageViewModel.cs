using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Training_Lien
{
    public class PersonPageViewModel: INotifyPropertyChanged
    {
        public Person Person { get; } = new Person( );

        public ICommand PostPeople { get; }
        public PersonPageViewModel ( )
        {
            PostPeople=new Command(AddPerson);

        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertychanged (string name) =>
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        public void AddPerson ( )
        {
            Person.ClearFields( );
        }
    }
}
