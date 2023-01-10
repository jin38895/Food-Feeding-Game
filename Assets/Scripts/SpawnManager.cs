using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 15;
    private float startDelay = 2;
    private float elapsedTime = 0;
    private string[] spawnRandomAnimal = {"SpawnRandomAnimalFromTop","SpawnRandomAnimalFromLeft","SpawnRandomAnimalFromRight"};
    
    // Start is called before the first frame update
    void Start()
    {
        // Spawn after a specific time interval again and again.
        // InvokeRepeating(spawnRandomAnimal[Random.Range(0, spawnRandomAnimal.Length)], startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 1.0f)
        {
            Invoke(spawnRandomAnimal[Random.Range(0, spawnRandomAnimal.Length)], startDelay);
            elapsedTime = 0;
        }
        
    }
    
    // Function to Spawn Random Animals at Random Location from Top
    void SpawnRandomAnimalFromTop()
    {   
        // Creating Random location to Spawn for Top
        Vector3 spawnTopPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 20);
        
        // Creating Random Animal to spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        
        // Spawning the animals
        Instantiate(animalPrefabs[animalIndex], spawnTopPos, animalPrefabs[animalIndex].transform.rotation);
    }
   
   // Function to Spawn Random Animals at Random Location from Left
   void SpawnRandomAnimalFromLeft()
   {
        Vector3 spawnLeftPos = new Vector3(spawnRangeX, 0, Random.Range(0, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnLeftPos, Quaternion.Euler(new Vector3(0,-90,0)));
   }
   
   // Function to Spawn Random Animals at Random Location from Right
   void SpawnRandomAnimalFromRight()
   {
        Vector3 spawnRightPos = new Vector3(-spawnRangeX, 0, Random.Range(0, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnRightPos, Quaternion.Euler(new Vector3(0,90,0)));
   }
}
