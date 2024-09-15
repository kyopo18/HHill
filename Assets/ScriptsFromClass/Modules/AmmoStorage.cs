using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AmmoStorage : MonoBehaviour
{
    [SerializeField] private int ammo;
    [SerializeField] private int grenades;
    [SerializeField] private int maxAmmo;
    [SerializeField] private int maxGrenades;

    public UnityEvent<int> OnAmmoChanged = new UnityEvent<int>();
    public UnityEvent<int> OnGrenadesChanged = new UnityEvent<int>();

    public void AddAmmo(int ammoToAdd)
    {
        if (ammoToAdd + ammo >= maxAmmo)
        {
            ammo = maxAmmo;
        }

        else
        {
            ammo += ammoToAdd;
        }

        OnAmmoChanged.Invoke(ammo);
    }

    public void AddGrenade(int grenadesToAdd)
    {
        if (grenadesToAdd + grenades >= maxGrenades)
        {
            grenades = maxGrenades;
        }

        else
        {
            grenades += grenadesToAdd;
        }

        OnGrenadesChanged.Invoke(grenades);
    }

    public bool checkAmmo()
    {
        if (ammo > 0)
        {
            ammo--;
            OnAmmoChanged.Invoke(ammo);
            return true;
        }

        return false;

    }

    public bool checkGrenades()
    {
        if (grenades > 0)
        {
            grenades--;
            OnGrenadesChanged.Invoke(grenades);
            return true;
        }

        return false;

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
