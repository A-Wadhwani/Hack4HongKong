using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudTestApp
{
    public class DatabaseQueries
    {
        private static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "your-auth-secret",
            BasePath = "<your-firebase-reference-link>.firebaseio.com/"

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
            client.Push(path, itemToInsert);
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