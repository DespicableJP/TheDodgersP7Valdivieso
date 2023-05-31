using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnM : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public int carIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int carIndex = Random.Range(0, carPrefabs.Length);

            Instantiate(carPrefabs[carIndex], new Vector3(0, 0, 20), carPrefabs[carIndex].transform.rotation);
        }
    }
}
