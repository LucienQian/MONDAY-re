using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutLine : MonoBehaviour
{
    public float outLine = 30;
    public float outLineBotton = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.z > outLine)
        {
            Destroy(gameObject);
        } else if (transform.position.z < -outLineBotton)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 30)
        {
            Destroy(gameObject);
        }
    }
}
