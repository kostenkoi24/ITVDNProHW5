using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Homework5_4
{
    class Users
    {
        [JsonProperty(PropertyName = "Users")]
        public User User { get; set; }
    }

    public class User
    {
       [JsonProperty(PropertyName = "username")]
        public string username { get; set; }

       [JsonProperty(PropertyName = "password")]
        public string password { get; set; }
  
    }

    class Program
    {
        static void Main(string[] args)
        {


            StreamReader r = new StreamReader("settings.json");
            
                string json = r.ReadToEnd();
                List<User> items = JsonConvert.DeserializeObject<List<User>>(json);
            
                        
            foreach (var item in items)
            {
                Console.WriteLine("{0} {1}", item.username, item.password);
            }

            User newUser = new User();

            newUser.username = "kzdbjbsd";
            newUser.password = "4444";

            items.Add(newUser);

            
            var json2 = System.Text.Json.JsonSerializer.Serialize(items);

            r.Close();

            StreamWriter streamWriter = new StreamWriter("settings.json");
            streamWriter.Write(json2);
            streamWriter.Close();
            

            

            Console.ReadKey();
        }
    }
}
