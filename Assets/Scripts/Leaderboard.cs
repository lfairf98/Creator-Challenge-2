using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    int[] score = new int[3];
    
    void Start()
    {
        score[0] = 0;
        score[1] = 0;
        score[2] = 0;
    }

}
