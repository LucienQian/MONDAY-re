using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;

    public PlayerController PC_Script;
    
    void Start()
    {
        PC_Script = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    
    void Update()
    {
        if (PC_Script.gameOver == false)
        {
            //控制遊戲物件左右移動
           transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
