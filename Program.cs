using static System.Net.Mime.MediaTypeNames;

namespace Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the current hour: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Please enter the current minute: ");
            int minute = int.Parse(Console.ReadLine());
            Console.Write("Please enter the current second: ");
            int second = int.Parse(Console.ReadLine());

         
            int secondLapsed = (hour * 3600) + (minute * 60) + (second);
            int totalSeconds = (24 * 3600);
            double percentageTimePassed = ((double)secondLapsed / totalSeconds) * 100;



            Console.WriteLine("The time right now is: " + hour + ":" + minute + ":" + second);
            Console.WriteLine("The seconds since midnight is: " + secondLapsed);
            Console.WriteLine("The number of seconds remaining in the day: " + (totalSeconds - secondLapsed));
            Console.WriteLine(" Percentage of day passed: " + Math.Round(percentageTimePassed,2) + "%");
        }
    }
}
