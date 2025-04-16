using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
   public string interactionText = "Press E to Interact";
   public UnityEvent onInteract;

   public string GetInteractionText()
   {
      return interactionText;
   }

   public void Interact()
   {
      onInteract.Invoke(); //Calls for the Unity event
   }
   
}

