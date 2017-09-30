using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract(Name = "Server_Service"/*, Namespace = "GPH_QuickMessageServiceLib"*/, SessionMode = SessionMode.Required, CallbackContract = typeof(IServerCallback))]

    interface IServer
    {
        [OperationContract]
        bool Authenticate(string userName, string password);
        [OperationContract]
        void StartDataTransfer();
        [OperationContract]
        void StopDataTransfer();
    }
    interface IServerCallback
    {
        [OperationContract]
        void SendNumberToClient(int number);
    }
}
