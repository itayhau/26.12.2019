//FirebaseDatabase.net 4.0.4
// https://medium.com/step-up-labs/firebase-c-library-5c342989ad18#.5j8zqmegj

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;


namespace FireBaseApp
{
    internal class Dinosaur
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
           
            try
            {
                var firebase = new FirebaseClient("https://proj1-b3113.firebaseio.com/Customers");
                
                var dinos = firebase.Child("/1").OnceAsync<object>().Result;
                   //.OrderByKey()
                   //.StartAt("pterodactyl")
                   //.LimitToFirst(2)
                   //.OnceAsync<Dinosaur>();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Done");
        }
    }
}
