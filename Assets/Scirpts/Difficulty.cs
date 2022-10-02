using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public float shots = 0f;

    public void AdjustShots(float newShots)
    {
        shots = newShots;
    }
}
