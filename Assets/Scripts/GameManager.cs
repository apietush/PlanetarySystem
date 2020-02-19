using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlanetarySystemFactory factory;
    // Start is called before the first frame update
    void Start()
    {    
        factory = new PlanetarySystemFactory();
        factory.Create( Random.Range(1, 100));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
