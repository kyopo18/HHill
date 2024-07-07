using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class PatrolState : AIState
{
    private int wayPointIndex = 0;

    public PatrolState(AIController contr) : base(contr)
    {

    }

    public override void OnStateEnter()
    {
        //Debug.Log("Patrol entered");
     // object    .Method   .AnotherMethod(object.YetAnotherMethod[ArrayofWaypoints].position?
        controller.GetAgent().SetDestination(controller.GetPath()[wayPointIndex].position);

    }

    public override void OnStateExit()
    {
        //Debug.Log("Patrol exit");
    }

    public override void OnStateRun()
    {
        // Debug.Log(controller.GetAgent().remainingDistance);
        if (controller.GetAgent().hasPath && controller.GetAgent().remainingDistance <= controller.GetAgent().stoppingDistance) //returning true all the time, needs a fix
        {
            controller.GetAgent().SetDestination(controller.GetPath()[wayPointIndex].position);
            //If your array is out of bounds you go back to the first index
            wayPointIndex++;
            if (wayPointIndex >= controller.GetPath().Length)
            {
                wayPointIndex = 0;
            }
            
            //Debug.Log(wayPointIndex);
        }
    }
}
