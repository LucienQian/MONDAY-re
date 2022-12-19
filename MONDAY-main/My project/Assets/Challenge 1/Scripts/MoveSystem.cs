using UnityEngine;

public class MoveSystem : MonoBehaviour
{
   // [SerializeField, Header("²¾°Ê³t«×"), Range(0, 20)]
    public float speed = 50;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(speed * 0, 0, Time.deltaTime * 10);
    }
}
