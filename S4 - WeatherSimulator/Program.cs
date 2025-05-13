namespace S4___WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of days:");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("-----");
            int maxTemp, minTemp;
            int[] temperatures = new int[days];

            Random randomTemp = new Random();

            for (int i = 0; i < days; i++) {
                temperatures[i] = randomTemp.Next(-10,40);
            }

            double averageTemp = GetAverageTemp(days, temperatures);

            string[] weatherPerDay = GetWeatherForEachDay(days, temperatures);

            foreach (var item in temperatures)
            {
                Console.WriteLine(item);
            }
            foreach (var item in weatherPerDay)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Average Temperature: {averageTemp}");
            Console.WriteLine("-----------");

            GetMaxAndMinTemp(temperatures, out maxTemp, out minTemp);

            Console.WriteLine($"The Maximum Temperature is: {maxTemp} \nThe Minimum Temperature is: {minTemp}");
            Console.ReadKey();
        }
        /// <summary>
        /// This method takes the number of days and an array of temperatures as input and returns an array of weather types for each day.
        /// </summary>
        /// <param name="days"></param>
        /// <param name="temps"></param>
        /// <returns>returns a String Array</returns>
        static string[] GetWeatherForEachDay(int days, int[] temps) {

            string[] weathers = new string[days];

            for (int i = 0; i < days; i++) {
                if (temps[i] <= 0)
                {
                    weathers[i] = "Snowy";
                }
                else if (temps[i] <= 15) {
                    weathers[i] = "Rainy";
                }
                else if (temps[i] <= 30)
                {
                    weathers[i] = "Cloudy";
                }
                else if (temps[i] <= 40)
                {
                    weathers[i] = "Sunny";
                }
            }
            return weathers;
        }
        /// <summary>
        /// This method takes the number of days and an array of temperatures as input and returns the average temperature.
        /// </summary>
        /// <param name="days"></param>
        /// <param name="temps"></param>
        /// <returns>returns a double</returns>
        static double GetAverageTemp(int days, int[] temps) {
            double total = 0;
            foreach (var num in temps)
            {
                total += num;
            }
            return total/days;
        }

        static void GetMaxAndMinTemp(int[] temps, out int maxTemp, out int minTemp) {
          maxTemp = temps.Max();
          minTemp = temps.Min();

        }
    }
}
