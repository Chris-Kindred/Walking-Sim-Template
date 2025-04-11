using UnityEngine;
using static UnityEngine.RenderSettings;

public class RotateSky : MonoBehaviour
{
    public float rotateSpeed;
    void Update()
    {
        skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    
    }
}
