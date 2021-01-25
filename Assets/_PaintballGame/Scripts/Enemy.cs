using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    public int hitCount = 0;
    public TextMeshProUGUI countText;

    public void OnCollisionEnter(Collision other)
    {
        hitCount++;
        countText.text = "Hit Count: " + hitCount;
    }
}
