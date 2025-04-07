using UnityEngine;

public class Rotate : MonoBehaviour
{
  
    public float rotateSpeedX;
    public float rotateSpeedY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeedX, rotateSpeedY * Time.deltaTime, 0f, Space.Self);
    }
}
