using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int year = 1;
            while (initialPopulation <= currentPopulation)
            {
                initialPopulation = (int)((visitors + initialPopulation) * (1+percent/100));
                year++;
            }
            return year;
        }
    }
}