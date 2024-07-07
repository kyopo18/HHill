using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerDieModule : MonoBehaviour
{
    HealthModule healthModule;
    

    private void Start()
    {
        healthModule = GetComponent<HealthModule>();
        
        healthModule.OnDie += OnPlayerDie;
    }

    public void OnPlayerDie()
    {
        gameObject.SetActive(false);
        // Need a cutscene here and set player to be active again.
        // call game manager
    }

    
}
