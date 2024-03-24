using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public float spawnXhorz = 25.0f;
    public float spawnZ = 10.0f; 
    public float spawnX = 13.0f;
    public float spawnDelay = 2;
    public float spawnUnterval = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
       int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosVert = new Vector3(Random.Range(-spawnX, spawnX), 0, 16);
        Vector3 spawnPosHorz1 = new Vector3(spawnXhorz, 0, Random.Range(-spawnZ, spawnZ));
        Vector3 spawnPosHorz2 = new Vector3(-spawnXhorz, 0, Random.Range(-spawnZ, spawnZ));

        Instantiate(animalPrefabs[animalIndex], spawnPosVert, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnPosHorz1, Quaternion.Euler(0, 270, 0));
        Instantiate(animalPrefabs[animalIndex], spawnPosHorz2, Quaternion.Euler(0, 90, 0));
    }
}