using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    //Creates a variable to access the animator.
    [SerializeField] private Animator animator;

    public void OpenDoor()
    {
        //command on animator to Set Bool.
        // Sets the DoorOpen Bool on the animator to true.
        //syntax is animator .accesses SetBool command "DoorOpen" exact name, apostrophe "true"
        //for the the bool setting to open the door.
        animator.SetBool("DoorOpen", true);
    }

    public void CloseDoor()
    {
        //command on animator to Set Bool.
        // Sets the DoorOpen Bool on the animator to true.
        //syntax is animator .accesses SetBool command "DoorOpen" exact name, apostrophe "false"
        //for the the bool setting to close the door.
        animator.SetBool("DoorOpen", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other) // Treated the same as update, impacts performance, same as Update()
    {
       // Debug.Log("Inside the trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
