using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampColorChange : MonoBehaviour
{
    public Material rampColor;

    private void Start()
    {
        rampColor.color = Color.green;
    }
    private void OnCollisionEnter(Collision collision)
    {
        rampColor.color = Color.cyan;
    }
}
