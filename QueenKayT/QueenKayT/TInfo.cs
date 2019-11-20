using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QueenKayT
{
    public class TInfo
    {

        [PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfOrder { get; set; }

        public string TShirtColor  { get; set; }

        public string ShippingAdress { get; set; }







    }
}
