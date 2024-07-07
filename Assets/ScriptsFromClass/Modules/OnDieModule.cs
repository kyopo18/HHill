using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDieModule : MonoBehaviour
{
    [SerializeField] HealthModule healthModule;
    
    void Start()
    {
        healthModule.OnDie += OnDie; 
    }

    private void OnDie()
    {
        Debug.Log("Prefab is being destroyed", this);
        Destroy(gameObject);
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
