using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinny : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int spinSpeed = Random.Range(-200, 200);
        transform.Rotate(5 * Time.deltaTime, 5 * Time.deltaTime, 5 * Time.deltaTime);
    }
}
