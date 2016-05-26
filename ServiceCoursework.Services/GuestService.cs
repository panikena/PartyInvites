using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace ServiceCoursework.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GuestService : IGuestService
    {
        public string Echo()
        {
            return "Guest service echo!";
        }

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Guests AddGuest(XmlDocument value)
        {
            ServiceDBEntities DB = new ServiceDBEntities();

            Guests guest = new Guests();

            XmlNode xnGuest = value.SelectSingleNode("Guest");

            guest.Name = xnGuest.SelectSingleNode("Name").InnerText;
            guest.Email = xnGuest.SelectSingleNode("Email").InnerText;
            guest.Phone = xnGuest.SelectSingleNode("Phone").InnerText;
            guest.WillAttend = Boolean.Parse(xnGuest.SelectSingleNode("WillAttend").InnerText);
            guest.Comment = xnGuest.SelectSingleNode("Comment").InnerText;

            DB.Guests.Add(guest);
            DB.SaveChanges();

            return guest;
        }


        public XmlDocument CreateGuestXML(string name, string email, string phone, bool willAttend, string comment)
        {
            
                MemoryStream ms = new MemoryStream();
                XmlTextWriter textWriter = new XmlTextWriter(ms, Encoding.UTF8);

                textWriter.WriteStartDocument();

                textWriter.WriteStartElement("Guest");

                textWriter.WriteElementString("Name", name);
                textWriter.WriteElementString("Email", email);
                textWriter.WriteElementString("Phone", phone);
                textWriter.WriteElementString("WillAttend", willAttend ? Boolean.TrueString : Boolean.FalseString);
                textWriter.WriteElementString("Comment", comment);

                textWriter.WriteEndElement();

                textWriter.Flush();
                

                XmlDocument doc = new XmlDocument();

                ms.Position = 0;
                doc.Load(ms);
                return doc;
           
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
