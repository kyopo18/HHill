using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class HealthModule : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    public Action<float> OnHealthChanged;
    public UnityEvent OnDie;
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

        OnHealthChanged.Invoke(currentHealth);

        if (health <= 0)
        {
            Die();
        }

        
    }

    public void AddHealth(int amount)
    {
        if (currentHealth + amount >= _maxHealth)
        {
            currentHealth = _maxHealth;
        }

        else
        {
            currentHealth += amount;
        }

        OnHealthChanged.Invoke(currentHealth);

    }

    private void Die()
    {
        Debug.Log("Hey im looping!");
        gameObject.SetActive(false);
        //OnDie?.Invoke();


    }
}
