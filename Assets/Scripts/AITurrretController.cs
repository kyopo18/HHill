using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.AI;

public class AITurretController : MonoBehaviour
{
    [SerializeField] public float damagePerSec { get; private set; } = 10f;

    public AITurretState turretState { get; private set; }
    public TurretCast turretCast { get; private set; }
    public void linkTurretCast (TurretCast turretCast) 
    {
        this.turretCast = turretCast;    
    }


    // Start is called before the first frame update
    void Start()
    {
        ChangeState(new IdleState(this));
    }

    // Update is called once per frame
    void Update()
    {

        turretState.OnStateRun();
    }

    public void ChangeState(AITurretState state)
    {
        if (turretState != null)
        {
            turretState.OnStateExit();
        }

        turretState = state;
        turretState.OnStateEnter();
    }

  



}
