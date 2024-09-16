using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pickable : MonoBehaviour, IInteractable
{
    //06/04/24
    [SerializeField] private Rigidbody rb;
    private Transform point;
    // Variable for a fixed joint to pick up objects. 
    

    private void PickUp() //Need to change this. //06/04/24
    {
        //// Connects a joint to the player and pickable object.
        //PlayerInput player = FindObjectOfType<PlayerInput>();
        //joint = gameObject.AddComponent<FixedJoint>();
        //// gets the joint and connects it to player
        //joint.connectedBody = player.GetComponent<Rigidbody>();

    }

    private void Drop()
    {

    }
    public void OnHoverEnter()
    {
       
    }

    public void OnHoverExit()
    {
        
    }

    // Putting PlayerInput Class into the parameter and calling it player gives easy access to the Player.
    public void OnInteract(InteractModule module)
    {
        Debug.Log("Anything");
        if(transform.parent == null)
        {
            // Joint attaches itself to a rigidbody. needs a gameobject to attach to adds the component and grabs the 
            // <type> of component then () makes it a method;

            // transform.position is the position of the player calling the point of the hold
            // into the fixed position on the player.
            // putting this as the first line makes it attachable as it sets the position first.
            // and rotation
            // we are going to pick it up here
            rb.useGravity = false;
            rb.isKinematic = true;

            point = module.GetHoldTransform();
            transform.position = point.position;
            transform.rotation = point.rotation;
            // Set Parent sets parent in inspector and the child in the () which is point.
            transform.SetParent(point);

            //transform.rotation = Quaternion.identity;



            // grabs rigidbody from player.
            // Interpolate setting in Inspector of the Pickable Object rigidbody helps object move more smoothly.
            //transform.position = point.position;
            //transform.rotation = point.rotation; 
        }
        else
        {
            //Drops the object.
            // Destroys only the joint. not the game object.

            rb.useGravity = true;
            rb.isKinematic = false;
            // Set Parent sets parent in inspector and the child in the () which is point.
            transform.SetParent(null);

        }
        
    } 
}
