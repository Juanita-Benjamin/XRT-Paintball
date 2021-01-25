using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject paintball;

    public Transform barrel;
    // Start is called before the first frame update
    void Start()
    {
        if (barrel == null)
        {
            barrel = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(paintball, barrel.position, barrel.transform.rotation);
            
        }
        
    }

    public void OnCollisionEnter(Collision other)
    {
        Destroy(paintball);
    }
}
