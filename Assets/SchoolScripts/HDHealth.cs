using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDHealth 
{
    public int hdmaxHealth = 100;
    public int hdcurrentHealth = 100;

    public void TakeDamage(int damage)
    {
        Random.Range(0, hdmaxHealth);
        hdcurrentHealth -= damage;
        // spawn damage effect
        // if health is 0
    }

    public void Heal()
    {

    }
}
