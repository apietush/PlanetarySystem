using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public  class PlanetarySystemFactory :  IPlanetarySystemFactory
{
    private int orbitedist = 15;
    private List<PlanetaryObject> createdSystem;
    private List<double> massarray;
    public PlanetarySystem sys;
    private double startOrbite;
    
  
    public  IPlanetarySystem Create(double totalMass)
    {
        PrepareValues(totalMass);
        foreach (double mass in massarray)
        {
            PlanetaryObject newObject = new PlanetaryObject(mass, startOrbite);
            createdSystem.Add(newObject.CreateConcretePlanet());
            startOrbite = startOrbite  * UnityEngine.Random.value + orbitedist;
        }
        sys.PlanetaryObjects  = new List<PlanetaryObject>();
        return   sys;
    }
    
    void PrepareValues(double totalMass)
    {
        createdSystem = new List<PlanetaryObject>();
        massarray = RandomSplitMass(totalMass);
        sys = new PlanetarySystem();
        startOrbite = UnityEngine.Random.value + orbitedist;
    }
    
    private List<double>  RandomSplitMass(double mass)
    {
        double randomNuber;
        List<double> numbers = new List<double>();  
        double firstNumber = UnityEngine.Random.Range(0F, (float) mass);
        numbers.Add(firstNumber);
        for (double sum = firstNumber; sum < mass; sum = sum + randomNuber)
        {
            randomNuber = UnityEngine.Random.Range(0F, (float) mass);
            if (randomNuber < mass - sum)
            {
                numbers.Add(randomNuber);
            }
            else
            {
                numbers.Add(mass-sum);
            }
        }
        numbers.Sort();
        return numbers;
    }
}
