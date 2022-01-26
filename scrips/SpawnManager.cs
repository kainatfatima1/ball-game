using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private float spawnRange = 9;
    
    private int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        SpwEnemy();
    }
    // Update is called once per frame
    void Update()
    {
        //if (enemyCount == 0)
        //{
        //    Vector3 randomPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        //    int index = Random.Range(0, enemyPrefab.Length);
        //    Instantiate(enemyPrefab[index], randomPos, enemyPrefab[index].transform.rotation);
        //}
       
    }
    void SpwEnemy()
    {
        for(int i = 0; i < 5; i++)
        {
            int randomEnemy = Random.Range(0, enemyPrefab.Length);
            Instantiate(enemyPrefab[randomEnemy], SpawnPos(), enemyPrefab[randomEnemy].transform.rotation);


        }
    }
    private Vector3 SpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomspawn = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomspawn;
    }



}
