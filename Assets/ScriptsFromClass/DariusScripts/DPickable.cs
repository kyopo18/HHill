//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DPickable : MonoBehaviour, IInteractable
//{
//    [SerializeField] private Rigidbody rb;
//    private Transform point;
    
//    public void OnHoverEnter()
//    {
        
//    }

//    public void OnHoverExit()
//    {
        
//    }

//    public void OnInteract(InteractModule module)
//    {
//        if(transform.parent == null)
//        {
//            Pickup(module);
//        }
//        else
//        {
//            Drop();
//        }
        

//    }

//    private void Pickup(InteractModule module)
//    {
//        rb.useGravity = false;
//        rb.isKinematic = true;
//        point = module.GetPickupTransform();
//        transform.position = point.position;
//        transform.rotation = point.rotation;
//        transform.SetParent(point);
//    }
//    private void Drop()
//    {
//        rb.useGravity = true;
//        rb.isKinematic = false;
//        transform.parent = null;
//    }
//}
