using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float force = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            rb.AddForce(transform.up * force);
            Debug.Log("Pressed primary button.");
        }
    }
}
