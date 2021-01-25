using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintBall : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(ball);
    }
}
