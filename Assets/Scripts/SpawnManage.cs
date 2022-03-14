using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManage : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalPrefabIndex;
    private float xPosition = 13;


    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        float randXPos = Random.Range(-xPosition, xPosition);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randPos = new Vector3(randXPos, 0, 30);
        Instantiate(animalPrefabs[animalPrefabIndex], randPos,
            animalPrefabs[animalPrefabIndex].transform.rotation);
    }
}
