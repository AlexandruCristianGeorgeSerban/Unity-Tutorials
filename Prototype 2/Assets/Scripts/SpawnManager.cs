using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;
    private float spawnRangeZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        int spawnSide = Random.Range(0, 3);
        Vector3 spawnPos = Vector3.zero;
        Quaternion rotation = Quaternion.identity;

        switch (spawnSide)
        {
            case 0: // Top (existing behavior: animal moves downward)
                spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                // Use the prefab's default rotation (or set it so the animal moves downward)
                rotation = animalPrefabs[animalIndex].transform.rotation;
                break;
            case 1: // Left side (animal moves right)
                spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
                // Rotate so that the animal faces right (90 degrees around Y)
                rotation = Quaternion.Euler(0, 90, 0);
                break;
            case 2: // Right side (animal moves left)
                spawnPos = new Vector3(spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
                // Rotate so that the animal faces left (-90 degrees around Y)
                rotation = Quaternion.Euler(0, -90, 0);
                break;
        }

        Instantiate(animalPrefabs[animalIndex], spawnPos, rotation);
    }
}
