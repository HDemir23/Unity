using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;

    private float spawnRangeX = 15;
    private float spawnPosZ = 15;

    public float sideSpawnX;

    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;

    private float startDelay = 2;

    private float spawnDelay = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomAnimall", startDelay, spawnDelay);
        InvokeRepeating("spawnLeftAnimal", startDelay, spawnDelay);
        InvokeRepeating("spawnRightAnimal", startDelay, spawnDelay);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnRandomAnimall()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int AnimalIndex = Random.Range(0, AnimalPrefabs.Length);
        Instantiate(AnimalPrefabs[AnimalIndex], spawnPos,
        AnimalPrefabs[AnimalIndex].transform.rotation);
    }

    void spawnLeftAnimal()
    {
        int AnimalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(AnimalPrefabs[AnimalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void spawnRightAnimal()
    {
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(AnimalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }

}
