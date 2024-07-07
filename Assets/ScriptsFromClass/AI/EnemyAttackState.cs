using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyAttackState : AIState
{
    private Transform shootingPoint;
    private ObjectPool pool;
    private Transform target;
    private float enemyTimer = 0.5f;
    private float resetTimer = 0.5f;

    public EnemyAttackState(AIController contr, Transform shootingPoint, ObjectPool pool, Transform target) : base(contr)
    {
        this.shootingPoint = shootingPoint;
        this.pool = pool;
        this.target = target;
        this.target = target;
    }

    public override void OnStateEnter()
    {
        
    }

    public override void OnStateExit()
    {
        
    }

    public override void OnStateRun()
    {
        //controller.transform.LookAt(target);
        //Shoot();
    }

    public void Shoot()
    {
        //pressing the left click fires a projectile prefab
        if (enemyTimer <= 0 )
        {
            enemyTimer %= resetTimer; 
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
            bulletInstantiated.AddForce(100f * shootingPoint.transform.forward, /*shootingPoint.forward,*/ ForceMode.Impulse);
            //Destroys the instantiated bullet after 5 seconds. "5f" clears memory.
            //Destroy(bulletInstantiated.gameObject, 5f);
            tempPooled.ResetBackToPool(5f);
        }

        enemyTimer -= Time.deltaTime;
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
