using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hack4HongKong
{
    public class DatabaseQueries
    {
        private static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "LLxRPcP2WsZmNM2eIIzuE4BDOOZQLouaVAQYEIyh",
            BasePath = "https://hack4hk.firebaseio.com/"

        };

        private static IFirebaseClient client;

        public static void ConnectToDatabase()
        {
            client = new FirebaseClient(config);
        }
        protected static FirebaseResponse GetData(string path)
        {
            FirebaseResponse response = client.Get(path);
            return response;
        }
        protected static void InsertData(string path, Object itemToInsert)
        {
            client.Set(path, itemToInsert);
        }
        protected static void UpdateData(string path, Object itemToUpdate)
        {
            client.Update(path, itemToUpdate);
        }
        protected static void DeleteData(string path)
        {
            client.Delete(path);
        }
    }
}