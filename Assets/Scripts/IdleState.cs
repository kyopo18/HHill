using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : AITurretState
{
    public IdleState(AITurretController contr) : base(contr)
    {
    }

    public override void NextState()
    {
        controller.ChangeState(new AttackState(controller, controller.turretCast.healthModule));
    }

    public override void OnStateEnter()
    {
        controller.turretCast.OnTargetSee.AddListener(NextState);
    }

    public override void OnStateExit()
    {
        controller.turretCast.OnTargetSee.RemoveListener(NextState);
    }

    public override void OnStateRun()
    {
        
    }

    
    
}
