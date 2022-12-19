using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    public Rigidbody playerRB;
    public float jumpForce = 10;
    public float gravityMod = 0;

    public bool isOnGround = true; //是否貼和地板

    public int twiceJump = 0; //二段跳計數

    public bool gameOver = false;

    //week15 使用動畫 Animator 1/3
    public Animator playerAnim; //宣告一個控制玩家的動畫控制器

    //使用粒子特效 ParticleSystem 1/2
    public ParticleSystem playerExplodation; //使用粒子特效 爆炸效果 1/2 
    public ParticleSystem playerDirt; //使用粒子特效 塵埃效果 1/4
    public AudioClip soundJump;
    public AudioClip soundCrash;
    public AudioSource playerSound;

    void Start()
    {
        //獲得剛體的控制權
        playerRB = GetComponent<Rigidbody>();//獲得剛體的控制權
        Physics.gravity = Physics.gravity * gravityMod; //調適重力

        //week15 使用動畫 Animator 2/3
        playerAnim = GetComponent<Animator>(); //取得本身物件的動畫控制元件
        //playerSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        //改為可二段跳方式(頂多二段跳)
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true && !gameOver) //!gameOver => gameOver == false
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //isOnGround = false; //切換1：false
            twiceJump++; //twiceJump = twiceJump + 1;
            //print("跳的次數: " + twiceJump);

            //week15 使用動畫 Animator 3/3
            playerAnim.SetTrigger("Jump_trig"); // 告訴電腦啟動跳躍 變數 
            playerAnim.speed = 5;
            playerDirt.Stop(); //使用粒子特效 塵埃效果 跳躍時要停止 2/4
            //playerSound.PlayerOneShot(soundJump, 3);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; //切換2：true
            twiceJump = 0; //二段跳使用
            //playerAnim.SetFloat("Speed_f", 1);
            playerAnim.speed = 1;
            playerDirt.Play(); //使用粒子特效 塵埃效果 接觸地面要播放 3/4
        } else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            print("Game Over!!!");

            //week15 使用動畫-倒下 Animator
            playerAnim.SetBool("Death_b", true); //使用動畫-倒下 Animator 1/2
            playerAnim.SetInteger("DeathType_int", 1); //使用動畫-倒下 Animator 2/2

            playerExplodation.Play(); //使用粒子特效 ParticleSystem 1/2
            playerDirt.Stop(); //使用粒子特效 塵埃效果 遊戲結束後要停止 4/4
            //playerSound.PlayerOneShot(soundCrash, 1);
        }
        
        
    }

}
