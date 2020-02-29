using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UpSave.Our_Scripts
{
    public class FireBaseMethods
    {
        protected static FirebaseConfig config = new FirebaseConfig {
            AuthSecret = "nvLuHi2heyTrd3EyG8Qxe1foiiT9k8Gb4nrUbo2o",
            BasePath = "https://upsave-4c616.firebaseio.com"
        };
        protected static IFirebaseClient client;
        public static bool IsClientConnected = false;

        public static bool ConnectToDataBase()
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                IsClientConnected = true;
            }
            else
            {
                IsClientConnected = false;
            }
            return IsClientConnected;
        }

        protected static void CheckForConnection()
        {
            if (IsClientConnected)
                return;
            else
            {
                bool didSucceed = ConnectToDataBase();
                if (!didSucceed)
                    throw new Exception("Client is not connected. Attempted: Could not connect.");
            }
        }

        public static FirebaseResponse UpdateData(string path, object data)
        {
            FirebaseResponse response = client.Update(path, data);
            return response;
        }
        protected static void DeleteData(string path)
        {
            FirebaseResponse response = client.Delete(path);
        }
        protected static FirebaseResponse GetData(string path)
        {
            FirebaseResponse response = client.Get(path);
            return response;
        }
        protected static SetResponse InsertData(string path, object item)
        {
            SetResponse response = client.Set(path, item);
            return response;
        }
    }
}