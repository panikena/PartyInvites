using ServiceCoursework.Core;
using ServiceCoursework.ServiceLibrary;
using Newtonsoft.Json;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user;
            IUserService service = new UserService();
            Console.WriteLine(service.GetUser("1") + service.GetUser("2"));
          //  user = (User) JsonConvert.DeserializeObject(service.GetUser("1"));

           // Console.WriteLine(user.Id);
           // Console.WriteLine(user.Password);
           // Console.WriteLine(user.Email);
            //Console.WriteLine(user.Phone);
            Console.ReadKey();
        }
    }
}
