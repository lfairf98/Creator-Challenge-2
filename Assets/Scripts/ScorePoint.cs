using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    Points pts;

    private void Start()
    {
        pts = GameObject.Find("PointsSystem").GetComponent<Points>();
    }

    void OnTriggerExit(Collider other)
    {
        pts.points += 1;
    }
}