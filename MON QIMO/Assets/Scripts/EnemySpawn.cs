using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] animalPrefab;

    void Start()
    {
        //重複呼叫某個函數(名字, 遊戲啟動延遲的時間, 重複的時間)
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f); 
    }

    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int a_Index = Random.Range(0, 3);
        Vector3 spawnPos = new Vector3(Random.Range(-15, 15), 0, 20);
        Instantiate(animalPrefab[a_Index], spawnPos, animalPrefab[a_Index].transform.rotation);
    }



}
