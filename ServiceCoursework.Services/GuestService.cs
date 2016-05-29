using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceCoursework.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GuestService : IGuestService
    {

        ServiceDBEntities DB = new ServiceDBEntities();
        public string Echo()
        {
            return "Guest service echo!";
        }

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string AddGuestByJson(string value)
        {
            try
            {

                Guests guest = JsonConvert.DeserializeObject<Guests>(value);

                DB.Guests.Add(guest);
                DB.SaveChanges();
                return "Successfully saved guest record.";
            }
            catch (Exception ex) {
                return String.Format("An exception was encountered: {0}", ex.Message);
            }
        }

        public string AddGuest(Guests value)
        {
            try
            {
                DB.Guests.Add(value);
                DB.SaveChanges();
                return "Successfully saved guest record.";
            }
            catch (Exception ex)
            {
                return String.Format("An exception was encountered: {0}", ex.Message);
            }
        }

        public List<Guests> GetAll() {
            return DB.Guests.ToList();
        }

        public string GetAllInJson()
        {
            return JsonConvert.SerializeObject(DB.Guests.ToList());

        }
        //        { "Name": "John Galt", "Email": "adenisenko@ymail.com", "Phone": "0000", "WillAttend" : true, "Comment": "Send me a message" }

        public Guests CreateGuest(string name, string email, string phone, bool willAttend, string comment)
        {
            return new Guests
            {
                Name = name,
                Email = email,
                Phone = phone,
                WillAttend = willAttend,
                Comment = comment
            };
        }
    }
}
