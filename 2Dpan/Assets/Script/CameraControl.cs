using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    public float speed;

    public Transform transform;

    






    private void Update()
    {
        transform.Translate( Vector3.down * Time.deltaTime *speed);
    }



}
