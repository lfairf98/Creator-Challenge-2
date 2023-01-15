using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 1;
    public float despawnRange = -30;

    void Update()
    {
        transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0); ;
        if (transform.position.x < despawnRange) {Destroy(this.gameObject);}
    }
}
