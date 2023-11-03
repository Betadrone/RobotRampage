using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void Start()
    {
        // Create a dictionary with a string key and int values pairs
        Dictionary<string, int> cityPopulation = new Dictionary<string, int>(); // declaration
        cityPopulation.Add("Tokyo", 38000000);
        cityPopulation.Add("Delhi", 25700000);
        cityPopulation.Add("Shanghai", 29211000);
        cityPopulation.Add("San Paulo", 22620000);
        cityPopulation.Add("Mexico City", 21000000);

        // Read all the data
        Debug.Log("City Population");

        foreach (KeyValuePair<string,int> city in cityPopulation)
        {
            Debug.Log("City: " + city.Key + ", Population: " + city.Value);
        }

        Debug.Log("Total Number Of Cities: " + cityPopulation.Count);
    }
}
