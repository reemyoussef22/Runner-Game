using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{

    public static float Leftside = -3.5f;
    public static float Rightside = 3.5f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {

        internalLeft = Leftside;
        internalRight = Rightside;

    }
}
