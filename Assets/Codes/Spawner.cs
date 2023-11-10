using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;

    private float timer;

    private void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.2f)
        {
            Spawn();
            timer = 0;
        }
        if (Input.GetButtonDown("Jump"))
        {
            GameManager.instance.pool.Get(1);
        }    
    }

    void Spawn()
    {
        GameObject enemy = GameManager.instance.pool.Get(Random.Range(0,4));
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
    }
}
