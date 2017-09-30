using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Service : IServer
    {
        List<KeyValuePair<string, string>> users;
        bool _sendData;
        public Service()
        {
            users.Add(new KeyValuePair<string, string>("TestUser", "TestPassword"));
        }
        bool Authenticate(string userName, string password)
        {
            bool userExists = users.Find(x=> x.Key == userName && x.Value == password).Equals(new KeyValuePair<string, string>());
            return userExists;
        }
        void StartDataTransfer()
        {
            Random rnd = new Random();
            _sendData = true;
            byte[] bytes = new byte[1000];
            while (_sendData)
            {
                rnd.NextBytes(bytes);
            }
        }
        void StopDataTransfer()
        {
            _sendData = false;
        }

    }
}
