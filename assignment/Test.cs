using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    internal class Test:Sports
    {
        int[] marks = new int[] { 80, 70, 76, 66, 90 };
        protected int totalMarks = 0;
        public void GetTotalMarks()
        {
            totalMarks = marks.ToList().Sum();
        }

        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"total marks: {totalMarks}");
        }

        
    }
}
