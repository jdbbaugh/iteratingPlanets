using System;
using System.Collections.Generic;

namespace iteratingPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars","Jupiter", "Saturn", "Uranus", "Neptune"};
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add(new Dictionary<string, string>(){ {"Voyager 2", "Uranus"}, {"Pioneer 11", "Saturn"}, {"Ulysess", "Jupiter"}, {"Enterprise", "Neptune"}, {"Scooby", "Pluto"}, {"Galileo", "Mars"}, {"Feegero", "Mercury"}, {"Viking", "Mars"}, {"Opportunity", "Mars"}, {"Curiosity", "Mars"}, {"Mariner", "Venus"}, {"Venera", "Venus"}  });

        foreach(string planet in planetList) {
            Console.WriteLine(planet);
        }
        }
    }
}
