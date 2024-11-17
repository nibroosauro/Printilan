using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrintilanApp
{
    //public static class UserSession
    //{
    //    public static int UserId { get; set; }
    //    public static string Username { get; set; }
    //    public static string Email { get; set; }

    //    public static int SellerId { get; set; }  // Store user ID
    //    public static int StoreId { get; set; }  // Store the store ID (or sellerid)
    //}

    public static class UserSession
    {
        public static int UserId { get; set; }
        public static int StoreId { get; set; }

        // Initialize UserSession.StoreId based on UserSession.UserId

        public static int SellerId { get; set; }
    }


}
