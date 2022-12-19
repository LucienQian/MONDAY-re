using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCollition : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//自我刪除
        Destroy(other.gameObject);//刪除碰撞到的
    }
}
