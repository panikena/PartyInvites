using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace ServiceCoursework.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGuestService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "GetData/{value}", Method = "POST")]
        string GetData(string value);


        [OperationContract]
        [WebGet(UriTemplate = "Echo")]
        string Echo();

        [OperationContract]
        [WebGet(UriTemplate = "CreateGuest/{name}/{email}/{phone}/{willAttend}/{comment}", ResponseFormat = WebMessageFormat.Json)]
        Guests CreateGuest(string name, string email, string phone, bool willAttend, string comment);

        [OperationContract]
        [WebInvoke(UriTemplate = "AddGuest", Method = "POST", RequestFormat = WebMessageFormat.Json)]
        string AddGuestByJson(string value);

        [OperationContract]
        string AddGuest(Guests value);


    }
}
