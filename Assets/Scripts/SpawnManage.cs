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
        
    }

    // Update is called once per frame
    void Update()
    {
        float randXPos = Random.Range(-xPosition, xPosition);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(animalPrefabs[animalPrefabIndex], new Vector3(randXPos, 0, 30), animalPrefabs[animalPrefabIndex].transform.rotation);

        }
    }
}
