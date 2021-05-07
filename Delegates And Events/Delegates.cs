using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Events
{ /* Single Delegates Function*/
    public delegate int MyDelegates(int x, int y); // Define Delegates
    class Delegates
    {
        public static int Addition(int x, int y) //create method that passes as parameter it has same signature as Delegates
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        //static void Main(string[] args)
        //{
        //    //MyDelegates myDelegates = new MyDelegates(Addition);//create object of Delegate Name
        //    MyDelegates myDelegates = Addition; //create object of Delegate Name and Specify method Name
        //    myDelegates += Multiply; //Multicasting Delegates += only one object and call method
        //    Console.WriteLine($"Addition is:- {myDelegates(55, 5)}"); //Passing parameter and Print
        //    Console.WriteLine($"Multiplication is:- {myDelegates(5, 5)}");
        //    Console.ReadLine();
        //}
    }
}
