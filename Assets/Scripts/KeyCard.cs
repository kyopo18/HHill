using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyCard : MonoBehaviour
{
    [SerializeField] UnityEvent OnPickUp = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
         
        
            OnPickUp.Invoke();
            Destroy(gameObject);
        
    }
}
