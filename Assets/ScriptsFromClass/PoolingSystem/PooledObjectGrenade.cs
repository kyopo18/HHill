using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObjectGrenade : PooledObject
{
    [SerializeField] ParticleSystem _particleSystem;
    public float grenadeRadius;


    public override void ResetBackToPool()
    {
        //SpawnExplosionParticles();
        CheckForTrigger();
        CameraShake.instance.TriggerShake();
        base.ResetBackToPool();
        
    }

    //private void SpawnExplosionParticles()
    //{
    //    // SPawn particles
    //    //_particleSystem?.Play();

    //}

    private void CheckForTrigger()
    {
        SoundManager.Instance.PlayHitSound(transform.position, 2);
        Collider[] hits = Physics.OverlapSphere(transform.position, grenadeRadius);
        foreach (Collider hit in hits)
        {
            
            
                
                
                hit.gameObject.GetComponent<HealthModule>()?.DeductHealth(200f);
            
        }
    }


}
