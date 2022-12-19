using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutLine : MonoBehaviour
{
    public float outLineTop = 30;
    public float outLineBotton = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //(子彈)超出一定的範圍就要刪除
        if (transform.position.z > outLineTop)
        {
            Destroy(gameObject);
        } else if (transform.position.z < -outLineBotton)
        {
            Destroy(gameObject);
            print("Game Over!");
        }
    }
}
