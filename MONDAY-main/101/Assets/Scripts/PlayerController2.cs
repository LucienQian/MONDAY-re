using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float H_Input;
    public float speed = 20;

    public GameObject foodBullet;
    
    void Start()
    {
        
    }

    void Update()
    {
        H_Input = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * H_Input * Time.deltaTime * speed);

        if (transform.position.x >= 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        } else if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("fire!");
            Instantiate(foodBullet, transform.position, foodBullet.transform.rotation);
        }

    }
}
