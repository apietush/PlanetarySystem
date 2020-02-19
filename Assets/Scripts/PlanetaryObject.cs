using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlanetaryObject : IPlanetaryObject
{
    public MassClassEnum massClass { get; set; }
    public double mass { get; set; }
    public MassClassEnum.Planets type;
    public double radius;
    public GameObject createdPlanet; 
    public double orbitenum;
    public GameObject center;
    public Renderer renderer;

     public PlanetaryObject(double mass, double orbitescalar)
     {
        orbitenum = orbitescalar;
        this.mass = mass;      
    }

     public PlanetaryObject CreateConcretePlanet()
     {
         massClass = new MassClassEnum(mass);
         center = new GameObject();
         type = massClass.type;
         radius = massClass.radius/2;
         Debug.Log(radius);
         createdPlanet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
         renderer = createdPlanet.GetComponent<Renderer>();
         renderer.material.color = massClass.color;
         center.transform.position = new Vector3(0, 0, 0);
         createdPlanet.transform.position = new Vector3 ((float)(orbitenum * mass * 0.1), 0F, 0F);
         createdPlanet.transform.SetParent(center.transform);
         createdPlanet.transform.localScale = new Vector3((float)radius, (float)radius, (float)radius);
         var script = createdPlanet.AddComponent<RotationScript>();
         return this;
     }
     
   
}