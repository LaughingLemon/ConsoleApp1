using HoneyBear.HalClient;
using HoneyBear.HalClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HalClient halClient = new HalClient();
            halClient.HttpClient.BaseAddress = new Uri("http://localhost:8080");
            IHalClient client = halClient.Root("/users").Get("users");
            IEnumerable<User> products = client.Items<User>().Data();
            foreach (User u in products)
            {
                Console.WriteLine("Name: " + u.Name + "");
            }

            var user = new { name = "Ian" };
            halClient.Root("/").Post("users", user);
        }
    }

    internal class User
    {
        public int Id { get; set;  }
        public string Name { get; set;  }
    }
}
