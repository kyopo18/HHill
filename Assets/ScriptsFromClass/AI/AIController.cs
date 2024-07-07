using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{

    [SerializeField] private Transform[] targets;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform shootingPoint;
    [SerializeField] private ObjectPool pool;


    public AIState currentState;

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(new PatrolState(this));
    }

    // Update is called once per frame
    void Update()
    {

        currentState.OnStateRun();
    }

    public void ChangeState(AIState state)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
        }

        currentState = state;
        currentState.OnStateEnter();
    }

    public NavMeshAgent GetAgent()
    {
        return agent;
    }

    public Transform[] GetPath()
    {
        return targets;
    }

    public void SetPath(List <Transform> NewPath)
    {
       targets = new Transform[NewPath.Count];
        for (int i = 0; i < NewPath.Count; ++i)
        {
            targets[i] = NewPath[i];
        }
    }

    public Transform GetShootingPoint()
    {
        return shootingPoint;
    }

    public ObjectPool GetShootingPool()
    {
        return pool;
    }

}
