#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            //(new Program()).run();
            Program p = new Program();
            p.run();
        }

        public void run()
        {
            double dailyRate1 = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(calculateFee(dailyRate:dailyRate1, noOfDays));
        }

        private void writeFee(double p)
        {
            Console.WriteLine("The consultant's fee is: {0}", p * 1.1);
            Console.WriteLine();
        }

        private double calculateFee(double dailyRate, int noOfDays)
        {
            return dailyRate * noOfDays;
        }

        private int readInt(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
