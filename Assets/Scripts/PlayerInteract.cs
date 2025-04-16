using UnityEngine;
using TMPro;

public class PlayerInteract : MonoBehaviour
{
    public Camera PlayerCamera;
    public float InteractionDistance = 3;
    public GameObject interactionText;
    private InteractableObject currentInteractable;
    void Update()
    {
        Ray ray = PlayerCamera.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));
        RaycastHit hit;
		
        
        if(Physics.Raycast(ray, out hit, InteractionDistance)) //if the raycast hits something we're handling,
                                                               //execute this script to enable to text and set the current Interactable object
        {
            InteractableObject interactableObject = hit.collider.GetComponent<InteractableObject>();
            if(interactableObject != null && interactableObject != currentInteractable)
            {
                currentInteractable = interactableObject;
                interactionText.SetActive(true);
                TextMeshProUGUI textComponent = interactionText.GetComponent<TextMeshProUGUI>();
                if (textComponent != null)
                {
                    textComponent.text = currentInteractable.interactionText; //Sets the text component to the current interactable text
                }
            }
        }

        else //if we're not looking at an interactable object, we set the current interactable to nothing and disable the interaction text
        {
            currentInteractable = null;
            interactionText.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            currentInteractable?.Interact(); //the question mark keeps the script from firing under similar, unpredicted conditions.
        }
    }
}
