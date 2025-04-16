using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    private Animator doorAnimator;
    
    void Start()
    {
        doorAnimator = gameObject.GetComponent<Animator>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimator.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimator.SetTrigger("Closed");
        }
    }
}
