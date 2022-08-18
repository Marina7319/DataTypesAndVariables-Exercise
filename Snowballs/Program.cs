using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            double maxValue = double.MinValue;
            int snowballTime = 0;
            int snowballQuality = 0;
            int snowballSnow = 0;
            double snowBallValue = 0.0;
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            double maxSnowballQuality = 0;
            for (int i = 1; i <= snowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                double value = snowballSnow / snowballTime;
                snowBallValue = Math.Pow(value, snowballQuality);
                double sum = 0;
                sum += snowBallValue;
                if (snowBallValue > maxValue)
                {
                    maxValue = snowBallValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }
            }
            double sums = maxSnowballSnow / maxSnowballTime;
            double result = Math.Pow(sums, maxSnowballQuality);
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {result} ({maxSnowballQuality})");
        }
    }
}
