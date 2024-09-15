using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDModule : MonoBehaviour
{
    [SerializeField] HealthModule healthModule;
    [SerializeField] TextMeshProUGUI healthModuleText;

    public void UpdateHealthUI(float healthValue)
    {
        healthModuleText.text = healthValue.ToString();

    }

    // Start is called before the first frame update
    void Start()
    {
        healthModule.OnHealthChanged += UpdateHealthUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
