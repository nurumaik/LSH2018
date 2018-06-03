using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities {
    public static Vector2 genRandomVector(float lenMin, float lenMax)
    {
        var angle = Random.Range(0f, 2f * Mathf.PI);
        var absolute = Random.Range(lenMin, lenMax);
        return new Vector2(absolute * Mathf.Cos(angle), absolute * Mathf.Sin(angle));
    }
}
