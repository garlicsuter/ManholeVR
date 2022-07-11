using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class SplineTweener : MonoBehaviour
{
    public Spline mySpline;
    public Transform myObject;

    void Awake()
    {
        Tween.Spline(mySpline, myObject, 0, 1, true, 2, 0, Tween.EaseIn, Tween.LoopType.PingPong);
    }
}
