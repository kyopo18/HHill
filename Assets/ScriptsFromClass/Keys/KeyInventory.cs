using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyInventory : MonoBehaviour
{
    public UnityEvent<int> OnKeyPickUp;
    public UnityEvent<int> OnKeyFinished;
        
    [SerializeField] List<KeyColor> keys = new List<KeyColor>();

    public void AddKey(KeyColor keyToAdd)
    {
        keys.Add(keyToAdd);
        OnKeyPickUp?.Invoke((int)keyToAdd);
    }

    private void RemoveKey(KeyColor keyToRemove) 
    {  
        keys.Remove(keyToRemove);
        OnKeyFinished?.Invoke((int)keyToRemove);
    }

    public bool CheckKey(KeyColor keyToCheck)
    {
        for (int i = 0; i < keys.Count; i++)
        {
            if (keys[i] == keyToCheck)
            {
                RemoveKey(keyToCheck);
                return true; 
            }

        }
        return false;
    }
}
