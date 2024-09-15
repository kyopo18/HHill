using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private List<PooledObject> availableObjects = new List<PooledObject>();
    [SerializeField] private PooledObject originalObject;
    [SerializeField] private int amountOfCopies;

    private void Awake()
    {

        for (int index = 0; index < amountOfCopies; index++)
        {
            CreatingCopy();
        }

    }

    private void CreatingCopy()
    { 
        //sets a for loop for the projectile prefab objects in an object pool to save memory allocation.
        
        {
            PooledObject tempObject = Instantiate(originalObject, transform);
            tempObject.LinkToPool(this);
            tempObject.gameObject.SetActive(false);
            //adds a copy we created to the list of objects in the pool.
            availableObjects.Add(tempObject);
        }
    }

    // retrieves the actual gameobject
    public PooledObject RetrieveAvailableItem(int index = 0)
    {
        if(availableObjects.Count == 0)
        {
            CreatingCopy();
        }

        // available object is the first object marked 0
        PooledObject tempObject = availableObjects[0];
        tempObject.Initialize(index);
        // removes the first 0 object from the pool.
        availableObjects.RemoveAt(0);
        tempObject.gameObject.SetActive(true);
        return tempObject;

    }

    public void ResetBullet(PooledObject cloneObject)
    {
        cloneObject.gameObject.SetActive(false);
        availableObjects.Add(cloneObject);
    }
}
