using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [Header("遊戲物件"), Tooltip("請放你要隨的遊戲物件")]
    public GameObject player;  //放置定義區塊
    //訪問級別 變數型態 變數名稱 (= 變數數值)

    [Header("攝影機偏移量")]
    public Vector3 offset = new Vector3 (0, 5, -3);

    public float speed = 20; //前後移動變數

    public float trunspeed = 10; //左右移動物度    
    

    // Start 只執行一次
    void Start()
    {
        
    }

    // Update 一直執行
    void LateUpdate()
    {
        //把此程式的位置參照player遊戲物件的位置 + 偏移量
        transform.position = player.transform.position + offset; 
    }
}
