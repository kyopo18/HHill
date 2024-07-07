using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeySlot : MonoBehaviour , IInteractable
{
    public UnityEvent <int> onUnlock;
    [SerializeField] KeyColor requiredKey;
    [SerializeField] Transform KeyHolder;
    [SerializeField] KeyOpen keyOpenPrefab;
    public void OnHoverEnter()
    {
        
    }

    public void OnHoverExit()
    {
        
    }

    public void OnInteract(InteractModule module)
    {
        KeyInventory ki = module.GetComponent<KeyInventory>();
        if (ki != null) 
        {
            if (ki.CheckKey(requiredKey))
            {
                onUnlock.Invoke((int)requiredKey);
                Instantiate(keyOpenPrefab, KeyHolder);
            }
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
