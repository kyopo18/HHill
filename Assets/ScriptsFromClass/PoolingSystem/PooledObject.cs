using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public Rigidbody rigidBody;
    private ObjectPool poolOwner;
    private float timerToReset;
    private bool resetting;

    public void LinkToPool(ObjectPool owner)
    {
        poolOwner = owner;
    }

    public void ResetBackToPool()
    {
        rigidBody.velocity = Vector3.zero;
        resetting = false;
        poolOwner.ResetBullet(this);
    }

    public void ResetBackToPool(float time)
    {
        timerToReset = time;
        resetting = true;
    }

    private void Update()
    {
        if(resetting)
        {
            timerToReset -= Time.deltaTime;
            if(timerToReset <= 0)
            {
                ResetBackToPool();
            }
        }
    }

    private void OnEnable()
    {
        Debug.Log("I'm ACTIVE.");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I hit something!I hit! I hit!");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<HealthModule>()?.DeductHealth(8f);

            ResetBackToPool();
        }


        //    {
        //        if (collision.gameObject.CompareTag("Player"))
        //        {
        //            collision.gameObject.GetComponent<HealthModule>()?.DeductHealth(10f);

        //            ResetBackToPool();
        //        }
        //    }
        //}

    }
    }
