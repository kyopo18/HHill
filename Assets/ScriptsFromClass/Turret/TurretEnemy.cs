using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretEnemy : MonoBehaviour
{
    private Transform target;

    [Header("Attributes")]
    
    public float range = 100f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    [Header("Unity Setup Fields")]

    public string playerTag = "Player";

    public Transform partToRotate;
    public float turnSpeed = 10f;

    public GameObject turretBulletPrefab;
    public Transform turretFirePoint;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    private void UpdateTarget()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag(playerTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestPlayer = null;
        foreach (GameObject player1 in player)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player1.transform.position);
            if (distanceToPlayer < shortestDistance ) 
            {
                shortestDistance = distanceToPlayer;
                nearestPlayer = player1;
            }
        }

        if(nearestPlayer != null && shortestDistance <= range) 
        {
            target = nearestPlayer.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (target == null)
            return;

        // Player targeter
        Vector3 direction = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);

        if (fireCountdown <= 0 )
        {
            Fire();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

    }

    private void Fire()
    {
        SoundManager.Instance.PlayShootSound(transform.position);
        GameObject turretBulletGO = (GameObject)Instantiate(turretBulletPrefab, turretFirePoint.position, turretFirePoint.rotation);
        TurretBullet turretBullet = turretBulletGO.GetComponent<TurretBullet>();
        //Debug.Log("Fire");

        if (turretBullet != null )
            turretBullet.SeekPlayer(target);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
