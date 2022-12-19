using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [Header("遊戲物件"), Tooltip("請放你要跟隨的遊戲物件")]
    public GameObject player;

    [Header("攝影機偏移量")]
    public Vector3 offset = new Vector3(0, 5, -7); //宣告一個 offset 新座標
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //把此程式的位置參照 player遊戲物件的位置
        transform.position = player.transform.position + offset; //攝影機的座標加上「偏移量」
    }
}
