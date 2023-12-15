using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DAO
{
    public class Db
    {
        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "hxglBMLQcKSQOCgpilSc62e9CXJpA51q8rBeLUGw",
            BasePath = "https://uber-ola-and-indrive-clo-2b5a0-default-rtdb.firebaseio.com/"
        };

        public Dictionary<string, RideRequest> GetData(string sql)
        {
            IFirebaseClient client = new FirebaseClient(Config);
            FirebaseResponse result = client.Get(@"All Ride Requests");
            Dictionary<string, RideRequest> data = JsonConvert.DeserializeObject<Dictionary<string, RideRequest>>(result.Body.ToString());

            return data;
        }

        public void AddData()
        {

        }
    }
}
