using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);

    public float delayTime = 1.5f;
    public float repeatTime = 2;

    public PlayerController3 PC_Script;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObstacleSpawn", delayTime, repeatTime);
        PC_Script = GameObject.Find("Player").GetComponent<PlayerController3>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ObstacleSpawn()
    {
        if (PC_Script.gameOver == false) //如果遊戲沒有結束，就...
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }


    }
}
