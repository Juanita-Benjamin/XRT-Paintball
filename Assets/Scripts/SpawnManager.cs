using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemySpawn;
    private float xRange = 8;
    private float _yRange = -4.36f;
    private float spawnRate = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = RandomSpawn();
       //ty StartCoroutine(Spawn());
       StartCoroutine(Spawn());

    }
    
    IEnumerator Spawn()
    {
       
        //spawn targets
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(enemySpawn, RandomSpawn(), Quaternion.identity);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    Vector3 RandomSpawn()
    {
        return new Vector3(Random.Range(-xRange, xRange),_yRange , 0);
    }
}
