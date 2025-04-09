using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    public Transform teleportTarget;
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
        Debug.Log("Teleported");
    }
}
