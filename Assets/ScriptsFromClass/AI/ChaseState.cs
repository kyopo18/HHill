using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChaseState : AIState
{
    private Transform targetToChase;
   public ChaseState(AIController contr, Transform target) : base(contr)
    { 
        targetToChase = target;
    }
    public override void OnStateEnter()
    {
        Debug.Log("chase is happening.");
    }

    public override void OnStateExit()
    {
        Debug.Log("chase is happening");
    }

    public override void OnStateRun()
    {
        Debug.Log("chase is happening");

        controller.GetAgent().SetDestination(targetToChase.position); //set destination to player position every frame.
        if (controller.GetAgent().remainingDistance <= controller.GetAgent().stoppingDistance)
        {
            // change state to attack
            controller.ChangeState(new EnemyAttackState(controller, controller.GetShootingPoint(), controller.GetShootingPool(), targetToChase));
        }
    }
}
