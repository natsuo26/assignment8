using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    internal class Sports:Student
    {
        public string sportsName;
        public int score;
        
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter sports : ");
            sportsName = Console.ReadLine();

            Console.WriteLine("enter score : ");
            score = Convert.ToByte(Console.ReadLine());
        }
        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"sports : {sportsName}");
            Console.WriteLine($"score:{ score}");
        }
    }
}
