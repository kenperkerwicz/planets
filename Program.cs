using System;
using System.Collections.Generic;

namespace Planets
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };


      List<Dictionary<string, string>> probeDestinations = new List<Dictionary<string, string>>();


      probeDestinations.Add(new Dictionary<string, string>() { { "Viking 1", "Mercury" } });
      probeDestinations.Add(new Dictionary<string, string>() { { "Mercury", "MESSENGER" } });
      probeDestinations.Add(new Dictionary<string, string>() { { "Venus", "Pioneer Venus Orbiter" } });

      // Iterate the List of planets
      foreach (string planet in planetList)
      {
           List<string> matchingProbes = new List<string>();


        // Iterate the KeyValuePairs of the Dictionary
        foreach (Dictionary<string, string> probe in probeDestinations)
        foreach (KeyValuePair<string, string> kvp in probe)
                            /*
                                Does the current Dictionary contain the key of
                                the current planet? Investigate the ContainsKey()
                                method on a Dictionary.
                                If so, add the current spacecraft to `matchingProbes`.
                            */
                            if (planet == kvp.Key) {
                                matchingProbes.Add(kvp.Value);}
                                
Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
    }
  }
  }
}
