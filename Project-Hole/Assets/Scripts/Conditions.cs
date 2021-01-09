using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    public int points = 0;
    public OnChangePosition HoleScript;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        CalculateProgress();
    }

    private void CalculateProgress()
    {
        points++;

        if(points % 10 == 0)
        {
            StartCoroutine(HoleScript.ScaleHole());
        }
    }
}
