using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private float SceneTop = 36.0f;
    private float SceneBot = -15.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > SceneTop)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < SceneBot)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
        
    }
}
