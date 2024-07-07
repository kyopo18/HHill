using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInventory : MonoBehaviour
{
    [SerializeField] List<KeyColor> keys = new List<KeyColor>();

    public void AddKey(KeyColor keyToAdd)
    {
        keys.Add(keyToAdd);
    }

    private void RemoveKey(KeyColor keyToRemove) 
    {  
        keys.Remove(keyToRemove);
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
