using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyCard : MonoBehaviour
{
    [SerializeField] UnityEvent OnPickUp = new UnityEvent();
    [SerializeField] int Index;

    private void OnTriggerEnter(Collider other)
    {
        SoundManager.Instance.PlayPickupSound(transform.position, Index);
        
            OnPickUp.Invoke();
            Destroy(gameObject);
        
    }
}
