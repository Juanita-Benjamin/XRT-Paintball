using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Enemies : MonoBehaviour
{
    public static int hitCount = 0;
    public TextMeshProUGUI countText;


    private void Start()
    {
        countText = GameObject.FindWithTag("Hit Count").GetComponent<TextMeshProUGUI>();
    }

    private void OnCollisionEnter(Collision other)
    {
        hitCount++;
        countText.text = "Hit Count: " + hitCount;
        Destroy(gameObject);
        //hitCount++;
        Debug.Log("I've been hit");
       

    }

}
