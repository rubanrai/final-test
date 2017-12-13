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

namespace App2
{
    public class Product
    {
        [PrimaryKey, AutoIncrement, Column("_Id")]

        public int ProductId { get; set; } // AutoIncrement and set primarykey  

        [MaxLength(40)]

        public string Name { get; set; }

        [MaxLength(40)]

        public string Price { get; set; }



        public string Quantity { get; set; }
    }
}