using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    Points pts;
    public TextMeshProUGUI first;
    public TextMeshProUGUI second;
    public TextMeshProUGUI third;

    void Start()
    {
        pts = GameObject.Find("PointsSystem").GetComponent<Points>();

        if (pts.points > PlayerPrefs.GetInt("Score3", 0))
        {
            if (pts.points > PlayerPrefs.GetInt("Score2", 0))
            {
                if (pts.points > PlayerPrefs.GetInt("Score1", 0))
                {
                    PlayerPrefs.SetInt("Score1", pts.points);
                }
                else 
                { 
                    PlayerPrefs.SetInt("Score2", pts.points);
                };
            }
            else 
            { 
                PlayerPrefs.SetInt("Score3", pts.points);
            };
        }
        first.text = PlayerPrefs.GetInt("Score1").ToString();
        second.text = PlayerPrefs.GetInt("Score2").ToString();
        third.text = PlayerPrefs.GetInt("Score3").ToString();
    }

}