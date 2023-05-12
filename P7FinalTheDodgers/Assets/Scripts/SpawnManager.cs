using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Car;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCar", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCar ()
    {
        Instantiate(Car, spawnPos, Car.transform.rotation);
    }


}
