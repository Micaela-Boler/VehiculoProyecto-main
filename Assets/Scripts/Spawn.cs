using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
   [SerializeField] GameObject randomEnemy;
   [SerializeField] GameObject[] Enemies;
   [SerializeField] Vector3 spawnPoint;

    int randomIndex;
    [SerializeField] float spawnTime = 4;
    [SerializeField] float repetition = 5;



    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, repetition);
    }


    public void SpawnEnemy()
    {
        randomIndex = Random.Range(0, Enemies.Length);
        randomEnemy = Enemies[randomIndex];

        Instantiate(randomEnemy, spawnPoint, randomEnemy.transform.rotation);
    }
}
