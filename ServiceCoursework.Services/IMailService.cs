using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceCoursework.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMailService" in both code and config file together.
    [ServiceContract]
    public interface IMailService
    {
        [OperationContract]
        string SendMail(string to, string subject, string body);
    }
}
