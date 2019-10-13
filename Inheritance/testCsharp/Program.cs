using System;
using System.Collections.Generic;
using System.Linq;


namespace testCsharp
{
    static class Program
    {
       
        static void Main()
        {
            FEmployee fp = new FEmployee();
            fp.Fname = "Full";
            fp.Lname = "time";
            fp.PrintFulllname();

            PEmployee pp = new PEmployee();
            pp.Fname = "Part";
            pp.Lname = "time";
            pp.PrintFulllname();

        }

      

    }
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public void PrintFulllname()
        {
            Console.WriteLine(Fname + Lname);
        }
    }
    public class FEmployee :Employee
    {
        public float YearlySal { get; set; }

    }
    public class PEmployee :Employee
    {
        public float HourlySal { get; set; }


    }
}

