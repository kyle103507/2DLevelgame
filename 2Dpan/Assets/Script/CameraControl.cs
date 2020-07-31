using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    
    public float speed;
    public int countFloor;
    public Text textCount;

    public Transform transform;

    private void Count()
    {
        countFloor = Mathf.Abs((int)transform.position.y / 2);
        textCount.text = "攻略層數"  + countFloor;
    }






    private void Update()
    {
        transform.Translate( Vector3.down * Time.deltaTime *speed);

        Count();
    }



}
