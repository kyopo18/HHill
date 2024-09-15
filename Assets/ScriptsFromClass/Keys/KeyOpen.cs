using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOpen : MonoBehaviour
{
    [SerializeField] KeyColor keyColor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SoundManager.Instance.PlayPickupSound(transform.position, 3);
            other.gameObject.GetComponent<KeyInventory>()?.AddKey(keyColor);
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }   
}
