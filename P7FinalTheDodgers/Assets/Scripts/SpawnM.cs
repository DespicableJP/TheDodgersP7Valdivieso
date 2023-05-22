using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnM : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 25;
    private float spawnPosZ = 25;
    private float startDelay = 1;
    private float spawnInterval = .2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCars", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnCars();
        }
    }

    void SpawnCars()
    {
        int carIndex = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }





}
