using UnityEngine;

public class TurretBullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;
    public GameObject impactEffect;
    public int damage = 10;
    public void SeekPlayer(Transform playertarget)
    {
        target = playertarget;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position -transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);

    }

    //private void DamagePlayer(Transform playertarget)
    //{
    //    PlayerDamage p = playertarget.GetComponent<PlayerDamage>();

    //    if (p != null)
    //    {
    //        p.TakeDamage(damage);
    //    }

    //    //Destroy(playertarget.gameObject);
    //}

    private void HitTarget()
    {
        GameObject effectInstance = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f);

        target.gameObject.GetComponent<HealthModule>()?.DeductHealth(9f);
        Destroy(gameObject);
        //Debug.Log("Player is getting hit!");
    }
}
