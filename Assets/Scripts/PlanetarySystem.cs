using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlanetarySystem  : IPlanetarySystem
{
    public IEnumerable<IPlanetaryObject> PlanetaryObjects
    {get; set;}
 
    public void Update(float deltaTime)
    {
 
    }
   
}


