using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//06/04/2024 Tues

public interface IInteractable //The interactable class interface I is put in front of thename to call it an interface.
{
    
    public void OnHoverEnter();
    public void OnHoverExit();
    public void OnInteract(InteractModule module);

    //public void OnUnInteract();
}
