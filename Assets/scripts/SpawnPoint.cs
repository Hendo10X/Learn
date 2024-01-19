using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float SpawnRangeX = 20;
    private float SpawnPosZ = 20;
    int StartDelay = 2;
    float SpawnInterval = 1.5f;
   
  
    // Start is called before the first frame update
    void Start()
    {
        // Allows the player to be spawned in time intervals
        InvokeRepeating("SpawnRandomAnimal", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    // A method to spawn the Player Randomly without a button being pressed
    void SpawnRandomAnimal(){
            int animalIndex = Random.Range(0, AnimalPrefabs.Length);
            Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX,SpawnRangeX),0,SpawnPosZ);
            Instantiate(AnimalPrefabs[animalIndex],SpawnPos,AnimalPrefabs[animalIndex].transform.rotation);
    }
}
