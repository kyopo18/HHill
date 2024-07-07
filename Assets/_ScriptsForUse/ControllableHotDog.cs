using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllableHotDog
{
    // HotDog's Default Attributes:
    public ShelfLife shelfLifeValue; // HotDog's Default Health Bar.
    [SerializeField] private float speed; // HotDog's Default Walking Speed.
    [SerializeField] private float runningSpeed; // HotDog's Default Running Speed.
    [SerializeField] private float crouchMoveSpeed; // HotDog's Default Crouching Move Speed.
    [SerializeField] private int fireRate; // HotDog's Default Rate Of Fire based on his Training and Experience.
    [SerializeField] private float morale; // HotDog's starting Default Level of Morale.
    [SerializeField] private int size; // HotDog's current Size. (Determines Smasher's permanent increase in starting health and morale from a Minimum to a Maximum Size.)
    [SerializeField] private int strength; // HotDog's current strength. (Strength determines ability to wield weapons.)

    public virtual void RangedAttack()
    {

    }

    public virtual void DeadMeat()
    {

    }

    public virtual void Move()
    {

    }
    public ControllableHotDog()
    {

    }
    public ControllableHotDog(ShelfLife shelfLifeValue, float speed, float runningSpeed, float crouchMoveSpeed, int fireRate, float morale, int size, int strength)
    {
        this.shelfLifeValue = shelfLifeValue;
        this.speed = speed;
        this.runningSpeed = runningSpeed;
        this.crouchMoveSpeed = crouchMoveSpeed;
        this.fireRate = fireRate;
        this.morale = morale;
        this.size = size;
        this.strength = strength;
        shelfLifeValue = new ShelfLife(100);
    }
}
