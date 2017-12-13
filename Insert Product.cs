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
using SQLite;
using System.IO;

namespace App2
{
    [Activity(Label = "InsertProduct")]
    public class ProductCreate : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.InsertProduct);

            Button btnCreateProduct = FindViewById<Button>(Resource.Id.btnInsert);
            btnCreateProduct.Click += delegate
            {
                try
                {
                    string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
                    var db = new SQLiteConnection(dpPath);
                    db.CreateTable<Product>();

                    Product tbl = new Product();
                    tbl.Name = FindViewById<EditText>(Resource.Id.txtName).Text;
                    tbl.Price = FindViewById<EditText>(Resource.Id.txtPrice).Text;
                    tbl.Quantity = FindViewById<EditText>(Resource.Id.txtQuality).Text;
                    db.Insert(tbl);

                    Toast.MakeText(this, "Product Inserted", ToastLength.Long).Show();
                    StartActivity(typeof(Product));
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                }

            };
        }
    }
}