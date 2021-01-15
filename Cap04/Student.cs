using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap04
{
    class Student
    {
        public string Name;
        public double Score1, Score2, Score3;
       
        public double FinalScore()
        {
            return Score1 + Score2 + Score3;
        }

        public string FinalResult()
        {
            if (FinalScore() < 60)
            {
                return "Disapproved.";
            }
            else
            {
                return "Approved.";
            }
        }

        public string RemainingScore()
        {
            if (FinalScore() >= 60)
            {
                return 0.ToString("f2", CultureInfo.InvariantCulture);
            }
            else
            {
                return (60.0 - FinalScore()).ToString("f2", CultureInfo.InvariantCulture);
            }

        }
    }
}
