using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] animalPrefab;

    void Start()
    {
        // 重複呼叫某個函數(名字、遊戲啟動延遲的時間、重複的時間)
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    void Update()
    {
        
          
    }

    void SpawmRandomAnimal()
    {
       print("動物來了！");
       //隨機產生亂數的索引值(0~2)
       int a_Index = Random.Range(0, 3);
       print("索引值是：" + a_Index);

       Vector3 spawanPos = new Vector3(Random.Range(-15, 15), 0, 20);

       //生成敵人
       Instantiate(animalPrefab[a_Index], spawanPos, animalPrefab[a_Index].transform.rotation);
        
    }
}

