using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorIndicator : MonoBehaviour, IInteractable // calls ,IInteractable use alt enter
                                                       // to autocomplete and fix the error to make interactable.
{
    private bool IsUnlocked;
    [SerializeField] private UnityEvent OnInteracted;
    // meshrendering and color change variables.
    [SerializeField] private Material highlightedMaterial;

    private MeshRenderer mesh;
    private Material originalMaterial;

    private void Awake()
    {
        // gets the the mesh renderer for a color change.
        mesh = GetComponent<MeshRenderer>();
        originalMaterial = mesh.material;
    }
    public void OnHoverEnter()
    {
        if (!IsUnlocked)
        {
            return;
        }
        // mesh renderer accesses the material and is the highlighed material
        mesh.material = highlightedMaterial;
        Debug.Log("Aiming at the button");

    }

    public void OnHoverExit()
    {
        if (!IsUnlocked)
        {
            return;
        }
        // mesh renderer accesss the original material and reverts to unhighlighed.
        mesh.material = originalMaterial;
        Debug.Log("Stopped aiming at the button");
    }

    public void OnInteract(InteractModule module)
    {
        //Calls OnInteracted method and invokes it

        
        if(IsUnlocked)
        {
            OnInteracted.Invoke();
            Debug.Log("I is PANEL! WORKING NOW !!!!");
        }
    }

    public void UnlockDoor()
    {
        IsUnlocked = true;
    }
}
