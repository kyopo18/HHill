using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : AITurretState
{
    private HealthModule healthModule;
    public AttackState(AITurretController contr, HealthModule health) : base(contr)
    {
        healthModule = health;
    }

    public override void NextState()
    {
        controller.ChangeState(new IdleState(controller));
    }

    public override void OnStateEnter()
    {
        controller.turretCast.OnTargetLost.AddListener(NextState);
    }

    public override void OnStateExit()
    {
        controller.turretCast.OnTargetLost.RemoveListener(NextState);
    }

    public override void OnStateRun()
    {
        healthModule.DeductHealth(controller.damagePerSec * Time.deltaTime);
    }
}
