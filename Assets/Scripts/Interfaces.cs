using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlanetarySystemFactory
{
    IPlanetarySystem Create(double mass);
}
public interface IPlanetarySystem
{
    IEnumerable<IPlanetaryObject> PlanetaryObjects { get; set;}
    void Update(float deltaTime);
}

public interface IPlanetaryObject
{
    MassClassEnum massClass { get; set; }
    double mass { get; set; }
}
