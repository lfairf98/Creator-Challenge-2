using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstSpawner : MonoBehaviour
{
    
    public float rangeUpper = 10f;
    public float rangeLower = -10f;
    public float rate = 1f;
    float delay = 0;
    public GameObject obstacle;

    
    void Update()
    {

        if (delay > 0) { delay -= Time.deltaTime; }
        else
        {
            Vector3 position = new Vector3(transform.position.x, Random.Range(rangeLower, rangeUpper), transform.position.z);
            Instantiate(obstacle, position, transform.rotation);
            delay = rate;
        }
    }
}
