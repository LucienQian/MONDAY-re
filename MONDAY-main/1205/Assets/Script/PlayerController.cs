using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod = 1;

    public bool isOnGround = true; //是否貼合地板

    public int twiceJump = 0; //二段跳計數

    public bool gameOver = false;
    
    void Start()
    {
        //獲得剛體的控制權
        playerRB = GetComponent<Rigidbody>();
        //playerRB.AddForce(Vector3.up * 1000); //針對此剛體施加力道.方向*力量
        Physics.gravity = Physics.gravity * gravityMod;  //Physics.gravity *= gravityMod;調適重力
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && twiceJump <2)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isOnGround = false; //切換：false
            twiceJump++; //twiceJump = twiceJump + 1
            print("跳的次數： + twiceJump");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; //切換回：true
            //twiceJump = 0;
        }else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            print("gameOver!");
        }
        
    } 
        
}
