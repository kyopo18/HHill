using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthModule : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    public Action<float> OnHealthChanged;
    public Action OnDie;
    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = _maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DeductHealth(float toDeduct)
    {
        currentHealth -= toDeduct;
        Debug.Log(currentHealth.ToString() +"  "+ toDeduct.ToString());
        OnHealthChanged?.Invoke(currentHealth);
        if (currentHealth <= 0)
        {
            OnDie?.Invoke(); //This is the issue..
            
            
        }
    }

    public int health = 100;
    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }

    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
