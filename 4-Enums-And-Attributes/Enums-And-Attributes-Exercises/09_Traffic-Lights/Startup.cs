namespace _09_Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] signals = Console.ReadLine().Split(' ');

            List<TrafficLight> trafficLights = new List<TrafficLight>();

            foreach (var signal in signals)
            {
                TrafficLight trafficLight = new TrafficLight(signal);
                trafficLights.Add(trafficLight);
            }

            int changesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < changesCount; i++)
            {
                trafficLights.ForEach(t => t.Update());
                Console.WriteLine(string.Join(" ", trafficLights.Select(t => t.Signal)));
            }
        }
    }
}
