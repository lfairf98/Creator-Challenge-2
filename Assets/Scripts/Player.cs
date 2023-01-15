using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public GameObject LeaderboardUI;
    public GameObject LeaderboardController;
    public float force = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyUp("space")){rb.AddForce(transform.up * force);}
    }

    private void OnCollisionEnter(Collision collision)
    {
        LeaderboardUI.SetActive(true);
        LeaderboardController.SetActive(true);
        //Debug.Log("Collided");
    }
}
