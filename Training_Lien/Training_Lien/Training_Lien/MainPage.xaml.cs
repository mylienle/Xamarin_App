using System.Collections.Generic;
using System.Runtime.Serialization;
using Xamarin.Forms;

namespace Training_Lien
{
    public partial class MainPage: ContentPage
    {


        public MainPage ( )
        {
            InitializeComponent( );

        }
        // Class for deserializing JSON list of sample bitmaps
        [DataContract]
        class ImageList
        {
            [DataMember(Name = "photos")]
            public List<string> Photos = null;
        }



    }
}
