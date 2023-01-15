using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPoint : MonoBehaviour
{
    Points pts;
    public TextMeshProUGUI pointCount;
    void Start()
    {
        pts = GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        pointCount.text = string.Format("{0:N0}", pts.points);
    }
}
