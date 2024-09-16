using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurretCast : MonoBehaviour
{
    [SerializeField] private AITurretController myController;
    [SerializeField] private Transform laserStart;
    [SerializeField] private float laserRange = 100f;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private LayerMask everythingElseMask;
    [SerializeField] private LineRenderer laserLine;

    public UnityEvent OnTargetSee;
    public UnityEvent OnTargetLost;
    private bool targetSee;
    public HealthModule healthModule  {get; private set; }

    private void Awake()
    {
        myController.linkTurretCast(this);
    }

    // Update is called once per frame
    private void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(laserStart.position, -laserStart.transform.forward, out hit, laserRange, everythingElseMask))
        {
            laserLine.SetPosition(1, hit.point);
            
            if(healthModule != null) 
            {
                healthModule = null;
                OnTargetLost?.Invoke();
            }
            
        }
        else if (Physics.Raycast(laserStart.position, -laserStart.transform.forward, out hit, laserRange, playerMask))
        {
            laserLine.SetPosition(1, hit.point);

            if (healthModule == null)
            {
                healthModule = hit.collider.attachedRigidbody.GetComponent<HealthModule>();
                OnTargetSee?.Invoke();
            }

        }
        else
        {
            laserLine.SetPosition(1, laserStart.position - laserStart.transform.forward * laserRange);
            if (healthModule != null)
            {
                healthModule = null;
                OnTargetLost?.Invoke();
            }
        }
        laserLine.SetPosition(0, laserStart.position);
        
    }
}
