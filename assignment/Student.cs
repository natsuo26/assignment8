using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    internal class Student
    {
        protected int roll;
        protected string name;

        public void GetDetails()
        {
            Console.WriteLine("enter roll: ");
            roll=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name: ");
            name = Console.ReadLine();
        }
        public void ShowDetails()
        {
            Console.WriteLine($"roll No : {roll}");
            Console.WriteLine($"name : {name}");

        }


        
    }
}
