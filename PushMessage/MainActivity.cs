using Android.App;
using Android.Widget;
using Android.OS;
using Com.OneSignal;

namespace PushMessage
{
    [Activity(Label = "PushMessage", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            OneSignal.Current.StartInit("d635f63a-ae68-4238-a594-4df25dcbbd86").EndInit();
        }
    }
}

