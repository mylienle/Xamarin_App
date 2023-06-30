using Android.Graphics.Drawables;
using Training_Lien;
using Training_Lien.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRenderer))]
namespace Training_Lien.Droid.Renderers
{
    public class CustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if ( e.OldElement==null )
            {
                var gradientDrawble = new GradientDrawable( );
                gradientDrawble.SetColor(Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawble);
            }
        }
    }
}