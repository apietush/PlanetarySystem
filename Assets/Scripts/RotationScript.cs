using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{

    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.value * 30;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.parent.transform.position);
        transform.RotateAround(transform.parent.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
