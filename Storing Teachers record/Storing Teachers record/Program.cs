using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Storing_Teachers_record
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Teacher teacher = new Teacher();
            Console.WriteLine("Choose the operation");
            Console.WriteLine("1. AddRecord/Update 2. Display ");
            int op=int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {
                        teacher.AddRecord();
                        teacher.Display();
                        break;
                    }
                case 2:
                    {
                        teacher.Display();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                    }
            }
            Console.ReadKey();
        }

       

    } 
}
