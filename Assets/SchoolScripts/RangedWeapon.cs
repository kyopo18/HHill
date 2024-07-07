using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon 
{
    public int damage;
    public int currentAmmo;
    public float fireRate;
    public RangedBullet rangedBullet;
    public float timeRequiredToCharge;

    public void TimeRequiredToCharge()
    {

    }


    public void FireWeapon()
    {
        currentAmmo--;
    }

    public void Reload()
    {

    }
    public void Drop()
    {

    }

    public RangedWeapon(int damage, int currentAmmo, float fireRate, RangedBullet rangedBullet, float timeRequiredToCharge)
    {
        this.damage = damage;
        this.currentAmmo = currentAmmo;
        this.fireRate = fireRate;
        this.rangedBullet = rangedBullet;
        this.timeRequiredToCharge = timeRequiredToCharge;
    }
}
