using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    Points pts;
    AudioSource scoreSFX;

    private void Start()
    {
        pts = GameObject.Find("PointsSystem").GetComponent<Points>();
        scoreSFX = GameObject.Find("ScoreSFX").GetComponent<AudioSource>();
    }

    void OnTriggerExit(Collider other)
    {
        pts.points += 1;
        scoreSFX.Play(0);
    }
}