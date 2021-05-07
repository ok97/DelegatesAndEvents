using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Events
{
    public delegate void Transformer(int x); //Define Delegates //Delegetes as Transformer
    class Event
    {
        public static void Main()
        {
            Console.Write("Enter a Number:- "); //print
            int i = Convert.ToInt32(Console.ReadLine());

            Transformer t; // Create Instance
            t = Square;// invoke Transformer instance to method //point to be function (its subscriber) subscribing to be delegete instance 
            t += Cuber;// invoke Transformer instance to method //point to be function (its subscriber) subscribing to be delegete instance 
            t.Invoke(i); // invoking the delegate

            NotificationMethods obj = new NotificationMethods(); //create object of NotificationMethods class
            obj.transformerEvent += User1.Xhandler; //invoking Xhandler with transformerEvent delegate type
            obj.transformerEvent += User2.Yhandler; //invoking Yhandler with transformerEvent delegate type
                                                    // += subscrib, event -= Unsubscrib event
            obj.NotifyOnCall(i); //call delegate

            Console.ReadLine();
        }
        static void Square(int x) // create Method
        {
            Console.WriteLine($"Square:- {x * x}"); //print
        }
        static void Cuber(int x) //create method
        {
            Console.WriteLine($"Cuber:- {x * x * x}"); //print
        }
        class NotificationMethods //class (its responsible for the Notification of Methods)
        {
            public event Transformer transformerEvent; //Delegate instance type Transformer  (its responisible my subscriber)
            public void NotifyOnCall(int x) //create method which is calling transformerEvent delagate
            {
                if (transformerEvent!=null)
                {
                    transformerEvent(x); //raise these event
                }                
            }
        }
        class User1 //subscriber
        {
            public static void Xhandler(int x) //handle Event
            {
                Console.WriteLine("Event Received by User1 object"); //print message(Notification)
            }
        }
        class User2 //subscriber
        {
            public static void Yhandler(int x) //handle Event
            {
                Console.WriteLine("Event Received by User2 object"); //print message(Notification)
            }
        }
    }
}
