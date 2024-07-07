using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public abstract class AITurretState
{
    protected AITurretController controller;
    public AITurretState(AITurretController contr)
    {
        controller = contr;
    }

    public abstract void OnStateEnter();


    public abstract void OnStateExit();



    public abstract void OnStateRun();

    public abstract void NextState();


}
