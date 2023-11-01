using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    internal class Result:Test
    {
        int totalScore = 0;
        public void GetTotalScore()
        {
            base.GetTotalMarks();
            totalScore= score + totalMarks;

        }
        public void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Final score is: {totalScore}");
        }

            
    }
}
