
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using SQLite;

namespace App2
{
    [Activity(Label = "DisplayProduct")]
    public class ProductDetail : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DisplayProduct);
            // Create your application here

            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
            var db = new SQLiteConnection(dpPath);
            var data = db.Table<Product>();
            var records = new List<string>();
            foreach (var listing in data)
            {
                records.Add(listing.Name + "   -   " + listing.Quantity);
            }
            foreach (var listing in data)
            {
                records.Add(listing.Name + "   +   " + listing.Quantity);
            }

            ListView listtable = (ListView)FindViewById(Resource.Id.btnDisplay);
            listtable.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, records.ToArray());
        }
    }
}