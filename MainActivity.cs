using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Button btnInsert = FindViewById<Button>(Resource.Id.btnInsertProduct);

            btnInsert.Click += delegate
            {
                StartActivity(typeof(InsertProduct));
            };

            Button btnDisplay = FindViewById<Button>(Resource.Id.btnDisplayProduct);
            btnDisplay.Click += delegate
            {
                StartActivity(typeof(DisplayProduct));
            };

            Button btnList = FindViewById<Button>(Resource.Id.btnViewInventory);
            btnList.Click += delegate
            {
                StartActivity(typeof(ViewInventory));
            };

        }
    }
}


