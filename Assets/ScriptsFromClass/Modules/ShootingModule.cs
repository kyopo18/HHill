using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingModule : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    [Header("Shooting")]
    [SerializeField] private Rigidbody projectile;
    [SerializeField] private Camera cam;
    [SerializeField] private Transform shootingPoint;
    // Start is called before the first frame update

    public void Shoot()
    {
        //pressing the left click fires a projectile prefab
        if (Input.GetMouseButtonDown(0))
        {
            PooledObject tempPooled = pool.RetrieveAvailableItem();
            //Create Projectile ...Stored GameObject named as a parameter = to an instantiated bullet with transform and rotation
            Rigidbody bulletInstantiated = tempPooled.rigidBody;// Instantiate(projectile, shootingPoint.position, shootingPoint.rotation);
            // called the rigidbody game object that is stored and the Rigidbody of it. Rigid body is for physics.
            // bulletInstantiated calls the object 10f is speed of the projectile
            // shooting point is where the projectile emits from
            // forward is the z axis on the shooting point empty object
            // connected to the inspector will make a projectile shoot out.
            // changing the mass of the projectile prefab in inspector will make the projectile fly faster.
            // ForceMode.Impulse is the type of force applied. changes behavior.
            // shootingPoint.forward shoots from the shooting point
            // camera.transform.forward shoots from the camera instead.
            bulletInstantiated.position = shootingPoint.position;
            bulletInstantiated.rotation = shootingPoint.rotation;
            bulletInstantiated.AddForce(50f * cam.transform.forward, /*shootingPoint.forward,*/ ForceMode.Impulse);
            //Destroys the instantiated bullet after 5 seconds. "5f" clears memory.
            //Destroy(bulletInstantiated.gameObject, 5f);
            tempPooled.ResetBackToPool(5f);
        }
    }
}
