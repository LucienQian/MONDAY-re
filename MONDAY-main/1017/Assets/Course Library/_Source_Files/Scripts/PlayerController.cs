using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("控制前後速度的數值"), Range(0, 20)]
    public float speed = 20; //宣告一個變數：speed

    [Header("左右速度")]
    public float turnSpeed = 50; //宣告左右移動的速度

    [Tooltip("前後鍵按下的偵測數值")]
    public float VInput;

    [Tooltip("左右鍵按下的偵測數值")]
    public float HInput;

    public float CrazyDrive;

    void Start()
    {
        
    }

    void Update()
    {
        VInput = Input.GetAxis("Vertical");//獲取鍵盤按下時取得的 (正/負) 數值

        HInput = Input.GetAxis("Horizontal");

        //用鍵盤控制前 (+) 後 (-)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VInput);
        print("VInput is : " + VInput); //DeBug: 檢查 INput 中的數值為何

        //用鍵盤控制右 (+) 左 (-)
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * HInput);
        print("HInput is : " + HInput);

        CrazyDrive = Random.Range(-15, 15);
        print("CD:" + CrazyDrive);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * CrazyDrive);
    }
}

