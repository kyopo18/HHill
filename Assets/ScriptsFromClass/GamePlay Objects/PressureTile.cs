using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // accesses event

public class PressureTile : MonoBehaviour
{
    [SerializeField] private Rigidbody correctRigidBody;
    // accesses UnityEvent behavior.
    [SerializeField] private UnityEvent OnActivation;
    [SerializeField] private UnityEvent OnDeactivation;

    private void OnTriggerEnter(Collider other)
    {
        //accesses rigidbody
        if(other.attachedRigidbody == correctRigidBody)
        {
            OnActivation.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody == correctRigidBody)
        {
            OnDeactivation.Invoke();
        }
    }
}
