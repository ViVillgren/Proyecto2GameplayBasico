using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagment : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPos = new Vector3(0, 0, 20);
    public int animalIndex;
    public float randomX;
    private float limX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SpawnRandomAnimal()
    {
        randomX = Random.Range(-limX, limX);
        spawnPos = new Vector3(randomX, 0, 25);
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[0].transform.rotation);
    }
}
